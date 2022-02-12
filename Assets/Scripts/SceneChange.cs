using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int whoScene = 0;
    int notThisScene;
    public void Start()
    {
        whoScene = Random.Range(1, 5);
        Debug.Log(whoScene);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByBuildIndex(whoScene))) {
            whoScene = Random.Range(1, 5);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!this.tag.Equals("backToHub") && other.tag.Equals("Player"))
        {
            SceneManager.LoadScene(whoScene);
        }
        else if (other.tag.Equals("Player"))
        {
            SceneManager.LoadScene(0);
        }
    }
}