using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private bool Roda, ventila;
    [SerializeField]
    private GameObject[] Placa;
    [SerializeField]
    private int count;
    public float Rodando;
    [SerializeField]
    private float Timer;
    private float Speed;
    private bool Ok;

    void Start()
    {
        Ok = true;
    }


    void Update()
    {
        
        
        Timer += Time.deltaTime;
        if (Roda == false)
        {
            transform.Rotate(new Vector3(0, Rodando * Time.deltaTime, 0));
        }
        else if (Roda == true)
        {
            Speed = 0.04f;

            //LEVANTA
            if (Ok && Timer > 10)
            {
                if (Placa[0].transform.rotation.x <= 0.20f)
                {
                    Placa[0].transform.Rotate(new Vector3(Speed, 0, 0));
                }

                else
                {
                    Placa[0].transform.Rotate(new Vector3(0, 0, 0));
                }

                if (Placa[0].transform.rotation.x >= 0.20f)
                {
                    if (Placa[1].transform.rotation.x >= -0.20f)
                    {
                        Placa[1].transform.Rotate(new Vector3(-Speed, 0, 0));
                    }
                    else
                    {
                        Placa[1].transform.Rotate(new Vector3(0, 0, 0));
                    }
                }
                if (Placa[0].transform.rotation.x >= 0.20f && Placa[1].transform.rotation.x <= -0.20f)
                {
                    Ok = false;
                    Timer = 0;
                }

            }

            //ABAIXA

            else if (!Ok)
            {
                if (Placa[0].transform.rotation.x >= 0)
                {
                    Placa[0].transform.Rotate(new Vector3(-Speed, 0, 0));
                }
                else
                {
                    Placa[0].transform.Rotate(new Vector3(0, 0, 0));
                }
                if (Placa[0].transform.rotation.x <= 0)
                {
                    if (Placa[1].transform.rotation.x <= 0)
                    {
                        Placa[1].transform.Rotate(new Vector3(Speed, 0, 0));
                    }
                    else
                    {
                        Placa[1].transform.Rotate(new Vector3(0, 0, 0));
                    }
                }

                if (Placa[0].transform.rotation.x <= 0 && Placa[1].transform.rotation.x >= 0)
                {
                    Ok = true;
                }
            }

        }
        Timer += Time.deltaTime;
    }

    public void Ventilador()
    {
        
    }
    //IEnumerator Rodando()
    //{
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.white;
    //    yield return new WaitForSeconds(0.5f);
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.white;
    //    yield return new WaitForSeconds(0.5f);
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.red;
    //    yield return new WaitForSeconds(0.5f);
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.white;
    //    yield return new WaitForSeconds(0.5f);
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.red;
    //    yield return new WaitForSeconds(0.5f);
    //    Placa[sort].GetComponent<MeshRenderer>().material.color = Color.blue;
    //    yield return new WaitForSeconds(0.5f);

    //    yield return new WaitForSeconds(10);
    //}
}
