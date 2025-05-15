using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public GameObject[] fondos;
    public float[] velocidadFondos;
    public float[] tamaños;
    public Renderer[] olas;
    public float[] velocidadola;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mueveolas();
         muevefondos();
    }
    private void mueveolas(){
        for (int i = 0; i < olas.Length; i++)
        {
              float offset = Time.time * velocidadola[i];
        olas[i].material.SetTextureOffset("_MainTex", new Vector2(offset, 0.0f));
        }

    }
    private void muevefondos(){
        for (int i = 0; i < fondos.Length; i++)
        {
            if(Mathf.Abs(fondos[i].transform.localPosition.x) >= tamaños[i]){
                //regresa el fondo a su posición inicial
                fondos[i].transform.localPosition = new Vector3(0.0f, fondos[i].transform.localPosition.y,
                 fondos[i].transform.localPosition.z);
            }
            else
            {
                //mueve el fondo
                float offset = Time.deltaTime * velocidadFondos[i];
                fondos[i].transform.localPosition += new Vector3(offset, 0.0f);
            }
        }
    }
}
