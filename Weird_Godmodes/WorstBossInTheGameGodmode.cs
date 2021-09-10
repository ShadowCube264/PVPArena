using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class WorstBossInTheGameGodmode : MonoBehaviour
    {
        private GameObject boss;
        private GameObject boss2;

        private void Update()
        {
            boss = GameObject.Find("Lancer");
            boss2 = GameObject.Find("Lobster");
            if (boss != null && boss2 != null)
            {
                boss.AddComponent<Godmode>();
                boss2.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}