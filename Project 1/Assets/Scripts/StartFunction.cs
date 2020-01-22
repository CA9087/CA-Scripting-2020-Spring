using UnityEngine;
using UnityEngine.Events;

public class StartFunction : MonoBehaviour
{
    public float floatNumber;
    public int scoreValue;
    public UnityEvent uEvent;
    // Start is called before the first frame update
    void Start()
    {
        uEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
