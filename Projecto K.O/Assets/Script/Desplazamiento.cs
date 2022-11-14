using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{
    public float velocidad;
    public float FSalto;
    
    private Rigidbody2D rigidbody;
    private bool MDerecha = true;


    private void Start()
    {        
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        ProcesarM();
    }

    void ProcesarM()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);

        GOrientacion(inputMovimiento);
    }

    void GOrientacion(float inputMovimiento)
    {
        if( (MDerecha == true && inputMovimiento <0) || (MDerecha == false && inputMovimiento > 0) )
        {
            MDerecha = !MDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

}
