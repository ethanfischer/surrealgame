using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SurrealGame
{
    public class CustomStandAloneInput : PointerInputModule
    {
        public Camera Camera;
        private PointerEventData _pointerEventData;

        [SerializeField]
        private GameObject _currentGameObject; 

        //private float InteractInputAxis;

        void Start()
        {
            //InteractInputAxis = Input.GetAxis(InputAxes.INTERACT);
        }

        protected override void Awake()
        {
            base.Awake();
            _pointerEventData = new PointerEventData(eventSystem);
        }

        public override void Process()
        {
            ResetPointerDataAndSetCamera();
            Raycast();
            ClearRaycastCache();
            HandlePointerExitAndEnter(_pointerEventData, _currentGameObject);
            DetectPressAndRelease();
        }

        private void DetectPressAndRelease()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ProcessPress();
            }
            if (Input.GetMouseButtonUp(0))
            {
                ProcessRelease();
            }
        }

        private void ClearRaycastCache()
        {
            m_RaycastResultCache.Clear();
        }

        private void ResetPointerDataAndSetCamera()
        {
            _pointerEventData.Reset();
            _pointerEventData.position = new Vector2(Camera.pixelWidth / 2, Camera.pixelHeight / 2);
        }

        private void Raycast()
        {
            eventSystem.RaycastAll(_pointerEventData, m_RaycastResultCache);
            _pointerEventData.pointerCurrentRaycast = FindFirstRaycast(m_RaycastResultCache);
            _currentGameObject = _pointerEventData.pointerCurrentRaycast.gameObject;
        }

        private void ProcessPress()
        {
        }

        private void ProcessRelease()
        {
        }

        //void Update()
        //{
        //    Debug.Log("InteractInputAxis value" + InteractInputAxis);
        //}
    }
}
