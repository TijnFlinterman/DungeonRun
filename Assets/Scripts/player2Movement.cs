using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float jumpSpeed = 800f;
    public bool isGrounded;
    public Animator animator;
    public GameObject Door2;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
            animator.SetBool("WalkL", true);
        }
        else
        {
            animator.SetBool("WalkL", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
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
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
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
        if (coll.gameObject.tag == "lever1")
        {



            (GameObject.Find("MainCamera").GetComponent<Door>().door1) = true;


        }
        if (coll.gameObject.tag == "Lever4")
        {



            (GameObject.Find("MainCamera").GetComponent<Door>().door4) = true;


        }
        if (coll.gameObject.tag == "TriggerMove")
        {



            (GameObject.Find("MainCamera").GetComponent<CameraMovement>().Player2) = true;


        }
        if (coll.gameObject.tag == "Lever5")
        {



            Door2.SetActive(false);


        }
    }
}

