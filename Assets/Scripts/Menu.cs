using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public LevelManager lm;

    void Start()
    {
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    public void LevelButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void EasyButton()
    {
        lm.stage = 1;
        SceneManager.LoadScene("Game");
    }

    public void MediumButton()
    {
        lm.stage = 2;
        SceneManager.LoadScene("Game");
    }

    public void HardButton()
    {
        lm.stage = 3;
        SceneManager.LoadScene("Game");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
