using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int RightPlayerHealth = 1;
    public static int LeftPlayerHealth = 1;
    public TextMeshProUGUI winText;
    public Behaviour scriptA;
    public Behaviour scriptB;
    public GameObject Menupanel;
    // Start is called before the first frame update
    void Start()
    {
        scriptA.enabled = true;
        scriptB.enabled = true;
        winText.text = "";
        Menupanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (RightPlayerHealth == 0 && LeftPlayerHealth == 0)
        {
            winText.text = "It was a tie XD?";
            scriptA.enabled = false;
            scriptB.enabled = false;
            Menupanel.SetActive(true);
        }

        if (RightPlayerHealth == 0)
        {
            winText.text = "Left Player wins";
            scriptA.enabled = false;
            scriptB.enabled = false;
            Menupanel.SetActive(true);
        }

        if (LeftPlayerHealth == 0)
        {
            winText.text = "Right Player wins";
            scriptA.enabled = false;
            scriptB.enabled = false;
            Menupanel.SetActive(true);
        }
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
