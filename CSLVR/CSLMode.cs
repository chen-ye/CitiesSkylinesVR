using System;
using System.Collections.Generic;
using System.Linq;
using VRGIN.Controls;
using VRGIN.Controls.Tools;
using VRGIN.Core;
using VRGIN.Modes;
using VRGIN.Visuals;
using UnityEngine;
using Valve.VR;
using static global::VRGIN.Visuals.GUIMonitor;


namespace CSLVR
{

    public enum LockMode
    {
        None,
        XZPlane
    }

    public class CSLMode : SeatedMode
    {
        public override IEnumerable<Type> Tools
        {
            get
            {
                return new Type[] {};
            }
        }


    }

}
