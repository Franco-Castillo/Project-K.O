using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazamiento : MonoBehaviour
{
    public float velocidad;
    public float FSalto;
    
    private Rigidbody2D rigidbody;
    private bool MDerecha = true;
    private Animator animator;


    private void Start()
    {        
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        ProcesarM();
        ProcesarS();
    }

    void ProcesarM()
    {

        float inputMovimiento = Input.GetAxis("Horizontal");

        if(inputMovimiento != 0f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        rigidbody.velocity = new Vector2(inputMovimiento * velocidad, rigidbody.velocity.y);
        
        GOrientacion(inputMovimiento);
    }

    void ProcesarS()
    {
        if(Input.GetKeyDown (KeyCode.Space) )
        {
            rigidbody.AddForce (Vector2.up * FSalto, ForceMode2D.Impulse);
        }
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
