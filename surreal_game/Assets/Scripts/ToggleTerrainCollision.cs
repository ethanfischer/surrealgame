using System.Collections;
using System.Collections.Generic;
using SurrealGame;
using UnityEngine;

public class ToggleTerrainCollision : MonoBehaviour
{
    public TerrainCollider TerrainCollider;
    public Collider PlayerCollider;

    void Start()
    {
        SetInitialReferences();
    }

    private void SetInitialReferences()
    {
        //if(PlayerCollider == null) Debug.LogError("player collider is null");
        //if(TerrainCollider == null) Debug.LogError("terrain collider is null");
    }

    void OnTriggerEnter()
    {
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Terrain"), true);
    }

    void OnTriggerExit()
    {
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Terrain"), false);
    }
}
