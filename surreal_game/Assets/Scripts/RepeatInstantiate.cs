using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class RepeatInstantiate : MonoBehaviour
    {
        public int RepeatCount = 0;
        public float GapSize = 1f;
        public GameObject Template;
        public Transform InstanceParent;
        public Axis AxisToRepeatOn;
        public EventTrigger.TriggerEvent CallBack;

        public enum Axis
        {
            X, Y, Z
        }

        void Start()
        {
            for (var i = 1; i < RepeatCount; i++)
            {
                var clone = Instantiate(Template);
                clone.transform.SetParent(InstanceParent, false); 

                var templatePosition = Template.transform.localPosition;
                Tweak(i, clone, templatePosition);
            }

            CallBack.Invoke(null);
        }

        private void Tweak(int i, GameObject clone, Vector3 templatePos)
        {
            switch (AxisToRepeatOn)
            {
                case Axis.X:
                    clone.transform.localPosition = new Vector3(templatePos.x + (GapSize * i), templatePos.y, templatePos.z);
                    break;
                case Axis.Y:
                    clone.transform.localPosition = new Vector3(templatePos.x, templatePos.y + (GapSize * i), templatePos.z);
                    break;
                case Axis.Z:
                    clone.transform.localPosition = new Vector3(templatePos.x, templatePos.y, templatePos.z + (GapSize * i));
                    break;
            }
        }
    }
}
