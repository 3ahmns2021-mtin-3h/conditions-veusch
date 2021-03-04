using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiMovement : MonoBehaviour
{
    // D Condition 5
    private Vector3 mOffset;
    private float mZCoord;
    public GameObject circle;
    public bool mouseMovementState = false;
    

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        circle.SetActive(true);
        if(circle==true)
        {
            Debug.Log("Circle wird bewegt");
            mouseMovementState = true;
        }
    }
     private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    
    }

    void OnMouseDrag()
    {

        transform.position = GetMouseWorldPos() + mOffset;

    }
    
}
