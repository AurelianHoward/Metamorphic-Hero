using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string TrainingRoom = "TrainingRoom";

    public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(TrainingRoom);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

    [SerializeField] GameObject optionsMenuPanel;

    [SerializeField] GameObject ControlsMenuPanel;

    public void OptionsMenuClose()
    {
        optionsMenuPanel.SetActive(false);
    }

    public void OptionsMenuOpen()
    {
        optionsMenuPanel.SetActive(true);
    }

    public void ControlsMenuClose()
    {
        ControlsMenuPanel.SetActive(false);
    }

    public void ControlsMenuOpen()
    {
        ControlsMenuPanel.SetActive(true);
    }






}
