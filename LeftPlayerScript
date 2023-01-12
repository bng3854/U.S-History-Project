using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerScript : MonoBehaviour
{
    public Animator LeftSoldierAnim;
    public SimpleTimer simpleTimer;
    public GameObject LeftBulletPrefab;
    public Transform bulletSpawn;

    [SerializeField] private AudioSource gunShotEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gunShotEffect.Play();
            Instantiate(LeftBulletPrefab, bulletSpawn.position, transform.rotation);
        }

        
    }
}
