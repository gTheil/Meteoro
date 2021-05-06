using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public LevelManager lm;
    private AudioSource audio;

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }

    public void LevelButton()
    {
        audio.Stop();
        audio.Play();
        SceneManager.LoadScene("LevelSelect");
    }

    public void EasyButton()
    {
        audio.Stop();
        audio.Play();
        lm.stage = 1;
        SceneManager.LoadScene("Game");
    }

    public void MediumButton()
    {
        audio.Stop();
        audio.Play();
        lm.stage = 2;
        SceneManager.LoadScene("Game");
    }

    public void HardButton()
    {
        audio.Stop();
        audio.Play();
        lm.stage = 3;
        SceneManager.LoadScene("Game");
    }

    public void CreditsButton()
    {
        audio.Stop();
        audio.Play();
        SceneManager.LoadScene("Credits");
    }

    public void MenuButton()
    {
        audio.Stop();
        audio.Play();
        SceneManager.LoadScene("Menu");
    }

    public void QuitButton()
    {
        audio.Stop();
        audio.Play();
        Application.Quit();
    }

    public void RetryButton()
    {
        audio.Stop();
        audio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
