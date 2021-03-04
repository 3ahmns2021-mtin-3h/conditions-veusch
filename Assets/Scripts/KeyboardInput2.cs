using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput2 : MonoBehaviour
{
    // C Condition 2 gewählt

    private bool onePressed = false;
    private bool twoPressed = false;
    private bool threePressed = false;
    private bool fourPressed = false;
    public bool keyboardInput2State  = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown) {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                onePressed = true;
                Debug.Log("Taste 1 wurde gedrückt");
            }

            else if (Input.GetKeyDown(KeyCode.Keypad2) && onePressed)
            {
                twoPressed = true;
                Debug.Log("Taste 2 wurde gedrückt");
            }

            else if (Input.GetKeyDown(KeyCode.Keypad3) && twoPressed)
            {
                threePressed = true;
                Debug.Log("Taste 3 wurde gedrückt");
            }

            else if (Input.GetKeyDown(KeyCode.Keypad4) && threePressed)
            {

                fourPressed = true;
                Debug.Log("Taste 4 wurde gedrückt");
            }

            else
            {
                Debug.Log("Wrong key pressed, Reset");
                onePressed = false;
                twoPressed = false;
                threePressed = false;
                fourPressed = false;
            }

            if (onePressed && twoPressed && threePressed && fourPressed)
            {
                Debug.Log("All 4 Keys(1,2,3,4) pressed in correct order");
                onePressed = false;
                twoPressed = false;
                threePressed = false;
                fourPressed = false;
                keyboardInput2State  = true;
            }
        }
    }
}
