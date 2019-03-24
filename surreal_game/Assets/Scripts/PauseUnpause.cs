using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class PauseUnpause : MonoBehaviour
    {
        void Start()
        {
            Time.timeScale = 0;
            Time.timeScale = 1;
        }
    }
}
