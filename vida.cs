using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestructionHealt",5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestruictionHealt(){
Destroy(gameObject);
    }
}
