using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music Instance1;
    

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance1 == null)
        {
            Instance1 = this;
        }
        else 
        {
            Destroy(gameObject);
        }
        
    }
}
