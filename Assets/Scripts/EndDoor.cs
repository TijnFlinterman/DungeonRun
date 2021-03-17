using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        
            if (coll.gameObject.tag == "Player")
            {
                anim.Play("Door");
            GameObject.Find("MainCamera").GetComponent<EndSwitch>().Player1_IsIn = true;
            }
            if (coll.gameObject.tag == "Player2")
            {
            anim.Play("Door");
            GameObject.Find("MainCamera").GetComponent<EndSwitch>().Player2_IsIn = true;
        }

    }
     void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            anim.Play("DoorIdle");
            GameObject.Find("MainCamera").GetComponent<EndSwitch>().Player1_IsIn = false;
        }
        if (coll.gameObject.tag == "Player2")
        {
            anim.Play("DoorIdle");
            GameObject.Find("MainCamera").GetComponent<EndSwitch>().Player2_IsIn = false;
        }
    }
}
