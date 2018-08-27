using UnityEditor;
using UnityEditor.SceneManagement;

class SceneShortcuts : EditorWindow
{

    [MenuItem("Scenes/Main _%4")]
    public static void Main()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Main.unity");
    }

    [MenuItem("Scenes/House_Kitchen _%5")]
    public static void House_Kitchen()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/House/House_Kitchen.unity");
    }

    [MenuItem("Scenes/Base_House _%6")]
    public static void Base_House()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/House/Base_House.unity");
    }
}