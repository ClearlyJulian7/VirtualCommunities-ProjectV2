using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toscene : MonoBehaviour
{
    public void movetoScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}

