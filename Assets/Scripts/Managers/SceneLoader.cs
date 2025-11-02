using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] private int toGoRoom;
    
    public Animator transition;
    
    [SerializeField] private float transitionTime;
    
    [SerializeField] private AudioClip nextSceneLoad;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SoundFXManagers.Instance.PlaySoundFXClip(nextSceneLoad, transform, 1f);
            StartCoroutine(LoadScene(toGoRoom));
           
        }
        
    }

    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(toGoRoom);
        
    }
}
