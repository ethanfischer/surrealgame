using UnityEngine;

public class Pacemaker : MonoBehaviour
{
    private const float PACE = 5f;

    public event Heartbeat Heartbeat;

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
    }

    void CallHeartbeat()
    {
        Heartbeat.Invoke(this, new HeartbeatArgs());
    }
}
