using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class HuGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Ghost Warrior Hu");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}