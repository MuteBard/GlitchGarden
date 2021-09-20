using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameArea : MonoBehaviour
{
    [SerializeField] GameObject defender;
    [SerializeField] GameObject parentContainer;
    MouseFunctionality mouse;

    void Start(){
        mouse = gameObject.GetComponent<MouseFunctionality>();
    }

    private void OnMouseDown(){
        spawnDefender();
    }

    private void spawnDefender(){
        Vector2 mousePosition = mouse.GetMouseWorldPosition2D();
        Instantiate(defender, mousePosition, transform.rotation, parentContainer.transform);
    }
}

//https://forum.unity.com/threads/cannot-instantiate-objects-with-a-parent-which-is-persistent.619912/
// Another update: just now I figured out I was asigning the prefabs, and not the objects in the scene, as parents. Of course it didn't work. Solved.