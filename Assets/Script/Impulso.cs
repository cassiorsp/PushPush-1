using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    private Rigidbody rdb;
    private Move move;
    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType(typeof(Move)) as Move;
        rdb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && move.impulse == true)
        {
            rdb.AddRelativeForce(Vector3.forward * move.forçaImpulso * move.speed, ForceMode.Impulse);
        }
    }
    
        
    
}
