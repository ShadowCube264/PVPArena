using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class FalseKnightSpecificCameraFix : MonoBehaviour
    {
        private GameObject boss;

        private void Update()
        {
            boss = GameObject.Find("False Knight New");
            if (boss != null)
            {
                UnityEngine.Object.Destroy(boss);
                UnityEngine.Object.Destroy(GameObject.Find("CamLock Intro"));
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}