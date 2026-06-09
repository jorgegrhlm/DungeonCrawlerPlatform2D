using UnityEngine;

public static class LanguageManager
{
    public static bool english
    {
        get
        {
            return PlayerPrefs.GetInt("English", 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(
                "English",
                value ? 1 : 0
            );

            PlayerPrefs.Save();
        }
    }
}