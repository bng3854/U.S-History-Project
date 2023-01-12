using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleTimer : MonoBehaviour
{
    public float startingTime = 5f;
    public float currentTime = 0f;
    public TextMeshProUGUI timerText;
    public Behaviour scriptA;
    public Behaviour scriptB;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0.00");

        if (currentTime <= 0)
        {
            timerText.text = "0";
            

        }

        if (currentTime <= 3)
        {
            timerText.color = Color.red;
        }
    }


}
