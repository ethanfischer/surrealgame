using UnityEditor;
using UnityEditor.SceneManagement;

public class LoadMainSceneOnPlay : EditorWindow
{
    [MenuItem("Edit/Open Main Scene on Play %4")]
    static void Main()
    {
        if (EditorApplication.isPlaying == true)
        {
            EditorApplication.isPlaying = false;
            return;
        }

        EditorSceneManager.OpenScene("Assets/Scenes/Main.unity");
        EditorApplication.isPlaying = true;
    }
}
