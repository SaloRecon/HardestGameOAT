
  using System.Collections;
  using TMPro;
  using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    
    private Vector3 initialPosition;
    
    [SerializeField] private float speed;
    
    [SerializeField] private TMP_Text coinText;
        
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject pointsCanva;
    
    [SerializeField] private AudioClip coinSound;
    [SerializeField] private AudioClip damageSound;
    
    private Rigidbody2D rb;
    
    void Start()
    {
        
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(LoadPoints());

    }
    
     private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        
        Vector3 movementDirection = new Vector3(hInput, vInput, 0f).normalized;
        
        
        //this.gameObject.transform.Translate(movementDirection * (Time.deltaTime * speed), Space.World);

        rb.linearVelocity = movementDirection * (speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
             coins++;
             coinText.text = ($"Score: {coins}");
             coin.SetActive(false);
             SoundFXManagers.Instance.PlaySoundFXClip(coinSound, transform, 1f);
            
        }

        else if (other.gameObject.CompareTag("Aspa"))
        {
            this.gameObject.transform.position = initialPosition; 
            coin.SetActive(true);
            coins = 0;
            coinText.text = ($"Score: {coins}");
            SoundFXManagers.Instance.PlaySoundFXClip(damageSound, transform, 1f);
        }
    }

    private IEnumerator LoadPoints()
    {
        yield return new WaitForSeconds(1f);
        pointsCanva.SetActive(true);

    }
    
    
}
