using Modding;
using System.Collections;
using UnityEngine;

namespace PVPArena
{
    internal class OroKiller : MonoBehaviour
    {
        private HealthManager HM;

        private void Start()
        {
            HM = gameObject.GetComponent<HealthManager>();
            StartCoroutine(murderize());
        }
        private IEnumerator murderize()
        {
            HM.hp = -69;
            UnityEngine.Object.Destroy(this);
            return null;
        }
    }
}