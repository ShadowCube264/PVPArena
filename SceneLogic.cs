//like 10% stolen from Pale Prince

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;

namespace PVPArena
{
    internal class SceneLogic : MonoBehaviour
    {

        private void Start()
        {
            USceneManager.activeSceneChanged += SceneChanged;
        }

        private void SceneChanged(Scene arg0, Scene arg1) => StartCoroutine(SceneChangeRoutine(arg0.name, arg1.name));

        private IEnumerator SceneChangeRoutine(string prev, string next)
        {
            if (prev != "GG_Workshop") yield break;

            StartCoroutine(BossDestroy(next));
        }

        public IEnumerator BossDestroy(string sceneName)
        {
            yield return null;
            if (sceneName == "GG_Soul_Master")
            {
                GameObject boss = GameObject.Find("Mage Lord");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Crystal_Guardian_2")
            {
                GameObject boss = GameObject.Find("Zombie Beam Miner Rematch");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Broken_Vessel")
            {
                GameObject boss = GameObject.Find("Infected Knight");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Brooding_Mawlek")
            {
                GameObject boss = GameObject.Find("Mawlek Arm L");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mawlek Arm R");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Mawlek Body");
                UnityEngine.Object.Destroy(boss3);
                GameObject boss4 = GameObject.Find("Mawlek Head");
                UnityEngine.Object.Destroy(boss4);
                GameObject boss5 = GameObject.Find("Battle Scene");
                UnityEngine.Object.Destroy(boss5);
            }
            if (sceneName == "GG_Collector")
            {
                GameObject boss = GameObject.Find("Jar Collector");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Crystal_Guardian")
            {
                GameObject boss = GameObject.Find("Mega Zombie Beam Miner (1)");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Dung_Defender")
            {
                GameObject boss = GameObject.Find("Dung Defender");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Failed_Champion")
            {
                GameObject boss = GameObject.Find("False Knight Dream");
                UnityEngine.Object.Destroy(boss);
                GameObject camera = GameObject.Find("CamLock Intro");
                UnityEngine.Object.Destroy(camera);
            }
            if (sceneName == "GG_False_Knight")
            {
                GameObject sceneManager = GameObject.Find("_SceneManager");
                sceneManager.AddComponent<FalseKnightSpecificCameraFix>();
            }
            if (sceneName == "GG_Flukemarm")
            {
                GameObject boss = GameObject.Find("Fluke Mother");
                UnityEngine.Object.Destroy(boss);
                GameObject camera = GameObject.Find("CameraLockArea Intro");
                UnityEngine.Object.Destroy(camera);
            }
            if (sceneName == "GG_Ghost_Galien")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Galien");
                UnityEngine.Object.Destroy(boss);
                GameObject hammer = GameObject.Find("Galien Hammer");
                UnityEngine.Object.Destroy(hammer);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Gorb")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Slug");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Hu")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Hu");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Markoth")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Markoth");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Marmu")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Marmu");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_No_Eyes")
            {
                GameObject boss = GameObject.Find("Ghost Warrior No Eyes");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Xero")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Xero");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_God_Tamer")
            {
                GameObject boss = GameObject.Find("Lancer");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Lobster");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Entry Object");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Grey_Prince_Zote")
            {
                GameObject boss = GameObject.Find("Grey Prince");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Grimm")
            {
                GameObject boss = GameObject.Find("Grimm Boss");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Real Bat");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Grimm Scene");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Grimm_Nightmare")
            {
                GameObject boss = GameObject.Find("Nightmare Grimm Boss");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Gruz_Mother")
            {
                GameObject boss = GameObject.Find("Giant Fly");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Hive_Knight")
            {
                GameObject boss = GameObject.Find("Hive Knight");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Hollow_Knight")
            {
                GameObject boss = GameObject.Find("HK Prime");
                UnityEngine.Object.Destroy(boss);
                GameObject camera = GameObject.Find("CameraLockArea Intro");
                UnityEngine.Object.Destroy(camera);

            }
            if (sceneName == "GG_Hornet_1")
            {
                GameObject boss = GameObject.Find("Hornet Boss 1");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Hornet_2")
            {
                GameObject boss = GameObject.Find("Hornet Boss 2");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Lost_Kin")
            {
                GameObject boss = GameObject.Find("Lost Kin");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Mantis_Lords")
            {
                GameObject boss = GameObject.Find("Mantis Battle");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mantis Lord S1");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Mantis Lord S2");
                UnityEngine.Object.Destroy(boss3);
                GameObject boss4 = GameObject.Find("Mantis Lord");
                UnityEngine.Object.Destroy(boss4);
                GameObject throne = GameObject.Find("Mantis Lord Throne 1");
                UnityEngine.Object.Destroy(throne);
                GameObject throne2 = GameObject.Find("Mantis Lord Throne 2");
                UnityEngine.Object.Destroy(throne2);
                GameObject throne3 = GameObject.Find("Mantis Lord Throne 3");
                UnityEngine.Object.Destroy(throne3);
            }
            if (sceneName == "GG_Mega_Moss_Charger")
            {
                GameObject boss = GameObject.Find("Mega Moss Charger");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Nailmasters")
            {
                GameObject boss = GameObject.Find("Oro");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mato");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Nosk")
            {
                GameObject boss = GameObject.Find("Mimic Spider");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Nosk_Hornet")
            {
                GameObject boss = GameObject.Find("Hornet Nosk");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Nosk Transform");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Oblobbles")
            {
                GameObject boss = GameObject.Find("Mega Fat Bee");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mega Fat Bee (1)");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Painter")
            {
                GameObject boss = GameObject.Find("Sheo Boss");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Radiance")
            {
                GameObject boss = GameObject.Find("Absolute Radiance");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Boss Control");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Sly")
            {
                GameObject boss = GameObject.Find("Sly Boss");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Soul_Tyrant")
            {
                GameObject boss = GameObject.Find("Dream Mage Lord");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Traitor_Lord")
            {
                GameObject boss = GameObject.Find("Mantis Traitor Lord");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Uumuu")
            {
                GameObject boss = GameObject.Find("Mega Jellyfish GG");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Jellyfish Spawner");
                UnityEngine.Object.Destroy(boss2);
                GameObject camera = GameObject.Find("CameraLockArea Intro");
                UnityEngine.Object.Destroy(camera);
            }
            if (sceneName == "GG_Vengefly")
            {
                GameObject boss = GameObject.Find("Giant Buzzer Col");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Watcher_Knights")
            {
                GameObject boss = GameObject.Find("Black Knight 1");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Black Knight 2");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Black Knight 3");
                UnityEngine.Object.Destroy(boss3);
                GameObject boss4 = GameObject.Find("Black Knight 4");
                UnityEngine.Object.Destroy(boss4);
                GameObject boss5 = GameObject.Find("Black Knight 5");
                UnityEngine.Object.Destroy(boss5);
                GameObject boss6 = GameObject.Find("Black Knight 6");
                UnityEngine.Object.Destroy(boss6);
            }
            if (sceneName == "GG_White_Defender")
            {
                GameObject boss = GameObject.Find("White Defender");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Mage_Knight")
            {
                GameObject boss = GameObject.Find("Mage Knight");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Vengefly_V")
            {
                GameObject boss = GameObject.Find("Giant Buzzer Col");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Giant Buzzer Col (1)");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Gruz_Mother_V")
            {
                GameObject boss = GameObject.Find("Giant Fly");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Brooding_Mawlek_V")
            {
                GameObject boss = GameObject.Find("Mawlek Arm L");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mawlek Arm R");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Mawlek Body");
                UnityEngine.Object.Destroy(boss3);
                GameObject boss4 = GameObject.Find("Mawlek Head");
                UnityEngine.Object.Destroy(boss4);
                GameObject boss5 = GameObject.Find("Battle Scene");
                UnityEngine.Object.Destroy(boss5);
            }
            if (sceneName == "GG_Mantis_Lords_V")
            {
                GameObject boss = GameObject.Find("Mantis Battle");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Mantis Lord S1");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Mantis Lord S2");
                UnityEngine.Object.Destroy(boss3);
                GameObject boss4 = GameObject.Find("Mantis Lord S3");
                UnityEngine.Object.Destroy(boss4);
                GameObject boss5 = GameObject.Find("Mantis Lord");
                UnityEngine.Object.Destroy(boss5);
                GameObject throne = GameObject.Find("Mantis Lord Throne 1");
                UnityEngine.Object.Destroy(throne);
                GameObject throne2 = GameObject.Find("Mantis Lord Throne 2");
                UnityEngine.Object.Destroy(throne2);
                GameObject throne3 = GameObject.Find("Mantis Lord Throne 3");
                UnityEngine.Object.Destroy(throne3);
            }
            if (sceneName == "GG_Uumuu_V")
            {
                GameObject boss = GameObject.Find("Mega Jellyfish GG");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Jellyfish Spawner");
                UnityEngine.Object.Destroy(boss2);
                GameObject camera = GameObject.Find("CameraLockArea Intro");
                UnityEngine.Object.Destroy(camera);
            }
            if (sceneName == "GG_Ghost_Gorb_V")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Slug");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Markoth_V")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Markoth");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Marmu_V")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Marmu");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_No_Eyes_V")
            {
                GameObject boss = GameObject.Find("Ghost Warrior No Eyes");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Ghost_Xero_V")
            {
                GameObject boss = GameObject.Find("Ghost Warrior Xero");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("GG Ghost Boss Title");
                UnityEngine.Object.Destroy(boss2);
                GameObject boss3 = GameObject.Find("Warrior");
                UnityEngine.Object.Destroy(boss3);
            }
            if (sceneName == "GG_Mage_Knight_V")
            {
                GameObject boss = GameObject.Find("Mage Knight");
                UnityEngine.Object.Destroy(boss);
                GameObject boss2 = GameObject.Find("Balloon Spawner");
                UnityEngine.Object.Destroy(boss2);
            }
            if (sceneName == "GG_Collector_V")
            {
                GameObject boss = GameObject.Find("Jar Collector");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Nosk_V")
            {
                GameObject boss = GameObject.Find("Mimic Spider");
                UnityEngine.Object.Destroy(boss);
            }
            if (sceneName == "GG_Mighty_Zote")
            {
                GameObject boss = GameObject.Find("Battle Control");
                UnityEngine.Object.Destroy(boss);
            }
        }

        private void OnDestroy()
        {
            USceneManager.activeSceneChanged -= SceneChanged;
        }
    }
}