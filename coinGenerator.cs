using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGenerator : MonoBehaviour
{
    public float AppearProb;
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        decideSiCoin();
    }
    private void decideSiCoin()
    {
        float random = Random.Range(0.0f , 100.0f);
        if (random <AppearProb){
            GameObject.Instantiate(Coin, transform.position, transform.rotation);
        }
    }
}
