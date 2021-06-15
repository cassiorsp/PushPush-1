using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Buracos : MonoBehaviour
{
    [SerializeField]
    private GameObject[] chao, parede, bordas;
    [SerializeField]
    private Rigidbody[] rdb;
    [SerializeField]
    private Transform[] PosiVerdadeira;
    [SerializeField]
    private float fallTime;

    [SerializeField]
    private GameObject Campo;
    private int sort;
    [SerializeField]
    private int ContaPeca;

    [PunRPC]
    void Start()
    {
        ContaPeca = chao.Length;
    }

    [PunRPC]
    void Update()
    {
        ChaoCounter();
        fallTime += Time.deltaTime;

        if (fallTime >= 5.5f && chao != null)
        {
            sort = Random.Range(0, chao.Length);
            StartCoroutine(cai());
            fallTime = 0;
        }
        //else if(ContaPeca == 1)
        //{
        //    StartCoroutine(CaiParede());
        //}
        else if (fallTime >= 5.5f && chao == null)
        {
            sort = Random.Range(0, parede.Length);
            StartCoroutine(cai());
            fallTime = 0;
        }
        //else if (timer > 20 && timer < 40 && fallTime >= 2)
        //{
        //    sort = Random.Range(0, chao.Length);
        //    StartCoroutine(cai());
        //    fallTime = 0;
        //}
        //else if (timer > 40 && fallTime >= 0.7f)
        //{
        //    sort = Random.Range(0, chao.Length);
        //    StartCoroutine(cai());
        //    fallTime = 0;
        //}

    }
    [PunRPC]
    void ChaoCounter()
    {
        if (ContaPeca == 0)
        {
            chao = null;
        }
    }
    [PunRPC]
    public IEnumerator cai()
    {
        if (chao != null)
        {
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            chao[sort].GetComponent<MeshRenderer>().material.color = Color.blue;
            yield return new WaitForSeconds(0.5f);
            chao[sort].transform.localScale = new Vector3(+1f, +1f, +1f);
            PosiVerdadeira[sort] = GetComponent<Transform>();
            PosiVerdadeira[sort].position = chao[sort].transform.position;
            rdb[sort].isKinematic = false;
            rdb[sort].constraints = RigidbodyConstraints.None;
            if (chao[sort] != null)
            {
                ContaPeca -= 1;
            }
            yield return new WaitForSeconds(1);
            Destroy(chao[sort].gameObject);
        }

        if (chao == null)
        {
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.white;
            yield return new WaitForSeconds(0.5f);
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            parede[sort].GetComponent<MeshRenderer>().material.color = Color.blue;
            yield return new WaitForSeconds(0.5f);
            parede[sort].transform.localScale = new Vector3(+1f, +1f, +1f);
            PosiVerdadeira[sort] = GetComponent<Transform>();
            PosiVerdadeira[sort].position = parede[sort].transform.position;
            rdb[sort].isKinematic = false;
            rdb[sort].constraints = RigidbodyConstraints.None;
            yield return new WaitForSeconds(1);
            Destroy(parede[sort].gameObject);
        }
    }
   //public IEnumerator CaiParede()
   // {
   //     for (int tet = 0; tet == bordas.Length; tet++)
   //     {
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.red;
   //         yield return new WaitForSeconds(0.5f);
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.white;
   //         yield return new WaitForSeconds(0.5f);
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.red;
   //         yield return new WaitForSeconds(0.5f);
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.white;
   //         yield return new WaitForSeconds(0.5f);
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.red;
   //         yield return new WaitForSeconds(0.5f);
   //         bordas[tet].GetComponent<MeshRenderer>().material.color = Color.blue;
   //         yield return new WaitForSeconds(0.5f);
   //         rdb[sort].isKinematic = false;
   //         rdb[sort].constraints = RigidbodyConstraints.None;
   //     }
   // }
}
