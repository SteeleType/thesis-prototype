using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerHealth = 5f;
    public TextMeshProUGUI playerHealthText;
    public float movementSpeed;
    private Rigidbody2D rb2d;
    private Vector2 input;
    public Animator animator; 

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
 
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Vector2 direction = (other.transform.position - transform.position).normalized;
            rb2d.AddForce(direction * 100, ForceMode2D.Impulse);
            Destroy(other.gameObject);
            playerHealth--;
           
        }
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input.Normalize();
        
    }
    void FixedUpdate()
    {
        playerHealthText.text = playerHealth.ToString();
        rb2d.linearVelocity = input * movementSpeed;

        if (input.sqrMagnitude > 0.01f)
        {
            float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg;
            rb2d.rotation = angle;
        }
    }
    
}
