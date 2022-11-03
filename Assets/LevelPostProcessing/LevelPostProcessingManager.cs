using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Volume))]
public class LevelPostProcessingManager : MonoBehaviour
{
    [Header("Volume Components")]
    private VolumeProfile volumeProfile;
    private Volume volume;

    [Header("Effects")]
    private DepthOfField depthOfField;
    private ColorAdjustments colorAdjustments;
    private FilmGrain filmGrain;
    private Vignette vignette;
    private PaniniProjection paniniProjection;
    private LensDistortion lensDistortion;
    private MotionBlur motionBlur;

    private void Awake()
    {
        volume = GetComponent<Volume>();
        volumeProfile = volume.sharedProfile;
    }

    public void ActiveDepthOfFieldEffect()
    {
        if (volumeProfile.TryGet<DepthOfField>(out depthOfField))
        {
            depthOfField.active = true;
        }
    }

    public void DeactivateOfFieldEffect()
    {
        if (volumeProfile.TryGet<DepthOfField>(out depthOfField))
        {
            depthOfField.active = false;
        }
    }

    public void ActiveFog1Effect()
    {
        if (volumeProfile.TryGet<ColorAdjustments>(out colorAdjustments))
        {
            colorAdjustments.active = true;
        }
    }

    public void DeactivateFog1Effect()
    {
        if (volumeProfile.TryGet<ColorAdjustments>(out colorAdjustments))
        {
            colorAdjustments.active = false;
        }
    }

    public void ActiveFog2Effect()
    {
        if (volumeProfile.TryGet<FilmGrain>(out filmGrain))
        {
            filmGrain.active = true;
        }
    }

    public void DeactivateFog2Effect()
    {
        if (volumeProfile.TryGet<FilmGrain>(out filmGrain))
        {
            filmGrain.active = false;
        }
    }

    public void ActiveVignetteEffect()
    {
        if (volumeProfile.TryGet<Vignette>(out vignette))
        {
            vignette.active = true;
        }
    }

    public void DeactivateVignetteEffect()
    {
        if (volumeProfile.TryGet<Vignette>(out vignette))
        {
            vignette.active = false;
        }
    }

    public void ActivePaniniProjectionEffect()
    {
        if (volumeProfile.TryGet<PaniniProjection>(out paniniProjection))
        {
            paniniProjection.active = true;
        }
    }

    public void DeactivatePaniniProjectionEffect()
    {
        if (volumeProfile.TryGet<PaniniProjection>(out paniniProjection))
        {
            paniniProjection.active = false;
        }
    }

    public void ActiveLensDistortionEffect()
    {
        if (volumeProfile.TryGet<LensDistortion>(out lensDistortion))
        {
            lensDistortion.active = true;
        }
    }

    public void DeactivateLensDistortionEffect()
    {
        if (volumeProfile.TryGet<LensDistortion>(out lensDistortion))
        {
            lensDistortion.active = false;
        }
    }

    public void ActiveMotionBlurEffect()
    {
        if (volumeProfile.TryGet<MotionBlur>(out motionBlur))
        {
            motionBlur.active = true;
        }
    }

    public void DeactivateMotionBlurEffect()
    {
        if (volumeProfile.TryGet<MotionBlur>(out motionBlur))
        {
            motionBlur.active = false;
        }
    }
}