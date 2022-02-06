using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int whoScene = 0;
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(whoScene);
    }
}
