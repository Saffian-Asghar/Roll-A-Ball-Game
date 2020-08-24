using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{   
    private float timer = 0f;
    public GameObject enemy1 ;
    public GameObject enemy2 ;
    public GameObject enemy3 ;
    public GameObject enemy4 ; 
    // Start is called before the first frame update
    void Start()
    {
        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            enemy1.SetActive(true);
            
        }
        if (timer > 6)
        {
            enemy2.SetActive(true);
            
        }
        if (timer > 9)
        {
            enemy3.SetActive(true);
            
        }
        if (timer > 12)
        {
            enemy4.SetActive(true);
            
        }
        
    }
}
