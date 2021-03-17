using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Transform spawnPosition;
    public float speed, turningSpeed;

    private void Awake() {
        spawnPosition = GameObject.Find("Spawn").GetComponent<Transform>();
    }

    private void Update() {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void FixedUpdate() {
        float rot = Input.GetAxisRaw("Horizontal");
        transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + (-rot * turningSpeed));
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "wall") {
            transform.position = spawnPosition.position;
            transform.rotation = Quaternion.Euler(0, 0, 90);
            Debug.Log("Player Car Died!");
        }
    }
}