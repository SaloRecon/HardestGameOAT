using UnityEngine;

public class RotateRotator : MonoBehaviour
{
    [SerializeField] float speedRotation;
    [SerializeField] private Vector3 rotationDirection;
    
    void Update()
    {
        Rotate();
    }
    
    void Rotate()
    {
        
        this.gameObject.transform.Rotate(rotationDirection * (speedRotation * Time.deltaTime), Space.World);

    }
}
