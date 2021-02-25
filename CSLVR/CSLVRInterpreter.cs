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
                return true;
            }
            return base.IsUICamera(camera);
        }

        //protected override CameraJudgement JudgeCameraInternal(Camera camera)
        //{
        //    bool guiInterested = VR.GUI.IsInterested(camera);
        //    // bool renderToTexture = camera.targetTexture == null;
        //    bool isMain = camera.CompareTag("MainCamera");
        //    if (isMain)
        //    {
        //        if (guiInterested)
        //        {
        //            return CameraJudgement.GUIAndCamera;
        //        }
        //        else if (camera.CompareTag("MainCamera"))
        //        {
        //            return CameraJudgement.MainCamera;
        //        }
        //        else
        //        {
        //            return CameraJudgement.SubCamera;
        //        }
        //    }
        //    return guiInterested ? CameraJudgement.GUI : CameraJudgement.Ignore;
        //}

        //public override int DefaultCullingMask
        //{
        //    get
        //    {
        //        return ~0;
        //    }
        //}
    }
}
