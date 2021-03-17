using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public bool Go;
    public bool Player1;
    public bool Player2;
    public float MoveSpeed;
    public GameObject Cam;
    public float PlayerOnexPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
     
    {
        PlayerOnexPos = Cam.transform.position.y;
        if (Player1 == true && Player2 == true)
        {
            Go = true;
        }
        if (PlayerOnexPos >= 7.3)
        {
            Go = false;
        }
    }
   void FixedUpdate()
    {
        if (Go == true)
        {
            transform.Translate(0, MoveSpeed, 0);
        }

    }
}
