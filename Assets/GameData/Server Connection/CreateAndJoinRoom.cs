using Photon.Pun;
using Photon.Realtime;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.AI;

namespace TSGameDev.Core.Network
{
    public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
    {
        RoomOptions roomOptions;

        public TMP_InputField createInput;
        public TMP_InputField joinInput;

        public void CreateRoom()
        {
            roomOptions = new();
            roomOptions.MaxPlayers = 0;
            PhotonNetwork.CreateRoom(createInput.text, roomOptions);
        }

        public override void OnCreatedRoom()
        {
            print("Created Room");
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            print("Failed To Create Room");
        }

        public void JoinRoom()
        {
            PhotonNetwork.JoinRoom(joinInput.text);
        }

        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel("CollectorGame");
            print("Joined Room");
        }

        public override void OnJoinRoomFailed(short returnCode, string message)
        {
            print(message);
        }
    }
}

