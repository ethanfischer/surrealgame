using UnityEngine;

public class Pacemaker : MonoBehaviour
{
    private const float PACE = 1;

    public event Heartbeat OnHeartbeat;
    public event Heartbeat OnSongOver;

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
        OnHeartbeat.Invoke(this, new HeartbeatArgs());
    }

    void CallSongOver()
    {
        OnSongOver.Invoke(this, new HeartbeatArgs());
    }
}
