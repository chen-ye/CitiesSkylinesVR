using System.Reflection;
using ColossalFramework;
using HarmonyLib;
using UnityEngine;
using VRGIN.Core;

namespace CSLVR
{
    class Patcher
    {
        private const string HarmonyId = "chenye.CSLVR";
        private static bool _patched = false;

        public static void PatchAll() {
            if (_patched) return;

            UnityEngine.Debug.Log("CSLVR: Patching...");

            _patched = true;
            var harmony = new Harmony(HarmonyId);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public static void UnpatchAll() {
            if (!_patched) return;

            var harmony = new Harmony(HarmonyId);
            harmony.UnpatchAll(HarmonyId);

            UnityEngine.Debug.Log("CSLVR: Reverted...");
            _patched = false;
        }

        [HarmonyPatch(typeof(RenderManager), "UpdateCameraInfo")]
        public static class RenderManagerUpdateCameraInfoPatch
        {
            private static bool _setMainCamera = false;

            public static void Prefix(ref Camera ___m_mainCamera)
            {

                if (!_setMainCamera && ___m_mainCamera != VR.Camera.GetComponent<Camera>())
                {
                    Debug.Log("CSLVR: Setting Main Camera");
                    ___m_mainCamera = VR.Camera.GetComponent<Camera>();
                    _setMainCamera = true;
                }
            }
        }
    }
}
