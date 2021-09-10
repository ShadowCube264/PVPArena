using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class MawlekGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Mawlek Body");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}