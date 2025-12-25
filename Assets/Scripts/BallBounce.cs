using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // Launch the ball in a random diagonal direction
        rb.velocity = new Vector2(1, 1).normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 1. Maintain constant speed
        rb.velocity = rb.velocity.normalized * speed;

        // 2. Change Color (Optional)
        spriteRenderer.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        // 3. Play Sound (Optional)
        // GetComponent<AudioSource>().Play();
    }
}