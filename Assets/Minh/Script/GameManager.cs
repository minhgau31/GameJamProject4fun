using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource Music;

    public bool startPlayingMusic;

    public BeatScroller theBS;

    public static GameManager instance;

    public int speedPerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlayingMusic)
        {
            if (Input.anyKeyDown)
            {
                startPlayingMusic = true;
                theBS.hasStarted = true;
                Time.timeScale = 1f;
                Music.Play();
            }
        }
    }

    public void NormalHit()
    {
        NoteHit();
        Debug.Log("Normal Hit");
    }
    public void GoodHit()
    {
        NoteHit();
        Debug.Log("Good Hit");
    }

    public void PerfectHit()
    {

        NoteHit();
        Debug.Log("Perfect Hit");
    }
    public void NoteHit()
    {
        Debug.Log("Hit");
    }
   public void NoteMiss()
    {
        //Debug.Log("Missed");
    }
   
}
