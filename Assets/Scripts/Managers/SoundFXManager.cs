using UnityEngine;

public class SoundFXManagers : MonoBehaviour
{
   public static SoundFXManagers Instance;
   
   [SerializeField] private AudioSource soundFXObject;
   
   private void Awake() 
   {
       if (Instance == null) 
       {
           Instance = this;
       }
   }

   public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
   {
       //Spawn in gameObject
       AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, spawnTransform.rotation);
       
       //assign the audioClip
       audioSource.clip = audioClip;
       
       //Assign volume
       audioSource.volume = volume;
       
       //Play Sound
       audioSource.Play();
       
       //get length of sound FX clip
       float clipLength = audioSource.clip.length;
       
       //destroy the clip after it is done
       Destroy(audioSource.gameObject, clipLength);
    
   }
   
   

}
