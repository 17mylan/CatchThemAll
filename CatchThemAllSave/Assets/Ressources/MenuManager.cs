using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ChangeScene(string _str)
    {
        SceneManager.LoadScene(_str);
    }
    public void ApplicationQuit()
    {
        Application.Quit();
    }
}
