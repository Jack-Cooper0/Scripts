using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMiniBoss : MonoBehaviour
{
   public GameObject Vida1;
 public float vel;
 private int vidas;
    // Start is called before the first frame update
    void Start()
    {
       vidas = 5; 
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector3(vel, 0.0f)); 

    }
    void OnCollisionEnter2D(Collision2D _col)
    {
        if(_col.gameObject.tag=="atack"){
            vidas--;
            Debug.Log("Vidas de Mini Boss:" + vidas);
            if(vidas==0){
                gameObject.SetActive(false);
                Destroy(gameObject, 0.5f);
                GameObject.Instantiate(Vida1, transform.position, transform.rotation);
            }
        }
    }
}
