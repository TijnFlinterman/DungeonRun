using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject Lever;
    // Start is called before the first frame update
    void Start()
    {
        Lever.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Lever.SetActive(true);
        }
    }
}
