using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class ControllerGrabbable
    {
        private object _controllerGrabbable;
        public void CreateControllerGrabbablePrefab()
        {
            _controllerGrabbable = Resources.Load("ControllerGrabable");


        }

    }
}
