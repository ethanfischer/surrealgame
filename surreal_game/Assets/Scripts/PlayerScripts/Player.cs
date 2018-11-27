using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private static Player _instance = null;
    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<Player>();
            }

            return _instance;
        }
    }

	public void SetPosition (Vector3 v)
	{
		this.transform.position = v;
	}
}
