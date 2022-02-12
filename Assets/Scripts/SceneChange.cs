using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int whoScene = 0;
    void OnTriggerEnter(Collider other)
    {
        if (!this.tag.Equals("backToHub"))
        {
            SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCount));
        }
        else
        {
            SceneManager.LoadScene(whoScene);
        }
    }
}