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
        whoScene = Random.Range(1, SceneManager.sceneCount);
        if (SceneManager.GetSceneByBuildIndex(whoScene).name == SceneManager.GetActiveScene().name) {
            notThisScene = whoScene;
        }
        while (whoScene == notThisScene) {
            whoScene = Random.Range(1, SceneManager.sceneCount);
        }
        Debug.Log(whoScene);
    }

    public void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (!this.tag.Equals("backToHub"))
        {
            SceneManager.LoadScene(whoScene);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}