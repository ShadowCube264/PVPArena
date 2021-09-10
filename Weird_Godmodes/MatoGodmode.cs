using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class MatoGodmode : MonoBehaviour
    {
        private HealthManager HM;

        private void Update()
        {
            HM = GameObject.Find("Oro").GetComponent<HealthManager>();
            if (HM.hp > 0)
            {
                gameObject.AddComponent<Godmode>();
                GameObject.Find("Oro").AddComponent<Godmode>();
                UnityEngine.Object.Destroy(this);
            }
        }
    }
}