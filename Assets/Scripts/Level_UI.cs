using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Level_UI : MonoBehaviour
{
    public static Level_UI obj;

    
    public Transform UIPanel;

    void Awake()
    {
        obj=this;
    }

    public void loadScene()
    {
        SceneManager.LoadScene("Level1");
    }

    void OnDestroy()
    {
        obj=null;
    }

}
