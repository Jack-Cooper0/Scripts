using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D _destroy)
    {
        
        if(_destroy.gameObject.tag == "enemy"){
        _destroy.gameObject.SetActive(false);
        Destroy(_destroy.gameObject, 0.5f);
        }
        if(_destroy.gameObject.tag == "enemy2"){
        _destroy.gameObject.SetActive(false);
        Destroy(_destroy.gameObject, 0.5f);
        }
        if(_destroy.gameObject.tag == "miniBoss"){
        _destroy.gameObject.SetActive(false);
        Destroy(_destroy.gameObject, 0.5f);
        }
    }
    
}
