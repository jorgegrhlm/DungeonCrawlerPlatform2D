using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    public TextMeshProUGUI txtStory;
    public TextMeshProUGUI txtContinue;
    public Image backgroundImage;
    public Sprite storyImage1;
    public Sprite storyImage2;
    public Sprite storyImage3;

    private string nextScene;

    void Start()
    {
        string currentStory =
            PlayerPrefs.GetString("Story");
            
        if(LanguageManager.english)
{
    txtContinue.text = "Continue";
}
else
{
    txtContinue.text = "Continuar";
}

        if(currentStory == "Intro")
        {
            backgroundImage.sprite = storyImage1;
            if(LanguageManager.english)
        {
            txtStory.text =
                "An adventurer awakens in a garden with only one entrance leading into an ancient underground dungeon.\n"
                + "The creatures living there have been corrupted by a dark energy.\n"
                + "To escape, he must cross three dangerous zones infested with goblins and find the magical keys.";
        }
        else
        {
            txtStory.text =
                "Un aventurero despierta en un jardín que solo tiene una entrada a una antigua mazmorra subterránea.\n"
                + "Las criaturas que habitan el lugar han sido corrompidas por una energía oscura.\n"
                + "Para escapar deberá atravesar tres zonas infestadas de goblins y encontrar las llaves mágicas.";
        }

            nextScene = "Level1";
        }

        if(currentStory == "Level2")
        {
            backgroundImage.sprite = storyImage2;
            if(LanguageManager.english)
        {
            txtStory.text =
                "After defeating the Goblin guardians, the adventurer descends deeper into the dungeon.\n"
                + "The creatures begin losing their human appearance.\n"
                + "The Faceless Goblins protect the next entrance.";
        }
        else
        {
            txtStory.text =
                "Tras superar a los Goblins guardianes, el aventurero desciende más profundo en la mazmorra.\n"
                + "Las criaturas comienzan a perder su apariencia humana.\n"
                + "Los Faceless Goblins protegen el siguiente acceso.";
        }

            nextScene = "Level2";
        }

        if(currentStory == "Level3")
        {
            backgroundImage.sprite = storyImage3;
            if(LanguageManager.english)
        {
            txtStory.text =
                "The corruption grows stronger.\n"
                + "The Goblin Demons dominate the final area of the castle.\n"
                + "Heat and darkness make every step more dangerous.";
        }
        else
        {
            txtStory.text =
                "La corrupción se vuelve más intensa.\n"
                + "Los Goblin Demons dominan la última zona del castillo.\n"
                + "El calor y la oscuridad hacen que cada paso sea más peligroso.";
        }
        nextScene = "Level3";
        }
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(nextScene);
    }
}