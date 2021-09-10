using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class NoEyesGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Ghost Warrior No Eyes");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}