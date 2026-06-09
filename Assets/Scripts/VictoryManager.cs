using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VictoryManager : MonoBehaviour
{
    public TextMeshProUGUI txtFinalScore;

    public TextMeshProUGUI txtStory;

    void Start()
    {
        txtFinalScore.text =
            "Score Final: " + GameManager.score;

        txtStory.text =
            "Tras derrotar a los Goblin Demons y escapar de la mazmorra, "
            + "el aventurero finalmente vuelve a ver la luz del exterior. "
            + "La corrupción de la mazmorra ha sido destruida.";
    }

    public void VolverMenu()
    {
        AudioManager.instance.PlayButtonSound();
        PlayerInventory.hasKey = false;

        GameManager.score = 0;

        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }

    public void SalirJuego()
    {
        AudioManager.instance.PlayButtonSound();
        Application.Quit();
    }
}