using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField]
    float xOffset = 0;
    [SerializeField]
    float yOffset = 0;
    [SerializeField]
    float zOffset = 0;

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");

        // Current player position
        Vector3 playerPosition = player.transform.position;

        // Calculate new camera position
        Vector3 cameraPosition = new Vector3(playerPosition.x + xOffset, playerPosition.y + yOffset, playerPosition.z + zOffset);

        // Set new position on camera
        gameObject.transform.position = cameraPosition;
    }
}
