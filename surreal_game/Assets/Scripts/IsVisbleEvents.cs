using Assets.Scripts.ExtensionsAndUtilities;
using UnityEngine;

namespace Assets.Scripts
{
    public class IsVisbleEvents : MonoBehaviour
    {
        public event VisibilityChangedEvent VisibilityChangedEvent; 
        public bool IsVisible { get; set; }
        private Renderer _renderer;

        // Use this for initialization
        void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        // Update is called once per frame
        void Update()
        {
            var isVisible = _renderer.IsVisibleFrom(Camera.main);
            if (isVisible != IsVisible)
            {
                VisibilityChangedEvent?.Invoke(this, new VisibilityChangedEventArgs(isVisible));
                IsVisible = isVisible;
                Debug.Log("Visibility changed to" + IsVisible);
            }
        }
    }

    public delegate void VisibilityChangedEvent(object sender, VisibilityChangedEventArgs args);

    public class VisibilityChangedEventArgs
    {
        public bool IsVisible;

        public VisibilityChangedEventArgs(bool isVisible)
        {
            IsVisible = isVisible;
        }
    }
}
