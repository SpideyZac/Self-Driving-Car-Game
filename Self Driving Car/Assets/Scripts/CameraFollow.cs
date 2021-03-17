using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerPos;

    private void Awake() {
        playerPos = GameObject.Find("Car").GetComponent<Transform>();
    }

    private void Update() {
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, -10);
    }
}
