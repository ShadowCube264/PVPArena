//like 10% stolen from Pale Prince

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;

namespace PVPArena
{
    internal class SceneLogicLevel : MonoBehaviour
    {

        private void Start()
        {
            USceneManager.activeSceneChanged += SceneChanged;
        }

        private void SceneChanged(Scene arg0, Scene arg1) => StartCoroutine(SceneChangeRoutine(arg0.name, arg1.name));

        private IEnumerator SceneChangeRoutine(string prev, string next)
        {
            if (prev != "GG_Workshop") yield break;

            StartCoroutine(BossGodmode(next));
        }

        public IEnumerator BossGodmode(string sceneName)
        {
            yield return null;
            if (sceneName == "GG_Soul_Master")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Crystal_Guardian_2")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Broken_Vessel")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Brooding_Mawlek")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Collector")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Crystal_Guardian")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Dung_Defender")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Failed_Champion")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_False_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Flukemarm")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Galien")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Gorb")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Hu")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Markoth")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Marmu")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_No_Eyes")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Xero")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_God_Tamer")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Grey_Prince_Zote")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Grimm")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Grimm_Nightmare")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Gruz_Mother")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Hive_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Hollow_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();

            }
            if (sceneName == "GG_Hornet_1")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Hornet_2")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Lost_Kin")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mantis_Lords")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mega_Moss_Charger")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Nailmasters")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Nosk")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Nosk_Hornet")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Oblobbles")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Painter")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Radiance")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Sly")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Soul_Tyrant")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Traitor_Lord")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Uumuu")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Vengefly")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Watcher_Knights")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_White_Defender")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mage_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Vengefly_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Gruz_Mother_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Brooding_Mawlek_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mantis_Lords_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Uumuu_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Gorb_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Markoth_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Marmu_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_No_Eyes_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Ghost_Xero_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mage_Knight_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Collector_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Nosk_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
            if (sceneName == "GG_Mighty_Zote")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<BossLevelForce>();
            }
        }

        private void OnDestroy()
        {
            USceneManager.activeSceneChanged -= SceneChanged;
        }
    }
}