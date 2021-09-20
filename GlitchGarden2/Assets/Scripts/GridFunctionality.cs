using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridFunctionality : MonoBehaviour
{
    // [SerializeField] float scaledX = 1.48f;
    // [SerializeField] float scaledY = 1.5f;

    // void Start()
    // {
        
    // }

    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0)){
    //         GetTileAtMousePosition();
    //     }
    // }

    // public TileBase GetTileAtMousePosition(){
    //     // var mouse = gameObject.GetComponent<MouseFunctionality>();
    //     var tilemap = gameObject.GetComponent<Tilemap>();

    //     // Vector3Int mousePosition = mouse.GetScaledMousePositionInt(scaledX, scaledY);
    //     // Debug.Log(mousePosition);

    //     // TileBase tile = tilemap.GetTile(mousePosition);
    //     // Debug.Log(tile);

    //     // Vector3Int mousePosition = new Vector3Int(0,0,0);
    //     Vector3Int mousePosition = new Vector3Int(10,0,0);
    //     Tile tile = tilemap.GetTile<Tile>(mousePosition);
        
    
    //     Debug.Log(tile.transform);


    //     return tile;
    // }

    //     public TileBase GetTileAtMousePosition(){

    //     var mouse = gameObject.GetComponent<MouseFunctionality>();

    //     var tilemapCollider2D = gameObject.GetComponent<TilemapCollider2D>();
    //     var tilemap = gameObject.GetComponent<Tilemap>();
    //     var grid = tilemapCollider2D.transform.parent.GetComponent<Grid>();

    //     // Vector3 tilePosition = grid.GetCellCenterLocal(mouse.GetMousePositionInt());
    //     // Vector3Int tilePositionInt = Vector3Int.CeilToInt(tilePosition);
    //     // // Debug.Log(tilePositionInt);

    //     Vector3Int mousePosition = mouse.GetScaledMousePositionInt(scaledX, scaledY);
    //     Debug.Log(mousePosition);
    //     Debug.Log(grid.GetCellCenterLocal(mouse.GetMousePositionInt()));

    //     TileBase tile = tilemap.GetTile(mousePosition);
    //     Debug.Log(tile);


    //     return tile;
    // }
}
// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Tilemaps.Tilemap.html
// https://answers.unity.com/questions/1637155/how-to-get-tile-instead-of-tilebase-from-tilemap.html
// Tile tile = tilemap.GetTile<Tile>(mousePosition);
// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Transform.html
// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Tilemaps.TilemapCollider2D.html
// https://docs.unity3d.com/2021.2/Documentation/ScriptReference/Grid.html