using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class RadianceGodmode : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("Absolute Radiance");
            if (boss != null)
            {
                boss.AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}