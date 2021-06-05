using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{
    private float sort;
    private MeshRenderer mesh;
    public Material cor;
    private Move move;
    public Rigidbody rdb;
    public float cont;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        cont = 0;
        move = FindObjectOfType(typeof(Move)) as Move;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RandomSpecial()
    {
        sort = Random.Range(1, 4);
        if (sort == 1)
        {
            StartCoroutine(Stun());

        }
        else if (sort == 2)
        {
            move.contbomba++;

        }
        else if (sort == 3)
        {
            move.forçaImpulso -= 1;
            move.speed -= 1;
            move.forcaPulo -= 100;

        }
    }
    IEnumerator Stun()
    {
        float x = move.speed;
        mesh.material.color = cor.color;
        rdb.constraints = RigidbodyConstraints.FreezeAll;
        move.speed = 0;
        yield return new WaitForSeconds(3);
        rdb.constraints = RigidbodyConstraints.None;
        rdb.constraints = RigidbodyConstraints.FreezeRotation;
        mesh.material.color = Color.black;
        move.speed = x;

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Special")
        {
            RandomSpecial();
            Destroy(col.gameObject);
        }
    }
    
        
    
}
