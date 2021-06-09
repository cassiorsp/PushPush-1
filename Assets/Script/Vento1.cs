using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vento1 : MonoBehaviour
{
    public bool Wind;
    public static bool Ativo;
    void Start()
    {
        Wind = false;
    }

    void Update()
    {
        Ativo = Wind;

        if (Wind == true)
        {
            StartCoroutine(Ventilador());
        }
        else
        {
           
            transform.Rotate(new Vector3(0, 0, 0));
            StopAllCoroutines();
        }
    }

    IEnumerator Ventilador()
    {
        transform.Rotate(new Vector3(3, 0, 0));
        yield return new WaitForSeconds(30);
        Wind = false;

    }
}
