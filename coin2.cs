using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyCoin", 10f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyCoin(){
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
