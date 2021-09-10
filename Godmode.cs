using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class Godmode : MonoBehaviour
    {
        private HealthManager HM;
        
        private void Update()
        {
            HM = gameObject.GetComponent<HealthManager>();
            StartCoroutine(godMode());
        }
        private IEnumerator godMode()
        {
            HM.hp = 69420;
            return null;
        }
    }
}