using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class StoryUIManager : MonoBehaviour
{
    public static StoryUIManager obj;

    void Awake()
    {
        obj=this;
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
