using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //script for the enemies
    public int health; 
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private bool canBeHit;
    public float iFrameTimer = 2f;
    

    // Update is called once per frame
    void Start()
    {
        health = 3;
        rb =  GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateColor();
        canBeHit = true;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Vector2 direction = (collision.transform.position - transform.position).normalized;
            rb.AddForce(direction * 100, ForceMode2D.Impulse);
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
            health -= damage;
            UpdateColor();
        
        

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void UpdateColor()
    {
        switch (health)
        {
            case 3:
                spriteRenderer.color = Color.green;
                break;
            case 2:
                spriteRenderer.color = Color.yellow;
                break;
            case 1:
                spriteRenderer.color = Color.red;
                break;
            default:
                spriteRenderer.color = Color.white;
                break;
        }
    }
    
}
