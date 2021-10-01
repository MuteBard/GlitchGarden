using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Color originalColor;
    bool active = false;
    [SerializeField] GameObject defender;

    void Start(){
        originalColor = GetComponent<SpriteRenderer>().color;
    }
    private void OnMouseDown(){
        resetColors();
        setColor(Color.white);
        setActive();
    }
    private Color getOriginalColor(){
        return originalColor;
    }
    private void setColor(Color color){
        GetComponent<SpriteRenderer>().color = color;
    }
    private void setColor(Color color, Button button){
        button.GetComponent<SpriteRenderer>().color = color;
    }
    private void setActive(){
        active = true;
    }
    private void setInactive(){
        active = false;
    }
    private bool isActive(){
        return active;
    }
    private GameObject getDefender(){
        return defender;
    }
    private void resetColors(){
        var buttons = FindObjectsOfType<Button>();
        foreach(Button button in buttons){
            button.setColor(getOriginalColor());
            button.setInactive();
        }
    }
    public GameObject getActiveDefender(){
        if(isActive()){
            return getDefender();
        }
        return null;
    }
}
