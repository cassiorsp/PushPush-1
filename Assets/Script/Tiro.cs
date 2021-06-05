using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    
    private Rigidbody rdb;
    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody>();
        rdb.AddRelativeForce(new Vector3(0,300,700));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "chao" || col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}

