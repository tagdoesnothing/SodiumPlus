using BepInEx;
using UnityEngine;

namespace ModTemplate
{
    [BepInPlugin("com.tagdoesnothing.SodiumPlus", "SodiumPlus", "1.0.0")]
    internal class Plugin : BaseUnityPlugin
    {
        public void Start() { GorillaTagger.OnPlayerSpawned(OnGameInit); }

        public void OnGameInit()
        {
            QualitySettings.lodBias = 0.0f;
            QualitySettings.antiAliasing = 0;
            QualitySettings.enableLODCrossFade = false;
            QualitySettings.anisotropicFiltering = 0;
            QualitySettings.currentLevel = QualityLevel.Fastest;
            QualitySettings.globalTextureMipmapLimit = 0;
            QualitySettings.maximumLODLevel = 0;
            QualitySettings.shadowResolution = 0;
            QualitySettings.shadowDistance = 0;
            QualitySettings.shadowResolution = ShadowResolution.Low;
            QualitySettings.shadows = ShadowQuality.Disable;
            QualitySettings.shadowProjection = 0;
        }
    }
}
