using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCode : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Button1;
    public bool Button2;
    public bool Button3;
    public bool Button4;
    public bool Button5;
    public bool Button6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Button1 == true && Button5 == true && Button3 == true)
        {
            Destroy(GameObject.FindWithTag("ComboDoor"));
        }
    }
}
