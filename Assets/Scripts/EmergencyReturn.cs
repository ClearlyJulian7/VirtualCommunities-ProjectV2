using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmergencyReturn : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("MainHub");
        }

        else if (Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }
}
