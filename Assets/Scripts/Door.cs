using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool door0;
    public bool door1;
    public bool door2;
    public bool door3;
    public bool door4;
    // Start is called before the first frame update
    void Start()
    {
     door0 = false;
     door1 = false;
     door2 = false;
}

    // Update is called once per frame
    void Update()
    {
        if (door0 == true)
        {
            Destroy(GameObject.FindWithTag("door0"));
        }
        if (door1 == true)
        {
            Destroy(GameObject.FindWithTag("Door1"));
        }
        if (door2 == true)
        {
            Destroy(GameObject.FindWithTag("Door2"));
        }
        if (door3 == true)
        {
            Destroy(GameObject.FindWithTag("Door3"));
        }
        if (door4 == true)
        {
            Destroy(GameObject.FindWithTag("Door4"));
        }
    }
}
