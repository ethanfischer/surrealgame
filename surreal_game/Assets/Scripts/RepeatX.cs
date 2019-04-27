using UnityEngine;

namespace Assets.Scripts
{
    public class RepeatX : MonoBehaviour
    {
        public int RepeatCount = 0;
        public float GapSize = 1f;
        void Start()
        {
            for (var i = 0; i < RepeatCount; i++)
            {
                var clone = GameObject.Instantiate(this.gameObject);
                var pos = clone.transform.localPosition;
                clone.transform.localPosition = new Vector3(pos.x + (GapSize * i), pos.y, pos.z);
            }
        }
    }
}
