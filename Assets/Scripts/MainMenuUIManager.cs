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

    public void story()
    {
        SceneManager.LoadScene("Story");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    void OnDestroy()
    {
        obj=null;
    }
}
