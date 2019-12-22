using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWinCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.gameObject.name == "WinHole") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
