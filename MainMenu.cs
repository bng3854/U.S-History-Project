using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Duel()
    {
        SceneManager.LoadScene("Duel");
    }

    public void Easy()
    { 
        SceneManager.LoadScene("Easy");
    }    

    public void Medium()
    {
        SceneManager.LoadScene("Medium");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
}
