using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vento : MonoBehaviour
{
    public static bool Go;


    private void OnCollisionStay(Collision collision)
    {
        if (Vento1.Ativo == true)
        {

            if (collision.gameObject.tag == "Player")
            {
                print("Pegou");
                Physics.gravity = new Vector3(-2, -9, 0);
            }
        }

        else 
        {
            if (collision.gameObject.tag == "Player")
            {
                print("Saiu");
                Physics.gravity = new Vector3(0, -9, 0);
            }
        }
    }
}
