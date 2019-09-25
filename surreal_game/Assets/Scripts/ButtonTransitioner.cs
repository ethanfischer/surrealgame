using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SurrealGame
{
    public class ButtonTransitioner : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        public Color32 NormalColor = Color.white;
        public Color32 HoverColor = Color.red;
        public Color32 DownColor = Color.gray;

        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _image.color = HoverColor;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _image.color = DownColor;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _image.color = HoverColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _image.color = NormalColor;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _image.color = HoverColor;
        }
    }
}
