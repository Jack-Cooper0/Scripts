using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroyplatform",10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Destroyplatform(){
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
