using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    Object[] myMusic;
    AudioSource audio;
    int interval;
    float timer;

    void Awake()
    {

        myMusic = Resources.LoadAll("Dan's Music", typeof(AudioClip));
        audio = this.GetComponent<AudioSource>();
        audio.clip = myMusic[Random.Range(0, myMusic.Length - 1)] as AudioClip;
        interval = Random.Range(1, 6);
    }

    // Start is called before the first frame update
    void Start()
    {
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (!audio.isPlaying && timer > interval)
        {
            playRandomMusic();
            timer = 0;
        }
    }

    void playRandomMusic()
    {
        audio.clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        audio.Play();
    }
}
