using ICities;
using System;
using System.Reflection;
using CitiesHarmony.API;
using VRGIN.Core;
using VRGIN.Helpers;
using VRGIN.Modes;

namespace CSLVR
{
    public class Base : IUserMod
    {
        public string Name => "CSLVR";
        public string Description => "VR for Cities Skylines";
    
        public void OnEnabled()     
        {
            HarmonyHelper.DoOnHarmonyReady(Patcher.PatchAll);
            if (SteamVRDetector.IsRunning)
            {
                var context = new CSLVRContext();
                VRManager.Create<CSLVRInterpreter>(context);
                VR.Manager.SetMode<CSLMode>();
            }
        }

        public void OnDisabled()
        {
            if (HarmonyHelper.IsHarmonyInstalled) Patcher.UnpatchAll();
        } 
    }
}
