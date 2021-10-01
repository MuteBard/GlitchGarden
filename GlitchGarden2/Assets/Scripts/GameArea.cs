using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameArea : MonoBehaviour
{
    // [SerializeField] GameObject defender;
    [SerializeField] GameObject parentContainer;
    [SerializeField] int bankTotal = 100;
    int currentCost = 1000000;
    MouseFunctionality mouse;

    void Start(){
        mouse = gameObject.GetComponent<MouseFunctionality>();
    }

    private void OnMouseDown(){
        spawnDefender();
    }

    private void spawnDefender(){
        Vector2 mousePosition = mouse.GetGridPosition2D();
        var newDefender = getDefender();
        if(allowTransaction()){
            Instantiate(newDefender, mousePosition, transform.rotation, parentContainer.transform);
        }
    }

    private void getCostFromButton(Button button){
       var stats = button.GetComponent<Stats>();
       int cost = stats.GetCost();
       currentCost = cost;
    }

    private void setBankTotal(int total){
       bankTotal = total;
    }

    private bool allowTransaction(){
        int result = bankTotal - currentCost;
        if(result >= 0){
            setBankTotal(result);
            return true;
        }else {
            return false;
        } 
    }

    private GameObject getDefender(){
        GameObject defender;
        var buttons = FindObjectsOfType<Button>();
        foreach(Button button in buttons){
            defender = button.getActiveDefender();
            if(defender){
                getCostFromButton(button);
                return defender;
            }
        }
        return null;
    }
}

//https://forum.unity.com/threads/cannot-instantiate-objects-with-a-parent-which-is-persistent.619912/
// Another update: just now I figured out I was asigning the prefabs, and not the objects in the scene, as parents. Of course it didn't work. Solved.