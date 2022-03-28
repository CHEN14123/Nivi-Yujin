using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeun : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Over");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LinearAndWandering");
    }
}