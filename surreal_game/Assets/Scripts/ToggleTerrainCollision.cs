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
        //if(PlayerCollider == null) Debug.LogError("player collider is null");
        //if(TerrainCollider == null) Debug.LogError("terrain collider is null");
    }

    void OnTriggerEnter()
    {
        Physics.IgnoreLayerCollision(PlayerLayer, TerrainLayer, true);
        Debug.Log("Disable player terrain collisions");
    }

    void OnTriggerExit()
    {
        Physics.IgnoreLayerCollision(PlayerLayer, TerrainLayer, false);
        Debug.Log("Enable player terrain collisions");
    }
}
