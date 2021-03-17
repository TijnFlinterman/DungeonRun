using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkmark : MonoBehaviour
{
    public SpriteRenderer LockSprite;

    void Start()
    {
        LockSprite.enabled = false;
    }

    void Update()
    {
        if (GameObject.FindWithTag("readybutton").GetComponent<MainMenu2>().ready == true)
        {
            LockSprite.enabled = true;
        }
        else
        {
            LockSprite.enabled = false;
        }
    }
}
