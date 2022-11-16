using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cura : MonoBehaviour
{
    public int CuraV;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player.GetComponent<Vida>().vida += CuraV;
            Destroy(this.gameObject);
        }

    }
}
