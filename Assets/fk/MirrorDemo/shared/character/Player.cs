using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    private float _playerSpeed = 0.01F;
    private Camera playerCamera = null;

    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveX * _playerSpeed, 0, moveZ * _playerSpeed);
            transform.position = transform.position + movement;

            playerCamera.GetComponent<Camera>();
            playerCamera.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        HandleMovement();
    }
}
