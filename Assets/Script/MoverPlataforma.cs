using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoverPlataforma : MonoBehaviour
{
    [SerializeField]
    private GameObject Plat;
    [SerializeField]
    private Transform[] Posicoes;
    [SerializeField]
    private Transform Destinos;
    private float Speed = 5;
    //private int sortMove;



    void Update()
    {
        float Step = Speed * Time.deltaTime;


        Plat.transform.position = Vector3.MoveTowards(Plat.transform.position, Destinos.position, Step);



        if (Plat.transform.position == Destinos.position)
        {
            Destinos.position = Posicoes[1].position;
        }
        if (Plat.transform.position == Destinos.position)
        {
            Destinos.position = Posicoes[2].position;
        }
        if (Plat.transform.position == Destinos.position)
        {
            Destinos.position = Posicoes[3].position;
        }
        if (Plat.transform.position == Destinos.position)
        {
            Destinos.position = Posicoes[0].position;
        }
    }





    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player") 
    //    {
    //        collision.gameObject.transform = gameObject.transform.parent; 
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        transform.parent = collision.gameObject.transform;
    //    }
    //}


}
