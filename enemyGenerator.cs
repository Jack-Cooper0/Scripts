using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{
        public GameObject enemy;
        public float spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DecideSiEnemigo();
    }
    private void DecideSiEnemigo(){
        float random = Random.Range(0.0f,100.0f);
        if(random < spawn){
            GameObject.Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}
