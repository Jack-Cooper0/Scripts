using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text vidas_txt;
    public Text monedas_txt;
    public Text Record_txt;
    public Text Actual_txt;
    public Personaje pj;
    public GameObject GameOver_pn;
    // Start is called before the first frame update
    void Start()
    {
        GameOver_pn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        vidas_txt.text = "X" + pj.Vidas.ToString();
        monedas_txt.text = pj.Monedas.ToString() + "X";
        if (pj.Vidas <= 0 && GameOver_pn.activeSelf == false)
        {
            GameOver_pn.SetActive(true);
            Record_txt.text = PlayerPrefs.GetInt("Monedas").ToString();
            Actual_txt.text = pj.Monedas.ToString();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
}
