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
    
    void OnDestroy()
    {
        obj=null;
    }
}