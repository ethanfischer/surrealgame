using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughTerrainOnEnter : MonoBehaviour
{
    public Terrain Terrain;
    void OnTriggerEnter()
    {
        Debug.Log("sdfhsdfh");
        Terrain.gameObject.SetActive(false);
    }
}
