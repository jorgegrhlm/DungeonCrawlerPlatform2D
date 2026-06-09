using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void Reintentar()
{
    PlayerInventory.hasKey = false;

    GameManager.score = 0;

    Time.timeScale = 1f;

    PlayerPrefs.SetString("Story", "Intro");

    SceneManager.LoadScene("StoryScene");
}

    public void MenuPrincipal()
    {
        PlayerInventory.hasKey = false;

        SceneManager.LoadScene("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }
}