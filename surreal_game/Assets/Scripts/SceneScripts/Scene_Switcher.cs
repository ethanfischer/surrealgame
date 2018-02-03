using SurrealGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switcher : MonoBehaviour
{
    private Scene_Master sceneMaster;
    void OnEnable()
    {
        SetInitialReferences();
        sceneMaster.GoToSceneEvent += SwitchScene;
    }

    void OnDisable()
    {
        sceneMaster.GoToSceneEvent -= SwitchScene;
    }

    void SetInitialReferences()
    {
        sceneMaster = GetComponent<Scene_Master>();
    }

    void SwitchScene(string scene)
    {
        SceneManager.LoadScene(scene);

    }
}
