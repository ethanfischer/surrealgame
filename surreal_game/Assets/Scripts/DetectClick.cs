using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClick : MonoBehaviour
{

    public string ClickButton = "Interact";

    public bool WasClicked()
    {
        if (Input.GetButtonDown(ClickButton))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == this.name)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
