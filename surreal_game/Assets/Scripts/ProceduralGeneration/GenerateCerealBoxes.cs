using UnityEngine;

namespace Assets.Scripts.ProceduralGeneration
{
    public class GenerateCerealBoxes : RepeatInstantiate
    {
        protected override GameObject MakeClone(int i)
        {
            if (RandomlyPlacePancakeMix.Instance.TryGetPancakeMix(out GameObject go))
            {
                return go;
            }

            return base.MakeClone(i);
        }

        protected override void Tweak(int i, GameObject clone)
        {
            base.Tweak(i, clone);

            if (clone.name == "PancakeMix") return;
            GetComponent<GenerateGroupBoxArt>().Generate(ref clone);
        }
    }
}
