using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown languageDropdown;

    public Slider volumeSlider;

    public Toggle toggleSound;

    public Image toggleBackground;

    private bool isMuted = false;

    void Start()
    {
        // IDIOMA
        if(LanguageManager.english)
        {
            languageDropdown.value = 1;
        }
        else
        {
            languageDropdown.value = 0;
        }

        languageDropdown.RefreshShownValue();

        // VOLUMEN
        float savedVolume =
            PlayerPrefs.GetFloat("Volume", 1f);

        volumeSlider.value = savedVolume;

        AudioListener.volume = savedVolume;

        // MUTE
        isMuted =
            PlayerPrefs.GetInt("Muted", 0) == 1;

        toggleSound.isOn = isMuted;

        UpdateToggleColor();

        if(isMuted)
        {
            AudioListener.volume = 0f;
        }
    }

    public void ChangeVolume(float volume)
    {
        if(isMuted)
        {
            return;
        }

        AudioListener.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);

        PlayerPrefs.Save();
    }

    public void ToggleSound(bool enabled)
    {
        isMuted = enabled;

        if(isMuted)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume =
                volumeSlider.value;
        }

        PlayerPrefs.SetInt(
            "Muted",
            isMuted ? 1 : 0
        );

        PlayerPrefs.Save();

        UpdateToggleColor();

        AudioManager.instance.PlayButtonSound();
    }

    void UpdateToggleColor()
    {
        if(toggleSound.isOn)
        {
            toggleBackground.color =
                Color.green;
        }
        else
        {
            toggleBackground.color =
                Color.white;
        }
    }

    public void ChangeResolution(int index)
    {
        AudioManager.instance.PlayButtonSound();

        switch(index)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);
                break;

            case 1:
                Screen.SetResolution(3840, 2160, true);
                break;

            case 2:
                Screen.SetResolution(2880, 1800, true);
                break;
        }
    }

    public void ChangeLanguage(int index)
    {
        AudioManager.instance.PlayButtonSound();

        if(index == 0)
        {
            LanguageManager.english = false;
        }

        if(index == 1)
        {
            LanguageManager.english = true;
        }
    }

    public void BackToMenu()
    {
        AudioManager.instance.PlayButtonSound();

        string returnScene =
            PlayerPrefs.GetString("ReturnScene");

        SceneManager.LoadScene(returnScene);
    }
}