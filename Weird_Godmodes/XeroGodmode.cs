using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class XeroGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Ghost Warrior Xero");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}