using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

namespace TSGameDev.Core.Network
{
    public class ConnectToServer : MonoBehaviourPunCallbacks
    {
        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            PhotonNetwork.JoinLobby();
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        public override void OnJoinedLobby()
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}

