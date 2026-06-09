using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class Door : MonoBehaviour
{
    private TextMeshProUGUI txtMessage;

    private bool usedDoor = false;

    void Start()
    {
        txtMessage =
            GameObject.Find("mensajeAvanzarNivelOPerderNivel")
            .GetComponent<TextMeshProUGUI>();

        string currentScene =
            SceneManager.GetActiveScene().name;

        KeyWalker walker =
            GetComponent<KeyWalker>();

        if(currentScene == "Level1")
        {
            walker.speed = 3f;
        }

        if(currentScene == "Level2")
        {
            walker.speed = 4f;
        }

        if(currentScene == "Level3")
        {
            walker.speed = 5f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(usedDoor)
        {
            return;
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            usedDoor = true;

            StartCoroutine(CheckDoor());
        }
    }

    IEnumerator CheckDoor()
    {
        Time.timeScale = 0f;

        string currentScene =
            SceneManager.GetActiveScene().name;

        if(PlayerInventory.hasKey)
        {
            AudioManager.instance.PlaySFX(
            AudioManager.instance.doorOpenSFX
        );
            if(LanguageManager.english)
{
    txtMessage.text =
        "Congratulations! You found the key and opened the door";
}
else
{
    txtMessage.text =
        "Enhorabuena! has encontrado la llave y abierto la puerta";
}

            yield return new WaitForSecondsRealtime(2f);

            PlayerInventory.hasKey = false;

            Time.timeScale = 1f;

            if(currentScene == "Level1")
            {
                PlayerPrefs.SetString("Story", "Level2");

                SceneManager.LoadScene("StoryScene");
            }

            else if(currentScene == "Level2")
            {
                PlayerPrefs.SetString("Story", "Level3");

                SceneManager.LoadScene("StoryScene");
            }

            else if(currentScene == "Level3")
            {
                SceneManager.LoadScene("Victory");
            }
        }
        else
        {
            AudioManager.instance.PlaySFX(
            AudioManager.instance.doorLockedSFX
        );
            if(LanguageManager.english)
{
    txtMessage.text =
        "Sorry, You need the key to open this door!";
}
else
{
    txtMessage.text =
        "Lo siento, necesitas la llave para abrir esta puerta";
}

            yield return new WaitForSecondsRealtime(2f);

            Time.timeScale = 1f;

            SceneManager.LoadScene("GameOver");
        }
    }
}