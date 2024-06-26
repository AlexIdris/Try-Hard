using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject playerUI;
    public GameObject camPlayer;




    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        camPlayer.GetComponent<PlayerCam>().enabled = false;
        pauseMenu.SetActive(true);
        player.SetActive(false);
        playerUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camPlayer.GetComponent<PlayerCam>().enabled = true;
        pauseMenu.SetActive(false);
        player.SetActive(true);
        playerUI.SetActive(true);
        Time.timeScale = 1;

    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenuScene");
    }

    void Start()
    {
        pauseMenu.SetActive(false);
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseMenu.activeSelf)
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeSelf)
        {
            ContinueGame();
        }
    }
}
