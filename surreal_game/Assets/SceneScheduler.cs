using System.Collections;
using System.Collections.Generic;
using SurrealGame;
using UnityEngine;

public class SceneScheduler : MonoBehaviour
{
    public string Sfx;
    public string NextScene;
    public string CurrentScene;
    private Pacemaker Pacemaker; 
    private Scene_Master SceneMaster;

    private void Start()
    {
        SetInitialReferences();
        Pacemaker.OnSongOver += TrySwitchScene;
    }

    private void TrySwitchScene(object sender, HeartbeatEventArgs eventArgs)
    {
        SceneMaster.RemoveScene(CurrentScene);
        SceneMaster.AddScene(NextScene);
    }

    private void SetInitialReferences()
    {
        SceneMaster = GameManager_References._sceneManager.GetComponent<Scene_Master>();
        Pacemaker = Pacemaker.Instance;
    }
}
