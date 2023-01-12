using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBox : MonoBehaviour
{
    public Animator RightSoldierAnim;
    public Animator LeftSoldierAnim;
    public Behaviour scriptA;
    public Behaviour scriptB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "LeftBullet")
        {
            GameManager.RightPlayerHealth = GameManager.RightPlayerHealth - 1;
            Destroy(other.gameObject);
            Debug.Log("Lost one health");
            RightSoldierAnim.Play("RightSoldierDeath");
            scriptA.enabled = false;
            scriptB.enabled = false;
        }

        if (other.gameObject.tag == "RightBullet")
        {
            GameManager.LeftPlayerHealth = GameManager.LeftPlayerHealth - 1;
            Destroy(other.gameObject);
            Debug.Log("Lost one health");
            LeftSoldierAnim.Play("LeftSoldierDeath");
            scriptA.enabled = false;
            scriptB.enabled = false;
        }
    }
}
