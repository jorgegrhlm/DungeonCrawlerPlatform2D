using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMusic : MonoBehaviour
{
    void Start()
    {
        string sceneName =
            SceneManager.GetActiveScene().name;

        if(AudioManager.instance == null)
        {
            return;
        }

        // MAIN MENU
        if(sceneName == "MainMenu")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.mainMenuMusic
            );
        }

        // STORY SCENE
        else if(sceneName == "StoryScene")
        {
            string currentStory =
                PlayerPrefs.GetString("Story");

            if(currentStory == "Intro")
            {
                AudioManager.instance.PlayMusic(
                    AudioManager.instance.story1Music
                );
            }

            else if(currentStory == "Level2")
            {
                AudioManager.instance.PlayMusic(
                    AudioManager.instance.story2Music
                );
            }

            else if(currentStory == "Level3")
            {
                AudioManager.instance.PlayMusic(
                    AudioManager.instance.story3Music
                );
            }
        }

        // LEVEL 1
        else if(sceneName == "Level1")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.level1Music
            );
        }

        // LEVEL 2
        else if(sceneName == "Level2")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.level2Music
            );
        }

        // LEVEL 3
        else if(sceneName == "Level3")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.level3Music
            );
        }

        // GAME OVER
        else if(sceneName == "GameOver")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.gameOverMusic
            );
        }

        // VICTORY
        else if(sceneName == "Victory")
        {
            AudioManager.instance.PlayMusic(
                AudioManager.instance.victoryMusic
            );
        }
    }
}