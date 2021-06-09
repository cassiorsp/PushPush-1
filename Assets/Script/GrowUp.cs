using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowUp : MonoBehaviour
{
    public float speedY, speedX;
    public bool Platforma;

    void Start()
    {

    }


    void Update()
    {
        speedY += 0.001f;

        if (Platforma == true)
        {
            if (Vento1.Ativo == true && transform.localScale.x <= 20)
            {
                speedX += Time.deltaTime;
                transform.localScale = new Vector3(0 + speedX, 0.01f, 1);
            }
            else if (Vento1.Ativo == false && transform.localScale.x > 0)
            {
                speedX -= Time.deltaTime;
                transform.localScale = new Vector3(0 + speedX, 0.01f, 1);
            }
        }


        else if (Platforma == false && transform.localScale.y < 10)
        {
            transform.localScale = new Vector3(0.1f, 0 + speedY, 2);
        }
    }

}
