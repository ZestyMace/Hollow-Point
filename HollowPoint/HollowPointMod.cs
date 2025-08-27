using HollowPoint.Components;
using HollowPoint.Util;
using Modding;
using System.Reflection;

namespace HollowPoint;

public sealed class HollowPointMod : Mod
{
    public static HollowPointMod Instance { get; private set; } = null!;

    public HollowPointMod() : base("Hollow Point")
    {
        Instance = this;
    }

    public override string GetVersion() =>
        Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public override void Initialize()
    {
        LoadAssets.LoadResources();

        ModHooks.AfterSavegameLoadHook += static (_) => NewGame();
        ModHooks.NewGameHook += NewGame;
    }

    private static void NewGame()
    {
        GameManager.instance.gameObject.AddComponent<HollowPointPrefabs>();
        GameManager.instance.gameObject.AddComponent<AttackHandler>();
        GameManager.instance.gameObject.AddComponent<OrientationHandler>();
        GameManager.instance.gameObject.AddComponent<WeaponSwapAndStatHandler>();
        GameManager.instance.gameObject.AddComponent<UIHandler>();
        GameManager.instance.gameObject.AddComponent<DamageOverride>();
        GameManager.instance.gameObject.AddComponent<HollowPointSprites>();
        GameManager.instance.gameObject.AddComponent<HeatHandler>();
        GameManager.instance.gameObject.AddComponent<SpellControlOverride>();
        GameManager.instance.gameObject.AddComponent<Stats>();
        GameManager.instance.gameObject.AddComponent<HudController>();
        GameManager.instance.gameObject.AddComponent<AudioHandler>();
    }
}