using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 initialLocation;
    
    private Vector3 currentLocation;

    private float timer;
    
    [SerializeField] private float distance;
    
    void Start()
    {
        currentLocation = initialLocation;
    }
    
    void Update()
    {
        
        timer += Time.deltaTime; // deltaTime es siempre 1 segundo.
        
        if (timer >= distance)
        {
            currentLocation *= -1;
            timer = 0;
        }
       
        transform.Translate(currentLocation * (speed *  Time.deltaTime));
    }
}
