//like 90% stolen from Pale Prince

using Modding;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;
using UObject = UnityEngine.Object;
using System.Collections.Generic;

namespace PVPArena
{
    public class PVPArena : Mod, IMenuMod, ITogglableMod
    {

        public bool BossEnabled;
        public bool StandardBossLevel;
        public int BossLevel;

        public bool ToggleButtonInsideMenu => true;

        public static PVPArena Instance { get; private set; }
        
        public override string GetVersion() => "v1.0.0";

        private string _lastScene;

        public PVPArena() : base("PVPArena") {}

        public override void Initialize()
        {
            Instance = this;
            
            Unload();
            
            ModHooks.AfterSavegameLoadHook += SaveGame;
            ModHooks.NewGameHook += AddComponent;
            USceneManager.activeSceneChanged += SceneChanged;
        }

        public List<IMenuMod.MenuEntry> GetMenuData(IMenuMod.MenuEntry? toggleButtonEntry)
        {
            IMenuMod.MenuEntry modEnabler = new IMenuMod.MenuEntry {
                Name = "Enable Mod",
                Description = "Turn the mod on or off",
                Values = toggleButtonEntry.Value.Values,
                Saver = toggleButtonEntry.Value.Saver,
                Loader = toggleButtonEntry.Value.Loader
            };
            return new List<IMenuMod.MenuEntry>
            {
                modEnabler,
                new IMenuMod.MenuEntry {
                    Name = "Enable Bosses",
                    Description = "Turn on to have invincible bosses in the arenas",
                    Values = new string[] {
                        "Off",
                        "On"
                    },
                    Saver = opt => this.BossEnabled = opt == 1,
                    Loader = () => this.BossEnabled ? 0 : 1
                },
                new IMenuMod.MenuEntry {
                    Name = "Force Boss Level",
                    Description = "Leave on to force the damage multiplier to the level below",
                    Values = new string[] {
                        "On",
                        "Off"
                    },
                    Saver = opt => this.StandardBossLevel = opt == 0,
                    Loader = () => this.StandardBossLevel ? 0 : 1
                },
                new IMenuMod.MenuEntry {
                    Name = "Boss Level",
                    Description = "The damage multiplier to be forced",
                    Values = new string[] {
                        "Attuned",
                        "Ascended",
                        "Radiant"
                    },
                    Saver = opt => this.BossLevel = opt,
                    Loader = () => this.BossLevel
                }
            };
        }

        private void SceneChanged(Scene arg0, Scene arg1)
        {
            _lastScene = arg0.name;
        }

        private void SaveGame(SaveGameData data)
        {
            AddComponent();
        }

        private void AddComponent()
        {
            if (this.StandardBossLevel == false)
            {
                GameManager.instance.gameObject.AddComponent<SceneLogicLevel>();
            }
            if (this.BossEnabled == true)
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
            ModHooks.AfterSavegameLoadHook -= SaveGame;
            ModHooks.NewGameHook -= AddComponent;
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
}