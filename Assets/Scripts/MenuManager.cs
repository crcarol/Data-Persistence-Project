using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    // botão menu start
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // botão menu quit game
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    // botão main back to menu
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

}
