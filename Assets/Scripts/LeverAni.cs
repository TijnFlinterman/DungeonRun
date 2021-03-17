using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAni : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if ((coll.gameObject.tag == "Player") || (coll.gameObject.tag == "Player2"))
        {
            ani.Play("Buttons");
        }
    }
}
