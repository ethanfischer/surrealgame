using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReferenceFocuser : MonoBehaviour
{
    [MenuItem("GameObject/FocusOnReference _%0")]
    public static void FocusOnReference()
    {
        Selection.activeGameObject = GameObject.FindGameObjectWithTag("FocusReference");
        SceneView.FrameLastActiveSceneView();
    }
}
