using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class MarmuGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Ghost Warrior Marmu");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}