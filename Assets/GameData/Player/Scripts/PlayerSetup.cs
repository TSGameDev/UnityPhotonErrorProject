using UnityEngine;
using Photon.Pun;
using TSGameDev.Core.Network;
using Cinemachine;

namespace TSGameDev
{
    public class PlayerSetup : MonoBehaviour
    {
        PhotonView photonView;
        [SerializeField] CinemachineVirtualCamera virutalCam;

        public void Setup()
        {
            photonView = GetComponent<PhotonView>();
            virutalCam.gameObject.SetActive(true);
            photonView.RPC("GameobjectActive", RpcTarget.All);
        }

        [PunRPC]
        private void GameobjectActive()
        {
            this.gameObject.SetActive(true);
        }
    }
}
