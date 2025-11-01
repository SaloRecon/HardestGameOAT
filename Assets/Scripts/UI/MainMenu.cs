using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int toGoRoom;
    public Animator transition1;
    [SerializeField] private float transitionTime1;
    public void OnClickPlayButton()
    {
        StartCoroutine(LoadScene(toGoRoom));
    }

    public void OnClickExitButton()
    {
        //solo funciona en version ejecutable
        Application.Quit();
    }
    
    IEnumerator LoadScene(int levelIndex)
    {
        transition1.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime1);
        SceneManager.LoadScene(toGoRoom);
        
    }
}
