using UnityEngine;

namespace Assets.Scripts.ProceduralGeneration
{
    public class GenerateBoxArt : MonoBehaviour
    {
        public SpriteRenderer SpriteRenderer;

        public void Generate(Sprite sprite, Material material)
        {
            SetSprite(sprite);
            SetMaterial(material);
        }

        private void SetMaterial(Material m)
        {
            transform.GetChild(0).GetComponent<Renderer>().material = m;
        }

        private void SetSprite(Sprite s)
        {
            SpriteRenderer.sprite = s;
        }
    }
}
