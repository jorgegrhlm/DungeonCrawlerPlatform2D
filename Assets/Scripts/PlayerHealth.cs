using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    public Transform spawnPoint;

    void Start()
    {
        if(PlayerPrefs.HasKey("SavedLives"))
        {
            lives =
                PlayerPrefs.GetInt("SavedLives");

            PlayerPrefs.DeleteKey("SavedLives");
        }
    }

    public void TakeDamage()
    {
        AudioManager.instance.PlaySFX(
    AudioManager.instance.damageSFX
);
        lives--;

        transform.position =
            spawnPoint.position;

        Rigidbody2D rb =
            GetComponent<Rigidbody2D>();

        rb.linearVelocity =
            Vector2.zero;

        if(lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}