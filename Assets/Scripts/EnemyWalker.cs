using UnityEngine;

public class EnemyWalker : MonoBehaviour
{
    public float speed = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    

        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if(collision.gameObject.CompareTag("Player"))
        {
            AudioManager.instance.PlaySFX(
    AudioManager.instance.enemyHitSFX
);
            Vector2 hitDirection =
                collision.transform.position - transform.position;

            // SALTO ENCIMA
            ContactPoint2D contact =
    collision.GetContact(0);

bool jumpedOnTop =
    contact.normal.y < -0.5f;

if(jumpedOnTop)
{
     GameManager.score += 10;

    Rigidbody2D rb =
        collision.gameObject.GetComponent<Rigidbody2D>();

    if(rb != null)
    {
        rb.linearVelocity =
            new Vector2(
                rb.linearVelocity.x,
                10f
            );
    }

    return;
}

PlayerHealth health =
    collision.gameObject.GetComponent<PlayerHealth>();

if(health != null)
{
    health.TakeDamage();
}
        }
    }

}