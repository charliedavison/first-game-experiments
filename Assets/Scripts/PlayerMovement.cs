using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 1;

    [SerializeField]
    private Vector3 force;

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        GetComponent<Rigidbody>().velocity += new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed;
    }
}
