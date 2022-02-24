using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager obj;

    public Text scoreLbl;
    public Text livesLbl;

    public Transform UIPanel;


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

    public void startGame()
    {
        Game.obj.gamePaused=true;
        UIPanel.gameObject.SetActive(true);
    }

    public void hideInitPanel()
    {
        Game.obj.gamePaused=false;
        UIPanel.gameObject.SetActive(false);
    }

    void OnDestroy()
    {
        obj=null;
    }
}