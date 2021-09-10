using Modding;
using UnityEngine;

namespace PVPArena
{
    internal class BossLevelForce : MonoBehaviour
    {
        private void Start()
        {
            BossSceneController.Instance.BossLevel = PVPArena.Instance.Settings.BossLevel;
        }
    }
}