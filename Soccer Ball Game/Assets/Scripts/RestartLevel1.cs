using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController component = other.gameObject.GetComponent<PlayerController>();
        if (component != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

        }
    }
}
