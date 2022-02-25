using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager obj;

    public Text scoreLbl;
    public Text livesLbl;
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    private bool isPaused = false;


    void Awake()
    {
        obj=this;
    }

    public void updateLives()
    {
        livesLbl.text=""+Player.obj.lives;
    }

    public void updateScore()
    {
        scoreLbl.text=""+ Game.obj.score;
    }
    
    public void loadScene()
    {
        SceneManager.LoadScene("MiainMenu");
    }

    public void pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void exitMainMenu(){
        Time.timeScale = 1f;
         SceneManager.LoadScene("MiainMenu");
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    
    void OnDestroy()
    {
        obj=null;
    }
}