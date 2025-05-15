using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyCoin", 10f); 
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(new Vector3(vel, 0.0f));
    }
    void DestroyCoin(){
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
   
}
