using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool B1;
    public bool B2;
    public bool B3;
    public bool B4;
    public bool B5;
    public bool B6;
    public bool Player;
    public bool IsIn1;
    public bool IsIn2;
    public bool IsIn3;
    public bool IsIn4;
    public bool IsIn5;
    public bool IsIn6;
    public bool ispressed;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsIn1 == true && Input.GetKeyDown(KeyCode.E) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button1) == false)
        {
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button1) = true;
            anim.Play("Leverswitch");
            return;

        }
        if (IsIn1 == true && Input.GetKeyDown(KeyCode.E)&& (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button1) == true )
        {

            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button1) = false;
            anim.Play("LeverUp");
            return;
        }

        if (IsIn2 == true && Input.GetKeyDown(KeyCode.E) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button2) == false)
        {
            anim.Play("Leverswitch");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button2) = true;
            return;

        }
        if (IsIn2 == true && Input.GetKeyDown(KeyCode.E) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button2) == true)
        {
            anim.Play("LeverUp");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button2) = false;
            return;
        }

        if (IsIn3 == true && Input.GetKeyDown(KeyCode.E) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button3) == false)
        {
            anim.Play("Leverswitch");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button3) = true;
            return;

        }
        if (IsIn3 == true && Input.GetKeyDown(KeyCode.E) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button3) == true)
        {
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button3) = false;
            anim.Play("LeverUp");
            return;
        }

        if (IsIn4 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button4) == false)
        {
            anim.Play("Leverswitch");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button4) = true;
            return;

        }
        if (IsIn4 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button4) == true)
        {
            anim.Play("LeverUp");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button4) = false;
            return;
        }

        if (IsIn5 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button5) == false)
        {
            anim.Play("Leverswitch");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button5) = true;
            return;

        }
        if (IsIn5 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button5) == true)
        {
            anim.Play("LeverUp");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button5) = false;
            return;
        }

        if (IsIn6 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button6) == false)
        {
            anim.Play("Leverswitch");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button6) = true;
            return;

        }
        if (IsIn6 == true && Input.GetKeyDown(KeyCode.Keypad0) && (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button6) == true)
        {
            anim.Play("LeverUp");
            (GameObject.Find("MainCamera").GetComponent<ComboCode>().Button6) = false;
            return;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player == true)
        {
                if (B1 == true)
                {

                  IsIn1 = true;
                }
            if (B2 == true)
            {

                IsIn2 = true;
            }
            if (B3 == true)
            {

                IsIn3 = true;
            }

        }
        if (Player == false)
        {
            if (B4 == true)
            {

                IsIn4 = true;
            }
            if (B5 == true)
            {

                IsIn5 = true;
            }
            if (B6 == true)
            {

                IsIn6 = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Player == true)
        {
            if (B1 == true)
            {

                IsIn1 = false;
            }
            if (B2 == true)
            {

                IsIn2 = false;
            }
            if (B3 == true)
            {

                IsIn3 = false;
            }

        }
        if (Player == false)
        {
            if (B4 == true)
            {

                IsIn4 = false;
            }
            if (B5 == true)
            {

                IsIn5 = false;
            }
            if (B6 == true)
            {

                IsIn6 = false;
            }
        }
    }
}
