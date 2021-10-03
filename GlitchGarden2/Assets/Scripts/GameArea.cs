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
        SpawnDefender();
    }

    private void SpawnDefender(){
        Vector2 mousePosition = mouse.GetGridPosition2D();
        var newDefender = getDefender();
        if(AllowTransaction()){
            Instantiate(newDefender, mousePosition, transform.rotation, parentContainer.transform);
        }
    }

    private void GetCostFromButton(Button button){
       var stats = button.GetComponent<Stats>();
       int cost = stats.GetCost();
       currentCost = cost;
    }

    private void SetBankTotal(int total){
       bankTotal = total;
    }

    public string GetText(){
       return bankTotal.ToString();
    }

    private bool AllowTransaction(){
        int result = bankTotal - currentCost;
        if(result >= 0){
            SetBankTotal(result);
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
                GetCostFromButton(button);
                return defender;
            }
        }
        return null;
    }
}

//https://forum.unity.com/threads/cannot-instantiate-objects-with-a-parent-which-is-persistent.619912/
// Another update: just now I figured out I was asigning the prefabs, and not the objects in the scene, as parents. Of course it didn't work. Solved.