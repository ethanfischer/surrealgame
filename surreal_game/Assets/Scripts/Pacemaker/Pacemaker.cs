using UnityEngine;

public class Pacemaker : MonoBehaviour
{
    private const float PACE = 1;

    public event HeartbeatEvent OnHeartbeat;
    public event HeartbeatEvent OnSongOver;

    //SINGLETON Pattern. TODO: Look up the dangers. See if theres a cleaner way of doing this. Or creating a class for creating singeltons
    private static Pacemaker _instance = null;
    public static Pacemaker Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<Pacemaker>();
            }

            return _instance;
        }
    }

    void Start()
    {
        InvokeRepeating("CallHeartbeat", 0, PACE);
        Invoke("CallSongOver", 5);
    }

    void CallHeartbeat()
    {
        OnHeartbeat?.Invoke(this, new HeartbeatEventArgs());
    }

    void CallSongOver()
    {
        OnSongOver?.Invoke(this, new HeartbeatEventArgs());
    }
}
