using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public GameObject barrier;
    public SimpleTimer simpleTimer;
    public Animator RightSoldierAnim;
    public Animator LeftSoldierAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (simpleTimer.currentTime <= 0)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "LeftBullet")
        {
            Destroy(other.gameObject);
            GameManager.LeftPlayerHealth = GameManager.LeftPlayerHealth - 1;
            LeftSoldierAnim.Play("LeftSoldierDeath");
        }

        if (other.gameObject.tag == "RightBullet")
        {
            Destroy(other.gameObject);
            GameManager.RightPlayerHealth = GameManager.RightPlayerHealth - 1;
            RightSoldierAnim.Play("RightSoldierDeath");
        }
    }
}
