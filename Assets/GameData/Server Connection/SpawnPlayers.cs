using UnityEngine;
using UnityEngine.Events;
using Photon.Pun;

namespace TSGameDev.Core.Network
{
    public class SpawnPlayers : MonoBehaviour
    {
        public PlayerSetup[] playerSetups;

        private void Start()
        {
            int playerPosition = PhotonNetwork.CurrentRoom.PlayerCount - 1;
            AssignPlayer(playerPosition);
        }

        private void AssignPlayer(int playerPos)
        {
            playerSetups[playerPos].gameObject.SetActive(true);
            playerSetups[playerPos].Setup();
        }
    }
}