using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Color originalColor;

    void Start(){
        originalColor = GetComponent<SpriteRenderer>().color;
    }
    private void OnMouseDown(){
        var buttons = FindObjectsOfType<Button>();
        foreach(Button button in buttons){
            setColor(getOriginalColor(), button);
        }
        setColor(Color.white);
    }
    private Color getOriginalColor(){
        return originalColor;
    }
    private Color getColor(){
        return GetComponent<SpriteRenderer>().color;
    }
    private void setColor(Color color){
        GetComponent<SpriteRenderer>().color = color;
    }

    private void setColor(Color color, Button button){
        button.GetComponent<SpriteRenderer>().color = color;
    }
}
