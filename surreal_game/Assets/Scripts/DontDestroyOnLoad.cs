using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class  DontDestroyOnLoad : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
        }

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
			
        }

        private void SetInitialReferences()
        {
        }
    }
}
