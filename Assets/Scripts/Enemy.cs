/*using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if(playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}*/