using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI txtKey;

    public TextMeshProUGUI txtHealth;

    public TextMeshProUGUI txtScore;

    public PlayerHealth playerHealth;

    void Update()
    {
            if(LanguageManager.english)
    {
        txtHealth.text =
            "Lives: " + playerHealth.lives;

        txtScore.text =
            "Score: " + GameManager.score;

        if(PlayerInventory.hasKey)
        {
            txtKey.text = "Key: YES";
        }
        else
        {
            txtKey.text = "Key: NO";
        }
    }
    else
    {
        txtHealth.text =
            "Vidas: " + playerHealth.lives;

        txtScore.text =
            "Puntos: " + GameManager.score;

        if(PlayerInventory.hasKey)
        {
            txtKey.text = "Llave: SI";
        }
        else
        {
            txtKey.text = "Llave: NO";
        }
    }
    }
}