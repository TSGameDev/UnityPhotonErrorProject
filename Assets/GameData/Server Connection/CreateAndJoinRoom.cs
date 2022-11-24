using Photon.Pun;
using TMPro;

namespace TSGameDev.Core.Network
{
    public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
    {
        public TMP_InputField createInput;
        public TMP_InputField joinInput;

        public void CreateRoom()
        {
            PhotonNetwork.CreateRoom(createInput.text);
        }

        public void JoinRoom()
        {
            PhotonNetwork.JoinRoom(joinInput.text);
        }

        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel("CollectorGame");
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            print("Failed To Create Room");
        }

    }
}

