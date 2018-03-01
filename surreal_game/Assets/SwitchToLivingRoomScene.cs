using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SurrealGame
{
    public class SwitchToLivingRoomScene : SwitchSceneOnClick
    {
        protected override bool CanSwitchScene()
        {
            return true;
        }
    }
}
