using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource Music;

    public bool startPlayingMusic;

    public BeatScroller theBS;
    public BeatScrollerBattleSystem theBsBs;

    public static GameManager instance;

    public int speedPerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;


    //To figure out what note we got
    public bool perfectHit = false;
    public bool normalHit = false;
    public bool goodHit = false;
    public bool noHit = false;

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
        perfectHit = false;
        goodHit = false;
        NoteHit();
        Debug.Log("Normal Hit");
        
    }
    public void GoodHit()
    {

        goodHit = true;
        perfectHit = false;
        normalHit = false;
        NoteHit();
        Debug.Log("Good Hit");
        
    }

    public void PerfectHit()
    {
        perfectHit = true;
        normalHit = false;
        goodHit = false;
        NoteHit();
        Debug.Log("Perfect Hit");
        
    }
    public void NoteHit()
    {
        //Debug.Log("Hit");
    }
   public void NoteMiss()
    {
        noHit = true;
        return;
        //Debug.Log("Missed");
    }
   
}
