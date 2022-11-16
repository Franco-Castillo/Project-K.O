using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public int vida;
    public Slider barraVida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        barraVida.GetComponent<Slider>().value = vida; 

        if ( vida <=0)
        {
            SceneManager.LoadScene("Derrota");
        }        
    }
}
