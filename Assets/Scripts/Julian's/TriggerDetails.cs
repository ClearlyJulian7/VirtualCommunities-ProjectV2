using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetails : MonoBehaviour
{
    public GameObject Artinfo;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Artinfo.SetActive(true);
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Artinfo.SetActive(false);
        }

    }
}
