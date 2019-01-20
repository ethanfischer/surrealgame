using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Extensions
{
    public static class GameObjectExtensions
    {
        public static void ComplainIfNull(this GameObject gameObject)
        {
            if (gameObject == null)
            {
                Debug.LogError("GameObject not assigned in editor:" + gameObject.name);
            }
        }
    }
}
