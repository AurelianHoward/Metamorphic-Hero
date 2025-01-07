using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    [SerializeField] string Menu = "Menu";

    [SerializeField] GameObject CentaurBody;
    [SerializeField] GameObject Firebreath;
    public void StartGame()
    {
        
        UnityEngine.Cursor.visible = false;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }

    [SerializeField] GameObject pauseMenuPanel;
    [SerializeField] GameObject Hud;

    [SerializeField] bool IsPauseMenuAvailable = false;
    [HideInInspector] public static bool IsGamePaused = false;

    void Update()
    {
        PauseMenu();
    }

    public void PauseMenu()
    {
        if (IsPauseMenuAvailable)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (IsGamePaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }


    public void Pause()
    {
        Hud.SetActive(false);
        UnityEngine.Cursor.visible = true;
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;
    }

    public void Resume()
    {
        Hud.SetActive(true);
        UnityEngine.Cursor.visible = false;
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }






    public void ReturnToMainMenu()
    {
        Resume();
        UnityEngine.Cursor.visible = true;
        SceneManager.LoadScene(Menu);
    }



    public void CentaurMovement()
    {
        CentaurBody.SetActive(true);
    }

    public void FireBreath()
    {
        Firebreath.SetActive(true );         
    }
    public object Health()
    {
        PlayerStats playerstats = GameObject.Find("player").GetComponent<PlayerStats>();
        return playerstats.PlayerMaxHealth +=100;

    }
}

