using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float jumpSpeed = 800f;
    public bool isGrounded;
    public Animator animator;
    public GameObject TrapDoor1;
    public GameObject TrapDoor2;
    public GameObject Trigger2;
    public GameObject Door5;
    public GameObject EndLever;
    public GameObject EndDoor1;
    public GameObject EndDoor2;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
            animator.SetBool("WalkL", true);
        }
        else
        {
            animator.SetBool("WalkL", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
            animator.SetBool("WalkR", true);
        }
        else
        {
            animator.SetBool("WalkR", false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed);
            isGrounded = false;
            
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "lever0")
        {
            
            
                
                    (GameObject.Find("MainCamera").GetComponent<Door>().door0) = true;
                
            
        }
        if (coll.gameObject.tag == "lever2")
        {



            (GameObject.Find("MainCamera").GetComponent<Door>().door2) = true;


        }
        if (coll.gameObject.tag == "Lever3")
        {



            (GameObject.Find("MainCamera").GetComponent<Door>().door3) = true;


        }
        if (coll.gameObject.tag == "TriggerMove")
        {



            (GameObject.Find("MainCamera").GetComponent<CameraMovement>().Player1) = true;


        }
        if (coll.gameObject.tag == "TriggerTrap1")
        {



           TrapDoor1.SetActive(true);


        }
        if (coll.gameObject.tag == "TriggerTrap2")
        {


            EndLever.SetActive(true);
            TrapDoor2.SetActive(true);
           Trigger2.SetActive(false);

        }
        if (coll.gameObject.tag == "Lever5")
        {



            Door5.SetActive(false);


        }
        if (coll.gameObject.tag == "Lever6")
        {



            EndDoor1.SetActive(false);
            EndDoor2.SetActive(false);


        }
    }
}
