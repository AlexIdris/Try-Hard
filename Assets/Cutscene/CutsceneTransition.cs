using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTransition : MonoBehaviour
{
    public GameObject imageFading;

    public void Start()
    {
        imageFading.SetActive(true);
    }
    
    public void PlayTheGame()
    {
        SceneManager.LoadScene("Tutoial Level Layout");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayTheGame();
        }
    }
}
