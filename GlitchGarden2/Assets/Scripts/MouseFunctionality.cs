using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFunctionality : MonoBehaviour
{
    public float GetX(){
        return Input.mousePosition.x; 
    }

    public float GetY(){ 
        return Input.mousePosition.y;
    }

    public Vector2 GetMousePosition2D(){
        Vector2 mousePosition = new Vector2(GetX(), GetY());
        return mousePosition;
    }
    
    public Vector3 GetMousePosition3D(){
        Vector3 mousePosition = new Vector3(GetX(), GetY(), 0);
        return mousePosition;
    }

    public Vector2 GetMouseWorldPosition2D(){
        Vector2 worldmMousePosition = Camera.main.ScreenToWorldPoint(GetMousePosition2D());
        return worldmMousePosition;
    }

    public Vector3 GetMouseWorldPosition3D(){
        Vector3 worldmMousePosition = Camera.main.ScreenToWorldPoint(GetMousePosition3D());
        return worldmMousePosition;
    }

   
}

// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Input.html
