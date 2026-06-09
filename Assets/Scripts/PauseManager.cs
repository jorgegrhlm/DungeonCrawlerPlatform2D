using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PauseManager : MonoBehaviour
{
    private string savePath;

     
    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public SaveManager saveManager;

    private bool isPaused = false;

    void Start()
    {
        savePath =
            Application.persistentDataPath + "/save.json";
    }

    void OnEnable()
{
    SceneManager.sceneLoaded += OnSceneLoaded;
}

void OnDisable()
{
    SceneManager.sceneLoaded -= OnSceneLoaded;
}

void OnSceneLoaded(Scene scene, LoadSceneMode mode)
{
    pauseMenu.SetActive(false);

    optionsMenu.SetActive(false);

    Time.timeScale = 1f;

    isPaused = false;
}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            AudioManager.instance.PlayButtonSound();
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        AudioManager.instance.musicSource.Pause();

        pauseMenu.SetActive(true);

        Time.timeScale = 0f;

        isPaused = true;
    }

    public void ResumeGame()
    {
        AudioManager.instance.PlayButtonSound();

        AudioManager.instance.musicSource.UnPause();

        pauseMenu.SetActive(false);

        Time.timeScale = 1f;

        isPaused = false;
    }

    public void MainMenu()
    {
        AudioManager.instance.PlayButtonSound();
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }



    public void SaveGame()
    {
        AudioManager.instance.PlayButtonSound();
        saveManager.SaveGame();
    }

    public void OpenOptions()
    {
        AudioManager.instance.PlayButtonSound();
        pauseMenu.SetActive(false);

        optionsMenu.SetActive(true);
    }

        public void LoadGame()
{
    AudioManager.instance.PlayButtonSound();

    pauseMenu.SetActive(false);

    optionsMenu.SetActive(false);

    AudioManager.instance.musicSource.UnPause();

    Time.timeScale = 1f;

    isPaused = false;

    saveManager.LoadGame();
}

    public void BackToPause()
    {
        AudioManager.instance.PlayButtonSound();
        optionsMenu.SetActive(false);

        pauseMenu.SetActive(true);
    }
}