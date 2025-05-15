using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesfloor : MonoBehaviour
{
    public float speed;
    public float TamSuelo;
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distancia = mainCamera.transform.position - transform.position; 
        if(TamSuelo <=distancia.magnitude)
    {
        transform.position = new Vector3(mainCamera.transform.position.x, transform.position.y, transform.position.z);
    }
    }
}
