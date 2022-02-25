using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MainMenuUIManager : MonoBehaviour
{
    public static MainMenuUIManager obj;

    void Awake()
    {
        obj=this;
    }

    public void levelSelector()
    {
        SceneManager.LoadScene("Level_selector");
    }

    public void rules()
    {
        SceneManager.LoadScene("Rules");
    }

    void OnDestroy()
    {
        obj=null;
    }
}
