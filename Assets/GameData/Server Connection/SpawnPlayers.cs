using UnityEngine;
using Photon.Pun;

namespace TSGameDev.Core.Network
{
    public class SpawnPlayers : MonoBehaviour
    {
        public GameObject playerPrefab;
        public GameObject[] playerSpawnPoints;

        private void Start()
        {
            Vector3 playerSpawnLocation;

            if (playerSpawnPoints.Length == 0)
                playerSpawnLocation = Vector3.zero;
            else
            {
                int SpawnPoint = Random.Range(0, playerSpawnPoints.Length);
                playerSpawnLocation = playerSpawnPoints[SpawnPoint].transform.position;
            }
            
            PhotonNetwork.Instantiate(playerPrefab.name, playerSpawnLocation, Quaternion.identity);
        }
    }
}