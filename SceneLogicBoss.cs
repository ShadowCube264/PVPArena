//like 10% stolen from Pale Prince

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;

namespace PVPArena
{
    internal class SceneLogicBoss : MonoBehaviour
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
                GameObject boss = GameObject.Find("Mage Lord");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Crystal_Guardian_2")
            {
                GameObject boss = GameObject.Find("Zombie Beam Miner Rematch");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Broken_Vessel")
            {
                GameObject boss = GameObject.Find("Infected Knight");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Brooding_Mawlek")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MawlekGodmode>();
            }
            if (sceneName == "GG_Collector")
            {
                GameObject boss = GameObject.Find("Jar Collector");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Crystal_Guardian")
            {
                GameObject boss = GameObject.Find("Mega Zombie Beam Miner (1)");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Dung_Defender")
            {
                GameObject boss = GameObject.Find("Dung Defender");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Failed_Champion")
            {
                GameObject boss = GameObject.Find("False Knight Dream");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_False_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<FalseKnightGodmode>();
            }
            if (sceneName == "GG_Flukemarm")
            {
                GameObject boss = GameObject.Find("Fluke Mother");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Ghost_Galien")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<GalienGodmode>();
            }
            if (sceneName == "GG_Ghost_Gorb")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<GorbGodmode>();
            }
            if (sceneName == "GG_Ghost_Hu")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<HuGodmode>();
            }
            if (sceneName == "GG_Ghost_Markoth")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MarkothGodmode>();
            }
            if (sceneName == "GG_Ghost_Marmu")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MarmuGodmode>();
            }
            if (sceneName == "GG_Ghost_No_Eyes")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<NoEyesGodmode>();
            }
            if (sceneName == "GG_Ghost_Xero")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<XeroGodmode>();
            }
            if (sceneName == "GG_God_Tamer")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<WorstBossInTheGameGodmode>();
            }
            if (sceneName == "GG_Grey_Prince_Zote")
            {
                GameObject boss = GameObject.Find("Grey Prince");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Grimm")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<GrimmGodmode>();
            }
            if (sceneName == "GG_Grimm_Nightmare")
            {
                GameObject boss = GameObject.Find("Nightmare Grimm Boss");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Gruz_Mother")
            {
                GameObject boss = GameObject.Find("Giant Fly");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Hive_Knight")
            {
                GameObject boss = GameObject.Find("Hive Knight");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Hollow_Knight")
            {
                GameObject boss = GameObject.Find("HK Prime");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Hornet_1")
            {
                GameObject boss = GameObject.Find("Hornet Boss 1");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Hornet_2")
            {
                GameObject boss = GameObject.Find("Hornet Boss 2");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Lost_Kin")
            {
                GameObject boss = GameObject.Find("Lost Kin");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Mantis_Lords")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MantisGodmode>();
            }
            if (sceneName == "GG_Mega_Moss_Charger")
            {
                GameObject boss = GameObject.Find("Mega Moss Charger");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Nailmasters")
            {
                GameObject boss = GameObject.Find("Oro");
                boss.AddComponent<OroKiller>();
                GameObject boss2 = GameObject.Find("Mato");
                boss2.AddComponent<MatoGodmode>();
            }
            if (sceneName == "GG_Nosk")
            {
                GameObject boss = GameObject.Find("Mimic Spider");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Nosk_Hornet")
            {
                GameObject boss = GameObject.Find("Hornet Nosk");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Oblobbles")
            {
                GameObject boss = GameObject.Find("Mega Fat Bee");
                boss.AddComponent<Godmode>();
                GameObject boss2 = GameObject.Find("Mega Fat Bee (1)");
                boss2.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Painter")
            {
                GameObject boss = GameObject.Find("Sheo Boss");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Radiance")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<RadianceGodmode>();
            }
            if (sceneName == "GG_Sly")
            {
                GameObject boss = GameObject.Find("Sly Boss");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Soul_Tyrant")
            {
                GameObject boss = GameObject.Find("Dream Mage Lord");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Traitor_Lord")
            {
                GameObject boss = GameObject.Find("Mantis Traitor Lord");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Uumuu")
            {
                GameObject boss = GameObject.Find("Mega Jellyfish GG");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Vengefly")
            {
                GameObject boss = GameObject.Find("Giant Buzzer Col");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Watcher_Knights")
            {
                GameObject boss = GameObject.Find("Black Knight 1");
                boss.AddComponent<Godmode>();
                GameObject boss2 = GameObject.Find("Black Knight 2");
                boss2.AddComponent<Godmode>();
                GameObject boss3 = GameObject.Find("Black Knight 3");
                boss3.AddComponent<Godmode>();
                GameObject boss4 = GameObject.Find("Black Knight 4");
                boss4.AddComponent<Godmode>();
                GameObject boss5 = GameObject.Find("Black Knight 5");
                boss5.AddComponent<Godmode>();
                GameObject boss6 = GameObject.Find("Black Knight 6");
                boss6.AddComponent<Godmode>();
            }
            if (sceneName == "GG_White_Defender")
            {
                GameObject boss = GameObject.Find("White Defender");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Mage_Knight")
            {
                GameObject boss = GameObject.Find("Mage Knight");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Vengefly_V")
            {
                GameObject boss = GameObject.Find("Giant Buzzer Col");
                boss.AddComponent<Godmode>();
                GameObject boss2 = GameObject.Find("Giant Buzzer Col (1)");
                boss2.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Gruz_Mother_V")
            {
                GameObject boss = GameObject.Find("Giant Fly");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Brooding_Mawlek_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MawlekGodmode>();
            }
            if (sceneName == "GG_Mantis_Lords_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<SistersGodmode>();
            }
            if (sceneName == "GG_Uumuu_V")
            {
                GameObject boss = GameObject.Find("Mega Jellyfish GG");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Ghost_Gorb_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<GorbGodmode>();
            }
            if (sceneName == "GG_Ghost_Markoth_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MarkothGodmode>();
            }
            if (sceneName == "GG_Ghost_Marmu_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<MarmuGodmode>();
            }
            if (sceneName == "GG_Ghost_No_Eyes_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<NoEyesGodmode>();
            }
            if (sceneName == "GG_Ghost_Xero_V")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<XeroGodmode>();
            }
            if (sceneName == "GG_Mage_Knight_V")
            {
                GameObject boss = GameObject.Find("Mage Knight");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Collector_V")
            {
                GameObject boss = GameObject.Find("Jar Collector");
                boss.AddComponent<Godmode>();
            }
            if (sceneName == "GG_Nosk_V")
            {
                GameObject boss = GameObject.Find("Mimic Spider");
                boss.AddComponent<Godmode>();
            }
        }

        private void OnDestroy()
        {
            USceneManager.activeSceneChanged -= SceneChanged;
        }
    }
}