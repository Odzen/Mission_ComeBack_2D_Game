using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Rules : MonoBehaviour
{
    public static Rules obj;

    void Awake()
    {
        obj=this;
    }

    public void backMainMenu()
    {
        SceneManager.LoadScene("MiainMenu");
    }

    void OnDestroy()
    {
        obj=null;
    }
}
