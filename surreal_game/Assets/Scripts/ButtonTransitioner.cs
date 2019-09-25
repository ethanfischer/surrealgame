using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SurrealGame
{
    public class ButtonTransitioner : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        public Color32 NormalColor = Color.white;
        public Color32 HoverColor = Color.red;
        public Color32 DownColor = Color.gray;
        public UnityEvent PointerDown;
        public UnityEvent PointerEnter;
        public UnityEvent PointerExit;

        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _image.color = DownColor;
            PointerDown.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _image.color = HoverColor;
            PointerEnter.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _image.color = NormalColor;
            PointerExit.Invoke();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _image.color = HoverColor;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            throw new NotImplementedException();
        }
    }
}
