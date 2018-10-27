using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

class SceneShortcuts : EditorWindow
{

    [MenuItem("Scenes/Application.Launch _%;4")]
    public static void Main()
    {
        SwitchToScene("Assets/Scenes/Application.Launch.unity");
    }

    [MenuItem("Scenes/House_Kitchen _%;5")]
    public static void House_Kitchen()
    {
        SwitchToScene("Assets/Scenes/House/House_Kitchen.unity");
    }

    [MenuItem("Scenes/Base_House _%;6")]
    public static void Base_House()
    {
        SwitchToScene("Assets/Scenes/House/Base_House.unity");
    }


    private static void SwitchToScene(string scene)
    {
        EditorSceneManager.OpenScene(scene);
        Debug.Log("Switched to scene: " + scene);
    }
}