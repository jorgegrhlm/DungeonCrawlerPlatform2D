using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UITranslationManager : MonoBehaviour
{
    public TextMeshProUGUI txtHealth;
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtKey;

    public TextMeshProUGUI txtPause;

    public TextMeshProUGUI btnResume;
    public TextMeshProUGUI btnSave;
    public TextMeshProUGUI btnLoad;
    public TextMeshProUGUI btnOptions;
    public TextMeshProUGUI btnMenu;

    public TextMeshProUGUI txtOptions;

    public TextMeshProUGUI txtVolume;
    public TextMeshProUGUI txtResolution;
    public TextMeshProUGUI txtLanguage;

    public TextMeshProUGUI btnBack;

    public TextMeshProUGUI btnPlay;
    public TextMeshProUGUI btnExit;

    public TextMeshProUGUI txtGameOver;
    public TextMeshProUGUI btnRetry;

    public TextMeshProUGUI btnVolver;
    public TextMeshProUGUI btnSalir;

     public Text txtToggle;

    public TextMeshProUGUI txtVictoryStory;

    public TextMeshProUGUI mensajeAvanzarNivelOPerderNivel;

    void Update()
    {
        if(LanguageManager.english)
        {
            TranslateEnglish();
        }
        else
        {
            TranslateSpanish();
        }
    }

    void TranslateSpanish()
    {
        if(txtPause != null)
            txtPause.text = "PAUSA";

        if(btnResume != null)
            btnResume.text = "Continuar";

        if(btnSave != null)
            btnSave.text = "Guardar";

        if(btnLoad != null)
            btnLoad.text = "Cargar Partida";

        if(btnOptions != null)
            btnOptions.text = "Opciones";

        if(btnMenu != null)
            btnMenu.text = "Menu Principal";

        if(txtOptions != null)
            txtOptions.text = "OPCIONES";

        if(txtVolume != null)
            txtVolume.text = "Volumen";

        if(txtResolution != null)
            txtResolution.text = "Resolucion";

        if(txtLanguage != null)
            txtLanguage.text = "Idioma";

        if(btnBack != null)
            btnBack.text = "Volver";

        if(btnPlay != null)
            btnPlay.text = "Nueva Partida";

        if(btnExit != null)
            btnExit.text = "Salir";

        if(txtGameOver != null)
            txtGameOver.text = "JUEGO TERMINADO";

        if(btnRetry != null)
            btnRetry.text = "Reintentar";

        if(btnVolver != null)
            btnVolver.text = "Volver al Menu";

        if(txtToggle != null)
            txtToggle.text = "Silenciar";

        if(btnSalir != null)
            btnSalir.text = "Salir";

        if(txtVictoryStory != null)
        {
            txtVictoryStory.text =
                "Tras derrotar a los Goblin Demons y escapar de la mazmorra, "
                + "el aventurero finalmente vuelve a ver la luz del exterior. "
                + "La corrupción de la mazmorra ha sido destruida.";
        }

        
    }

    void TranslateEnglish()
    {
        if(txtPause != null)
            txtPause.text = "PAUSE";

        if(btnResume != null)
            btnResume.text = "Resume";

        if(btnSave != null)
            btnSave.text = "Save";

        if(btnLoad != null)
            btnLoad.text = "Load Game";

        if(btnOptions != null)
            btnOptions.text = "Options";

        if(btnMenu != null)
            btnMenu.text = "Main Menu";

        if(txtOptions != null)
            txtOptions.text = "OPCIONES";

        if(txtVolume != null)
            txtVolume.text = "Volume";

        if(txtResolution != null)
            txtResolution.text = "Resolution";

        if(txtLanguage != null)
            txtLanguage.text = "Language";

        if(btnBack != null)
            btnBack.text = "Back";

        if(btnPlay != null)
            btnPlay.text = "New Game";

        if(btnExit != null)
            btnExit.text = "Exit";

        if(txtGameOver != null)
            txtGameOver.text = "GAME OVER";

        if(btnRetry != null)
            btnRetry.text = "Retry";

        if(btnVolver != null)
            btnVolver.text = "Back to Menu";

        if(txtToggle != null)
            txtToggle.text = "Mute";

        if(btnSalir != null)
            btnSalir.text = "Exit";

        if(txtVictoryStory != null)
        {
            txtVictoryStory.text =
                "After defeating the Goblin Demons and escaping the dungeon, "
                + "the adventurer finally sees daylight again. "
                + "The corruption of the dungeon has been destroyed.";
        }
    }
}