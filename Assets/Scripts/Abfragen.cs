using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abfragen : MonoBehaviour
{

    public MyButton mb;
    public KeyboardInput keyInput;
    public KeyboardInput2 keyInput2;
    public UiMovement uiMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
     if (mb.buttonPressedState&& keyInput.keyboardInputState)
        {
            Debug.Log("*** A&&B == true");
            mb.buttonPressedState = false;
            keyInput.keyboardInputState = false;
        }

     if(keyInput.keyboardInputState&&keyInput2.keyboardInput2State)
        {
            Debug.Log("*** B&&C == true");

            keyInput.keyboardInputState = false;
            keyInput2.keyboardInput2State = false;

        }

     if(keyInput2.keyboardInput2State&&uiMove.mouseMovementState)
        {
            Debug.Log("*** C&&D == true");
            keyInput2.keyboardInput2State = false;
            uiMove.mouseMovementState = false;
        }
    }

    
}
