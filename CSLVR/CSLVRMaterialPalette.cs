using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Core;
using VRGIN.Helpers;
using VRGIN.Visuals;

namespace CSLVR
{
    class CSLVRMaterialPalette : IMaterialPalette
    {
        public CSLVRMaterialPalette()
        {
            Unlit = CreateUnlit();
            UnlitTransparent = CreateUnlitTransparent();
            UnlitTransparentCombined = CreateUnlitTransparentCombined();
            StandardShader = CreateStandardShader();
            Sprite = CreateSprite();

            if (!Unlit || !Unlit.shader) VRLog.Error("Could not load Unlit material!");
            if (!UnlitTransparent || !UnlitTransparent.shader) VRLog.Error("Could not load UnlitTransparent material!");
            if (!UnlitTransparentCombined || !UnlitTransparentCombined.shader) VRLog.Error("Could not load UnlitTransparentCombined material!");
            if (!StandardShader) VRLog.Error("Could not load StandardShader material!");

            if (!Sprite || !Sprite.shader)
            {
                VRLog.Warn("Could not load Sprite material! Falling back to UnlitTransparent");

                // Fall back to alternative material
                Sprite = UnlitTransparent;
            }
        }

        private Material CreateUnlitTransparentCombined()
        {
            return new Material(UnityHelper.GetShader("UnlitTransparentCombined"));
        }

        public Material UnlitTransparentCombined
        {
            get; set;
        }


        private Material CreateSprite()
        {
            return Resources.GetBuiltinResource<Material>("Sprites-Default.mat");
        }
        public Material Sprite
        {
            get; set;
        }


        private Shader CreateStandardShader()
        {
            return Shader.Find("Custom/Particles/Additive (Soft)");
            // return Shader.Find("Custom/Buildings/Building/Default");
        }
        public Shader StandardShader
        {
            get; set;
        }


        private Material CreateUnlit()
        {
            return new Material(UnityHelper.GetShader("Unlit"));
        }
        public Material Unlit
        {
            get; set;
        }


        private Material CreateUnlitTransparent()
        {
            return new Material(UnityHelper.GetShader("UnlitTransparent"));
        }
        public Material UnlitTransparent
        {
            get; set;
        }
    }
}
