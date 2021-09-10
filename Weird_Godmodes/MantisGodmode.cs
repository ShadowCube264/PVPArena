using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class MantisGodmode : MonoBehaviour
    {
        private GameObject boss;
        private GameObject boss1;
        private GameObject boss2;

        private void Update()
        {
            boss = GameObject.Find("Mantis Lord");
            if (boss != null)
            {
                boss.AddComponent<MantisKiller>();
            }

            boss1 = GameObject.Find("Mantis Lord S1");
            boss2 = GameObject.Find("Mantis Lord S2");
            if (boss1 != null && boss2 != null)
            {
                boss1.AddComponent<Godmode>();
                boss2.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}