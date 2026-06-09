using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private string savePath;

    void Start()
    {
        savePath = Application.persistentDataPath + "/save.json";
    }

    public void SaveGame()
    {
        SaveData data = new SaveData();

        data.health = playerHealth.lives;

        data.score = GameManager.score;

        data.sceneName = SceneManager.GetActiveScene().name;

        data.hasKey = PlayerInventory.hasKey;

        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(savePath, json);

        Debug.Log("Partida guardada");
    }

    public void LoadGame()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerPrefs.SetInt("SavedLives", data.health);

            SceneManager.LoadScene(data.sceneName);
            
            GameManager.score = data.score;
            PlayerInventory.hasKey = data.hasKey;
        }
        else
        {
            Debug.Log("No existe guardado");
        }
    }
}