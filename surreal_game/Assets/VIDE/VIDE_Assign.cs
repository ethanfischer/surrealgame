using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MiniJSON_VIDE;

public class VIDE_Assign : MonoBehaviour
{
    /*
     * This script component should be attached to every game object you will be interacting with.
     * When interacting with the NPC or object, you will have to call the BeginDialogue() method on
     * the DialogueData component and pass this script.
     * It will safely load the assigned script and keep track of the amount of times you've interacted with it.
     * It will also allow you to set a start point override and to modify the assigned dialogue.
     */

    public List<string> diags = new List<string>();
    public int assignedIndex = 0;
    public int assignedID = 0;
    public string assignedDialogue = "";

    public int interactionCount = 0;
    public string alias = "";

    public int overrideStartNode = -1;

    public Sprite defaultNPCSprite;
    public Sprite defaultPlayerSprite;

    /// <summary>
    /// Returns the name of the currently assigned dialogue.
    /// </summary>
    /// <returns></returns>
    public string GetAssigned()
    {
        return diags[assignedIndex];
    }

    /// <summary>
    /// Assigns a new dialogue to these component.
    /// </summary>
    /// <param name="Dialogue name"></param>
    /// <returns></returns>
    public bool AssignNew(string newFile)
    {
        loadFiles();

        if (!diags.Contains(newFile))
        {
            Debug.LogError("Dialogue not found! Make sure the name is correct and has no extension");
            return false;
        }

        assignedIndex = diags.IndexOf(newFile);
        assignedDialogue = diags[assignedIndex];

        return true;
    }

    private void loadFiles()
    {
        TextAsset[] files = Resources.LoadAll<TextAsset>("Dialogues");
        diags = new List<string>();
        assignedIndex = 0;

        if (files.Length < 1) return;

        foreach (TextAsset f in files)
        {
            diags.Add(f.name);
        }

        diags.Sort();

    }

    /// <summary>
    /// Saves the current state of this VA component.
    /// </summary>
    /// <param name="filename">Name to save under.</param>
    public void SaveState(string filename)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();

        dict.Add("alias", alias);
        dict.Add("ovr", overrideStartNode);
        dict.Add("icount", interactionCount);

        dict.Add("aIndex", assignedIndex);
        dict.Add("aID", assignedID);
        dict.Add("aDialogue", assignedDialogue);

        SerializeHelper.WriteToFile(dict as Dictionary<string, object>, filename + ".json");
    }

    /// <summary>
    /// Loads a state to this VA component.
    /// </summary>
    /// <param name="filename">Name of the state to load.</param>
    public void LoadState(string filename)
    {

        string fileDataPath = (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer ? Application.persistentDataPath : Application.dataPath);
        if (!File.Exists(fileDataPath + "/VIDE/saves/VA/" + filename + ".json"))
        {
            Debug.LogWarning("Could not find save state!");
            return;
        }

        Dictionary<string, object> dict = SerializeHelper.ReadState(filename) as Dictionary<string, object>;

        alias = (string)dict["alias"];
        overrideStartNode = ((int)((long)dict["ovr"]));
        interactionCount = ((int)((long)dict["icount"]));

        assignedIndex = ((int)((long)dict["aIndex"]));
        assignedID = ((int)((long)dict["aID"]));
        assignedDialogue = (string)dict["aDialogue"];
    }

    class SerializeHelper
    {
        static string fileDataPath = (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer ? Application.persistentDataPath : Application.dataPath);

        public static object ReadState(string filename)
        {
            string jsonString = File.ReadAllText(fileDataPath + "/VIDE/saves/VA/" + filename + ".json");
            return MiniJSON_VIDE.DiagJson.Deserialize(jsonString);
        }

        public static void WriteToFile(object data, string filename)
        {
            if (!Directory.Exists(fileDataPath + "/VIDE"))
                Directory.CreateDirectory(fileDataPath + "/VIDE");
            if (!Directory.Exists(fileDataPath + "/VIDE/saves"))
                Directory.CreateDirectory(fileDataPath + "/VIDE/saves");
            if (!Directory.Exists(fileDataPath + "/VIDE/saves/VA"))
                Directory.CreateDirectory(fileDataPath + "/VIDE/saves/VA");

            string outString = MiniJSON_VIDE.DiagJson.Serialize(data);
            File.WriteAllText(fileDataPath + "/VIDE/saves/VA/" + filename, outString);
        }
    }



}

