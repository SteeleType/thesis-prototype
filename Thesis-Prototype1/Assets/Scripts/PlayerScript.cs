using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody2D rb2d;
    private Vector2 input;
    public Animator animator; 

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
 
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        input.Normalize();
        
    }
    void FixedUpdate()
    {
        rb2d.linearVelocity = input * movementSpeed;

        if (input.sqrMagnitude > 0.01f)
        {
            float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg;
            rb2d.rotation = angle;
        }
    }
    
}
