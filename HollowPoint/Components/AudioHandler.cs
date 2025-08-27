using HollowPoint.Util;
using System.Collections;
using UnityEngine;

namespace HollowPoint.Components;

public sealed class AudioHandler : MonoBehaviour
{
    public static AudioHandler instance { get; private set; } = null!;

    private bool canPlayKillSound = true;
    private float canPlayKillSoundTimer = 0.02f;
    private Dictionary<string, GameObject> sfxGameObjectDictionary = [];
    public enum HollowPointSoundType
    {
        ShootSFXGO,
        EnemyHitSFXGO,
        EnemyKillSFXGO,
        TerrainHitSFXGO,
        ClickSFXGO,
        InfusionSFXGO,
        DiveDetonateSFXGO,
        MortarWhistleSFXGO,
        MortarExplosionSFXGO,
        ThrowDaggerSFXGO,
        FireSelectSFXGO,
        DrawAndHolsterGun
    }

    public void Awake()
    {
        if (instance == null)
            instance = this;

        StartCoroutine(AudioHandlerInit());
    }

    public void Update()
    {
        if (canPlayKillSoundTimer > 0 && !canPlayKillSound)
        {
            canPlayKillSoundTimer -= Time.deltaTime * 1;
            if (canPlayKillSoundTimer <= 0)
            {
                canPlayKillSound = true;
            }
        }
    }

    public IEnumerator AudioHandlerInit()
    {
        foreach (HollowPointSoundType enumName in (HollowPointSoundType[])Enum.GetValues(typeof(HollowPointSoundType)))
        {
            string goName = enumName.ToString();
            var sgo = new GameObject(goName, typeof(AudioSource));
            sfxGameObjectDictionary.Add(goName, sgo);
            DontDestroyOnLoad(sgo);
        }

        yield return null;
    }

    public void PlayGunSoundEffect(string gunName)
    {
        try
        {
            LoadAssets.sfxDictionary.TryGetValue("shoot_sfx_" + gunName.ToLower() + ".wav", out AudioClip ac);
            AudioSource audios = sfxGameObjectDictionary["ShootSFXGO"].GetComponent<AudioSource>();
            audios.clip = ac;
            audios.pitch = URandom.Range(0.9f, 1.1f);
            audios.PlayOneShot(audios.clip, GameManager.instance.GetImplicitCinematicVolume());
        }
        catch (Exception e)
        {
            Log.Error("HP_AudioHandler.cs, cannot find the SFX {0}: {1}", gunName, e);
        }
    }

    public void PlayMiscSoundEffect(HollowPointSoundType hpst, bool alteredPitch = true)
    {
        try
        {
            string soundName = "";
            float volume = GameManager.instance.GetImplicitCinematicVolume();
            switch (hpst)
            {
                case HollowPointSoundType.EnemyHitSFXGO:
                    soundName = "enemyhit" + URandom.Range(1, 6);
                    break;
                case HollowPointSoundType.EnemyKillSFXGO:
                    if (!canPlayKillSound) return;

                    soundName = "enemydead" + URandom.Range(1, 3);
                    canPlayKillSound = false;
                    canPlayKillSoundTimer = 0.04f;
                    break;
                case HollowPointSoundType.TerrainHitSFXGO:
                    soundName = "impact_0" + URandom.Range(1, 5);
                    break;
                case HollowPointSoundType.ThrowDaggerSFXGO:
                    soundName = "sfx_daggerthrow_0" + URandom.Range(1, 3);
                    break;
                case HollowPointSoundType.ClickSFXGO:
                    soundName = "cantfire";
                    break;
                case HollowPointSoundType.InfusionSFXGO:
                    soundName = "infusionsound";
                    break;
                case HollowPointSoundType.DiveDetonateSFXGO:
                    soundName = "divedetonate";
                    break;
                case HollowPointSoundType.MortarWhistleSFXGO:
                    soundName = "mortarclose";
                    break;
                case HollowPointSoundType.MortarExplosionSFXGO:
                    soundName = "mortarexplosion";
                    break;
                case HollowPointSoundType.FireSelectSFXGO:
                    soundName = "sfx_fireselect";
                    break;
                default:
                    Log.Error("{0} Sound Enum Not Yet Implemented Please Fix This You Moron", hpst);
                    break;
            }

            LoadAssets.sfxDictionary.TryGetValue(soundName + ".wav", out AudioClip ac);
            AudioSource audios = sfxGameObjectDictionary[hpst.ToString()].GetComponent<AudioSource>();

            audios.clip = ac;
            if (alteredPitch) audios.pitch = URandom.Range(0.85f, 1.15f);
            else audios.pitch = 1;
            audios.PlayOneShot(audios.clip, volume);
        }
        catch (Exception e)
        {
            Log.Error("HP_AudioHandler.cs, cannot find the SFX {0}", e);
        }
    }

    public void PlayDrawHolsterSound(string soundName)
    {
        LoadAssets.sfxDictionary.TryGetValue("weapon_" + soundName + ".wav", out AudioClip ac);
        AudioSource audios = sfxGameObjectDictionary["DrawAndHolsterGun"].GetComponent<AudioSource>();
        audios.clip = ac;
        audios.PlayOneShot(audios.clip, GameManager.instance.GetImplicitCinematicVolume());
    }
}
