using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private bool jumping;
    private bool atacking;
    private bool moviendoderecha;
    private bool moviendoizquierda;
    public GameObject atack;
    public GameObject atack_position;
    private int vidas;
    public int Vidas
    {
        get { return vidas; }
        set { vidas = value; }
    }
    private int coinsRecord;
    public int Monedas
    {
        get { return coinsRecord; }
        set { coinsRecord = value; }
    }
    private int coins;
    public Animator animator;
    public AudioClip salto_clip;
    
    public AudioClip hit_clip;
    private AudioSource personaje_AS;

    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        coinsRecord = 0;
        coins = 0;
        personaje_AS = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || moviendoizquierda == true)
        {
            transform.Translate(new Vector3(-0.05f, 0.0f));
            animator.SetBool("corriendo", true);
          

        }
        else
 if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || moviendoderecha == true)
        {
            transform.Translate(new Vector3(0.05f, 0.0f));
            animator.SetBool("corriendo", true);
   
        
        }
        else
        {
            animator.SetBool("corriendo", false);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            saltar();
            personaje_AS.clip = salto_clip;
            personaje_AS.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            atacar();

        }

    }
    private void finishAtack()
    {
        atacking = false;
    }
    void OnCollisionEnter2D(Collision2D _col)
    {
        if (_col.gameObject.tag == "Floor")
        {

            jumping = false;
            animator.SetBool("saltando", jumping);
        }
        if (_col.gameObject.tag == "enemy")
        {

            vidas--;
            Debug.Log("Vidas:" + vidas);
            _col.gameObject.SetActive(false);

            Destroy(_col.gameObject, 0.5f);

            animator.SetTrigger("daño");
            personaje_AS.clip = hit_clip;
            personaje_AS.Play();
        }

        if (_col.gameObject.tag == "enemy2")
        {

            vidas--;
            Debug.Log("Vidas:" + vidas);
            _col.gameObject.SetActive(false);
            Destroy(_col.gameObject, 0.5f);
            animator.SetTrigger("daño");
               personaje_AS.clip = hit_clip;
            personaje_AS.Play();
        }
        if (_col.gameObject.tag == "miniBoss")
        {

            vidas = vidas - 2;
            Debug.Log("Vidas:" + vidas);
            animator.SetTrigger("daño");
               personaje_AS.clip = hit_clip;
            personaje_AS.Play();
        }
        if (vidas <= 0)
        {
            Debug.Log("EL JUGADOR HA SIDO ELIMINADO");
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
            int RecordUltimo = PlayerPrefs.GetInt("Monedas");
            if (!PlayerPrefs.HasKey("Monedas"))
            {
                //SI NO TIENE RECORD
                PlayerPrefs.SetInt("Monedas", coinsRecord);
                Debug.Log("Nuevo Record!!!:" + coinsRecord);
            }
            else
            {
                //SI TIENE RECORD
                if (RecordUltimo < coinsRecord)
                {
                    PlayerPrefs.SetInt("Monedas", coinsRecord);
                    Debug.Log("Nuevo Record!!!:" + coinsRecord);
                }
                if (RecordUltimo > coins)
                {
                    Debug.Log("Record:" + RecordUltimo);
                    Debug.Log("Recogidas:" + coinsRecord);
                }

            }

        }
    }

    void OnTriggerEnter2D(Collider2D _col)
    {
        if (_col.gameObject.tag == "grabable")
        {
            _col.gameObject.SetActive(false);
            Destroy(_col.gameObject, 0.5f);
            coinsRecord++;
            coins++;
            Debug.Log("Has recogido una moneda");
            Debug.Log("Monedas:" + coinsRecord);

        }
        if (_col.gameObject.tag == "grabableX2")
        {
            _col.gameObject.SetActive(false);
            Destroy(_col.gameObject, 0.5f);
            coinsRecord = coinsRecord + 2;
            coins = coins + 2;
            Debug.Log("Has recogido 2 monedas");
            Debug.Log("Monedas:" + coinsRecord);

        }
        if (_col.gameObject.tag == "grabableX4")
        {
            _col.gameObject.SetActive(false);
            Destroy(_col.gameObject, 0.5f);
            coinsRecord = coinsRecord + 4;
            coins = coins + 4;
            Debug.Log("Has recogido 4 monedas");
            Debug.Log("Monedas:" + coinsRecord);

        }
        if (coins >= 30)
        {
            vidas++;
            Debug.Log("Has conseguido una vida extra");
            Debug.Log("Vidas:" + vidas);
            coins = 0;
        }
        if (_col.gameObject.tag == "salud")
        {
            _col.gameObject.SetActive(false);
            Destroy(_col.gameObject, 0.5f);
            vidas++;
            Debug.Log("Has recogido 1 vida");
            Debug.Log("Vidas:" + vidas);


        }
    }
    public void saltar()
    {
        if (jumping == false)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 360.0f));

            jumping = true;
            animator.SetBool("saltando", jumping);
        }
    }
    public void atacar()
    {
        if (atacking == false)
        {
            GameObject.Instantiate(atack, atack_position.transform.position, atack_position.transform.rotation);
            atacking = true;
            animator.SetTrigger("atacando");
            Invoke("finishAtack", 0.5f);
        }
    }
    public void moverDerecha(bool _activar)
    {
        moviendoderecha = _activar;
    }
   
       public void moverizquierda(bool _activar)
    {
        moviendoizquierda = _activar;
    } 
     }




