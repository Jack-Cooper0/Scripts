using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generaPlataformas : MonoBehaviour
{
    public float AppearProb;
    public GameObject plataforma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        decideSiplataforma();
    }
     private void decideSiplataforma()
    {
        float random = Random.Range(0.0f , 100.0f);
        if (random <AppearProb){
            GameObject.Instantiate(plataforma, transform.position, transform.rotation);
        }
    }
}
