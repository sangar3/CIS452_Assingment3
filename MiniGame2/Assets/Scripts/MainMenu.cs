using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioClip gamestartfx;
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        AudioManager.Instance.PlaySFX(gamestartfx, 3.0f);

    }
    public void backmainmenu()
    {
        SceneManager.LoadScene("StartTutorial");
    }
}
