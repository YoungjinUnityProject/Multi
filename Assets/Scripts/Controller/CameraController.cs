using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraController : MonoBehaviourPunCallbacks
{
    public Camera playerCamera;

    void Start()
    {
        if (photonView.IsMine)
        {
            playerCamera = Camera.main;
            playerCamera.transform.SetParent(transform);
            playerCamera.transform.localPosition = new Vector3(0, 1, -10); // 원하는 위치로 설정
            playerCamera.transform.localRotation = Quaternion.identity;
        }
    }
}
