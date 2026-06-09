using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Music")]
    public AudioSource musicSource;

    [Header("SFX")]
    public AudioSource sfxSource;

    public AudioSource walkSource;

    [Header("Menu")]
    public AudioClip mainMenuMusic;

    [Header("Levels")]
    public AudioClip level1Music;
    public AudioClip level1ExtraMusic;
    public AudioClip level2Music;
    public AudioClip level3Music;

    [Header("Story")]
    public AudioClip story1Music;
    public AudioClip story2Music;
    public AudioClip story3Music;

    [Header("Game Over")]
    public AudioClip gameOverMusic;

    [Header("Victory")]
    public AudioClip victoryMusic;

    [Header("Player")]
    public AudioClip jumpSFX;
    public AudioClip walkSFX;
    public AudioClip damageSFX;

    [Header("Gameplay")]
    public AudioClip enemyHitSFX;
    public AudioClip keyPickupSFX;
    public AudioClip doorOpenSFX;
    public AudioClip doorLockedSFX;

    [Header("UI")]
    public AudioClip buttonClickSFX;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
    Button[] buttons =
        FindObjectsByType<Button>(
            FindObjectsSortMode.None
        );

    foreach(Button button in buttons)
    {
        button.onClick.RemoveListener(
            PlayButtonSound
        );

        button.onClick.AddListener(
            PlayButtonSound
        );
    }
}

    public void PlayMusic(AudioClip clip)
    {
        if(musicSource.clip == clip)
        {
            return;
        }

        musicSource.clip = clip;

        musicSource.loop = true;

        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void StartWalkSound()
{
    if(walkSource.isPlaying)
    {
        return;
    }

    walkSource.clip = walkSFX;

    walkSource.Play();
}

public void StopWalkSound()
{
    walkSource.Stop();
}

public void PlayButtonSound()
{
    PlaySFX(buttonClickSFX);
}
}
