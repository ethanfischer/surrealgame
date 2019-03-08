using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.PlayerScripts;
using SurrealGame;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main?.transform);
    }
}
