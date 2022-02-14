using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetails : MonoBehaviour
{
    public GameObject Artinfo;
    public GameObject ArtinfoQ;

    public AudioSource flip;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Artinfo.SetActive(true);
            ArtinfoQ.SetActive(false);
            flip.Play();
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
