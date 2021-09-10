using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class MarkothGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Ghost Warrior Markoth");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}