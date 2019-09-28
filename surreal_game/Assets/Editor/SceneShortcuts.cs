using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

class SceneShortcuts : EditorWindow
{
    private string[] scenes;
    private static int caseSwitch;

    [MenuItem("Scenes/ToggleScene %g")]
    public static void ToggleScene()
    {
        switch (caseSwitch)
        {
            case 0:
                SwitchToScene("Assets/Scenes/WeirdPlace.unity");
                caseSwitch++;
                break;
            //case 1:
            //    SwitchToScene("Assets/Scenes/GasStation.unity");
            //    caseSwitch++;
            //    break;
            case 1:
                SwitchToScene("Assets/Scenes/Application.Launch.unity");
                caseSwitch = 0;
                break;
        }
    }


    private static void SwitchToScene(string scene)
    {
        EditorSceneManager.OpenScene(scene);
    }
}