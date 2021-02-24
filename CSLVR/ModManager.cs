using ColossalFramework;
using ColossalFramework.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CSLVR
{
    class ModManager : MonoBehaviour
    {
        private Camera _camera;

        public void Awake()
        {

        }

        public void Start()
        {
            try
            {
                _camera = Camera.main;
            }
            catch (Exception e)
            {
                Debug.Log("[CSLVR!] ModManager:Start -> Exception: " + e.Message);
            }
        }
    }
}
