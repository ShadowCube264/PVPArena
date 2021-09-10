//like 90% stolen from Pale Prince

using Modding;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;
using UObject = UnityEngine.Object;

namespace PVPArena
{
    public class PVPArena : Mod, ITogglableMod
    {

        public static PVPArena Instance { get; private set; }
        
        public override string GetVersion() => "v1.0.0";

        private string _lastScene;

        public PVPArena() : base("PVPArena") {}

        public override void Initialize()
        {
            Instance = this;
            
            Unload();
            
            ModHooks.Instance.AfterSavegameLoadHook += SaveGame;
            ModHooks.Instance.NewGameHook += AddComponent;
            USceneManager.activeSceneChanged += SceneChanged;
        }

        private void SceneChanged(Scene arg0, Scene arg1)
        {
            _lastScene = arg0.name;
        }

        public GlobalModSettings Settings = new GlobalModSettings();
        public override ModSettings GlobalSettings
        {
            get => Settings;
            set => Settings = (GlobalModSettings) value;
        }

        private void SaveGame(SaveGameData data)
        {
            AddComponent();
        }

        private void AddComponent()
        {
            if (Settings.StandardBossLevel == false)
            {
                GameManager.instance.gameObject.AddComponent<SceneLogicLevel>();
            }
            if (Settings.BossEnabled == true)
            {
                GameManager.instance.gameObject.AddComponent<SceneLogicBoss>();
            }
            else
            {
                GameManager.instance.gameObject.AddComponent<SceneLogic>();
            }
        }

        public void Unload()
        {
            ModHooks.Instance.AfterSavegameLoadHook -= SaveGame;
            ModHooks.Instance.NewGameHook -= AddComponent;
            USceneManager.activeSceneChanged -= SceneChanged;

            var finder = GameManager.instance.gameObject.GetComponent<SceneLogic>();

            if (finder != null)
                UObject.Destroy(finder);

            var finder2 = GameManager.instance.gameObject.GetComponent<SceneLogicBoss>();

            if (finder2 != null)
                UObject.Destroy(finder2);

            var finder3 = GameManager.instance.gameObject.GetComponent<SceneLogicLevel>();

            if (finder3 != null)
                UObject.Destroy(finder3);
        }
    }
    public class GlobalModSettings : ModSettings
    {
        public bool BossEnabled;
        public bool StandardBossLevel;
        public int BossLevel;
    }
}