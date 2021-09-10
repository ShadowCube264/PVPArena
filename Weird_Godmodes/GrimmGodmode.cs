using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class GrimmGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Grimm Boss");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}