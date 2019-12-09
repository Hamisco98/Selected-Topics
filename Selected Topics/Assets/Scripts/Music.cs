using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public AudioClip[] Songs;
    public int currentSong;
    AudioSource audioSource;

    public GameObject musicContainer;

    void Start()
    {
        currentSong = 0;
        audioSource = musicContainer.GetComponent<AudioSource>();

    }

    
    public void StopSongs()
    {
        if (audioSource.isPlaying)
        {
            Debug.Log("here is stop");
            audioSource.clip = Songs[currentSong];
            audioSource.Stop();
        }
    }

    public void changeSong()
    {
        StopSongs();
        if (currentSong >= Songs.Length)
        {
            currentSong = 0;
        }
        else
        currentSong++;
        PlaySongs();
    }

    public void PlaySongs()
    {
        if (!audioSource.isPlaying)
        {
            Debug.Log("here is stop");
            audioSource.clip = Songs[currentSong];
            audioSource.Play();
        }

    }

}
