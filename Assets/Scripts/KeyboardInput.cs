using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    // B Condition 3
    public bool keyboardInputState = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private bool onePressed = false;
    private bool twoPressed = false;
    private bool threePressed = false;
    private bool fourPressed = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            onePressed = true;
            Debug.Log("Taste 1 wurde gedrückt");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            twoPressed = true;
            Debug.Log("Taste 2 wurde gedrückt");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            threePressed = true;
            Debug.Log("Taste 3 wurde gedrückt");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            fourPressed = true;
            Debug.Log("Taste 4 wurde gedrückt");
        }

        if (onePressed && twoPressed && threePressed && fourPressed)
        {
            Debug.Log("All 4 keys pressed");
            onePressed = false;
            twoPressed = false;
            threePressed = false;
            fourPressed = false;
            keyboardInputState = true;

        }
    }
}
