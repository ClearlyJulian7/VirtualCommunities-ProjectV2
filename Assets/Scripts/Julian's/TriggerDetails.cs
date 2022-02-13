using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetails : MonoBehaviour
{
    public GameObject Artinfo;
    public GameObject ArtinfoQ;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Artinfo.SetActive(true);
            ArtinfoQ.SetActive(false);
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Artinfo.SetActive(false);
            ArtinfoQ.SetActive(true);
        }

    }
}
