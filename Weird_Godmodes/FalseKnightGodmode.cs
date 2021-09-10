using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class FalseKnightGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("False Knight New");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}