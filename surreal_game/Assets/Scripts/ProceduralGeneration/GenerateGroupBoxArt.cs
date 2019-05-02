using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.ProceduralGeneration
{
    public class GenerateGroupBoxArt : MonoBehaviour
    {
        public List<Sprite> Sprites;
        public List<Material> Materials;
        

        public void Generate(ref GameObject go)
        {
            var i = BoxArtRandomNumberGenerator.Next(0, Materials.Count);
            var material = Materials[i];

            var j = BoxArtRandomNumberGenerator.Next(0, Sprites.Count);
            var sprite = Sprites[j];

            foreach (Transform t in go.transform)
            {
                t.gameObject.GetComponent<GenerateBoxArt>().Generate(sprite, material);
            }
        }
    }
}
