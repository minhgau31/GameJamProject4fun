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


    //To figure out what note we got
    public bool perfectHit;
    public bool normalHit;
    public bool goodHit;
    public bool noHit;

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

        normalHit = true;
        NoteHit();
        Debug.Log("Normal Hit");
        return;
    }
    public void GoodHit()
    {

        goodHit = true;
        NoteHit();
        Debug.Log("Good Hit");
        return;
    }

    public void PerfectHit()
    {
        perfectHit = true;
        NoteHit();
        Debug.Log("Perfect Hit");
        return;
    }
    public void NoteHit()
    {
        Debug.Log("Hit");
    }
   public void NoteMiss()
    {
        noHit = true;
        return;
        //Debug.Log("Missed");
    }
   
}
