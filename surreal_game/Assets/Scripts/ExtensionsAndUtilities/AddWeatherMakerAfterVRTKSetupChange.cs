using System.Collections.Generic;
using UnityEngine;
using VRTK;

namespace Assets.Scripts.ExtensionsAndUtilities
{
    public class AddWeatherMakerAfterVRTKSetupChange : MonoBehaviour
    {
        public GameObject WeatherMakerPrefab;

        void Awake()
        {
            VRTK_SDKManager.AttemptAddBehaviourToToggleOnLoadedSetupChange(this);
        }

        void OnEnable()
        {
            Instantiate(WeatherMakerPrefab);
        }
    }
}
