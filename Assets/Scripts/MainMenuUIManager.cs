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

    public void loadScene()
    {
        SceneManager.LoadScene("Level_selector");
    }

    void OnDestroy()
    {
        obj=null;
    }
}
