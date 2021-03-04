using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MyButton : MonoBehaviour
{
    // A Condition 4

    public GameObject buttonOne;

    public bool buttonPressedState = false;

    void Start()
    {
        
    }


    public void ButtonPressed()
    {

        if (buttonOne == true)
        {
            buttonPressedState = true;
            Debug.Log("Button wurde gedrückt");
      
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
