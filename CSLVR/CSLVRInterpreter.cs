using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Core;

namespace CSLVR
{
    class CSLVRInterpreter : GameInterpreter
    {
        public override IEnumerable<IActor> Actors
        {
            get
            {
                yield break;
            }
        }

        public override bool IsAllowedEffect(MonoBehaviour effect)
        {
            var name = effect.GetType().Name;
            //if (name == "ToneMapping" || name == "ColorCorrectionLut" || name == "TiltShiftEffect")
            //{
            //    return false;
            //}
            return base.IsAllowedEffect(effect);
        }

        public override bool IsUICamera(Camera camera)
        {
            if (camera.name == "UIView" || camera.name == "LoadingManager")
            {
                VRLog.Info("ui camera {0}", camera.name);
                return true;
            }
            return base.IsUICamera(camera);
        }

        public override int DefaultCullingMask
        {
            get
            {
                return ~0;
            }
        }
    }
}
