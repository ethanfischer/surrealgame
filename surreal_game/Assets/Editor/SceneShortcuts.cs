using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

class SceneShortcuts : EditorWindow
{
    private string[] scenes;
    private static int caseSwitch = 0;

    enum Scenes //TODO try using this
    {
        ApplicationLaunch,
        WeirdPlace
    }

    public static void Main()
    {
        SwitchToScene("Assets/Scenes/Application.Launch.unity");
    }

    public static void WeirdPlace()
    {
        SwitchToScene("Assets/Scenes/WeirdPlace.unity");
    }

    [MenuItem("Scenes/ToggleScene %g")]
    public static void ToggleScene()
    {
        switch (caseSwitch)
        {
            case 0:
                SwitchToScene("Assets/Scenes/WeirdPlace.unity");
                caseSwitch++;
                break;
            case 1:
                SwitchToScene("Assets/Scenes/Application.Launch.unity");
                caseSwitch = 0;
                break;
            default:
                break;
        }
    }


    private static void SwitchToScene(string scene)
    {
        EditorSceneManager.OpenScene(scene);
        Debug.Log("Switched to scene: " + scene);

    }
}