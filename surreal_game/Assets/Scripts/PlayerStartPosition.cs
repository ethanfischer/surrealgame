using System.Collections;
using System.Collections.Generic;
using SurrealGame;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour {
	void Start ()
	{
	    Player.Instance.SetPosition(transform.position);
	}
}
