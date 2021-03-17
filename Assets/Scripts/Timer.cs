using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   static public float Counter;
    public Text textbox;
    public Text TextBox2;
    public bool CanCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Time " + Counter;
        TextBox2.text = "Time " + Counter;
        if (CanCount == true)
        {
            Counter += Time.deltaTime;
        }
    
    }
}
