using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack : MonoBehaviour
{
    public GameObject Coin2;
    public GameObject Coin4;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f); 
    }

    // Update is called once per frame
    void Update()
    {

        }
        void OnCollisionEnter2D(Collision2D _atack){
            if(_atack.gameObject.tag == "enemy"){
                _atack.gameObject.SetActive(false);
                  Destroy(_atack.gameObject, 0.5f);
                  gameObject.SetActive(false);
                  Destroy(gameObject, 0.1f);
                  Debug.Log("ENEMIGO ELIMINADO");
                  GameObject.Instantiate(Coin2, transform.position, transform.rotation);
                 
            }
            if(_atack.gameObject.tag == "enemy2"){
                _atack.gameObject.SetActive(false);
                  Destroy(_atack.gameObject, 0.5f);
                  gameObject.SetActive(false);
                  Destroy(gameObject, 0.1f);
                  Debug.Log("ENEMIGO ELIMINADO");
                  GameObject.Instantiate(Coin4, transform.position, transform.rotation);
                
            }
            if(_atack.gameObject.tag == "miniBoss"){
                  Destroy(gameObject, 0.1f);
                
            }
        }
}
