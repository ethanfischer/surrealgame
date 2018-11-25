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

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void SetInitialReferences ()
	{
		
	}

	public void SetPosition (Vector3 v)
	{
		this.transform.position = v;
	}
}
