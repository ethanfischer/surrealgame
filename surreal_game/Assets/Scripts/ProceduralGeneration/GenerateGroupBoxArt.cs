using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.ProceduralGeneration
{
    public class GenerateGroupBoxArt : MonoBehaviour
    {
        public List<Sprite> Sprites;
        public List<Material> Materials;

        public void Generate()
        {
            var i = new Random().Next(0, Materials.Count);
            var material = Materials[i];

            var j = new Random().Next(0, Sprites.Count);
            var sprite = Sprites[j];

            foreach (Transform t in transform)
            {
                t.gameObject.GetComponent<GenerateBoxArt>().Generate(sprite, material);
            }
        }
    }
}
