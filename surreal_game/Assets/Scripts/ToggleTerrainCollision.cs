using System.Collections;
using System.Collections.Generic;
using SurrealGame;
using UnityEngine;

public class ToggleTerrainCollision : MonoBehaviour
{
    private LayerMask PlayerLayer; 
    private LayerMask TerrainLayer; 

    void Start()
    {
        SetInitialReferences();
    }

    private void SetInitialReferences()
    {
        PlayerLayer = LayerMask.NameToLayer("Ignore Raycast");
        TerrainLayer  = LayerMask.NameToLayer("Terrain");
    }

    void OnTriggerEnter()
    {
        Physics.IgnoreLayerCollision(PlayerLayer, TerrainLayer, true);
    }

    void OnTriggerExit()
    {
        Physics.IgnoreLayerCollision(PlayerLayer, TerrainLayer, false);
    }
}
