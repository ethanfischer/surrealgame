using UnityEngine;
using UnityEngine.SceneManagement;

namespace SurrealGame
{
    public abstract class GoToScene : MonoBehaviour
    {
        public string sceneName;

        public void CallGoToSceneEvent()
        {
            if (ArePrerequisitesMet())
            {
                GetComponent<Scene_Master>().CallGoToSceneEvent(sceneName);
            }
        }

        public abstract bool ArePrerequisitesMet();
    }
}