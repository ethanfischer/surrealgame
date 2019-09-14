using System;
using UnityEngine;

namespace Assets.Scripts.ProceduralGeneration
{
    public class RepeatInstantiate : MonoBehaviour
    {
        public int RepeatCount = 0;
        public float GapSize = 1f;
        public GameObject Template;
        public Transform InstanceParent;
        public Axis AxisToRepeatOn;

        public enum Axis
        {
            X, Y, Z
        }

        protected void Start()
        {
            for (var i = 1; i < RepeatCount; i++)
            {
                var clone = MakeClone(i);
                Tweak(i, clone);
            }
        }

        protected virtual GameObject MakeClone(int i)
        {
            var clone = Instantiate(Template);
            return clone;
        }

        protected virtual void Tweak(int i, GameObject clone)
        {
            clone.transform.SetParent(InstanceParent, false);

            var templatePos = Template.transform.localPosition;

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
