using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PhotonView photonView = GetComponent<PhotonView>();
        string playerNickName = photonView.Owner.NickName;
        if (other.CompareTag("SampleScene") && photonView.IsMine)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                Hashtable firstPlayerName = new Hashtable { { "FirstPlayerName", playerNickName } };
                PhotonNetwork.CurrentRoom.SetCustomProperties(firstPlayerName);
                Debug.Log($"{firstPlayerName} ¿˙¿Â");
            }
        }
    }
}
