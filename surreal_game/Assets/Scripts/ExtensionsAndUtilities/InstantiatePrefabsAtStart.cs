using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ExtensionsAndUtilities
{
    public class InstantiatePrefabsAtStart : MonoBehaviour
    {
        public List<GameObject> Prefabs;

        void Start()
        {
            foreach (GameObject prefab in Prefabs)
            {
                Instantiate(prefab);
            }
        }
    }
}
