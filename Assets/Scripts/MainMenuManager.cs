using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenuManager : MonoBehaviour
{
    private string savePath;
    public GameObject mainCanvas;
    public GameObject optionsCanvas;        

    void Start()
    {
        savePath =
            Application.persistentDataPath + "/save.json";
    }

    public void NuevaPartida()
    {
        AudioManager.instance.PlayButtonSound();
        PlayerInventory.hasKey = false;

        GameManager.score = 0;

        Time.timeScale = 1f;

        PlayerPrefs.SetString("Story", "Intro");

        SceneManager.LoadScene("StoryScene");
    }

   public void Cargar()
{
    AudioManager.instance.PlayButtonSound();
    if(File.Exists(savePath))
    {
        string json =
            File.ReadAllText(savePath);

        SaveData data =
            JsonUtility.FromJson<SaveData>(json);

        PlayerPrefs.SetInt(
            "SavedHealth",
            data.health
        );

        GameManager.score =
            data.score;

        SceneManager.LoadScene(
            data.sceneName
        );
    }
    else
    {
        Debug.Log("No existe partida guardada");
    }
}

    public void Opciones()
{
    AudioManager.instance.PlayButtonSound();
    optionsCanvas.SetActive(true);
}

public void VolverMenu()
{
    AudioManager.instance.PlayButtonSound();
    optionsCanvas.SetActive(false);
}

    public void Salir()
    {
        AudioManager.instance.PlayButtonSound();
        Application.Quit();
    }
}