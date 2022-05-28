using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keytoPress;
    public KeyCode secondkeytoPress;
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keytoPress) || Input.GetKeyDown(secondkeytoPress))
        {
            theSR.sprite = pressedImage;
        }
        if(Input.GetKeyUp(keytoPress) || Input.GetKeyDown(secondkeytoPress))
        {
            theSR.sprite = defaultImage;
        }
    }
}
