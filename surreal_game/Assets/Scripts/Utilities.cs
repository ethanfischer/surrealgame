using UnityEngine;

namespace SurrealGame
{
    public static class Utilities
    {
        public static string ClickButton = "Interact";

        public static bool WasObjectClicked(GameObject gameObject)
        {
            if (Input.GetButtonDown(ClickButton))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == gameObject.name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
