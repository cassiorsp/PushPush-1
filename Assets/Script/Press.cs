using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
    private Vento1 vento;
    void Start()
    {
        vento = FindObjectOfType(typeof(Vento1)) as Vento1;
    }

    
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            vento.Wind = true;
        }
    }
}
