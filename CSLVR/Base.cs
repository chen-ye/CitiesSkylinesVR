using ICities;
using System;
using System.Reflection;
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
            if (SteamVRDetector.IsRunning)
            {
                var context = new CSLVRContext();
                VRManager.Create<CSLVRInterpreter>(context);
                VR.Manager.SetMode<CSLMode>();
            }
        }
    }
}
