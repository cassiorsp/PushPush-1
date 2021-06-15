using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;



public class Explosão : MonoBehaviour
{
    public float radius;
    public float explosionFocer;
    public float explosionRadius;
    public GameObject Bolinha2;
    public GameObject Bolinha;
    //void Start()
    //{

    //}

    //void Update()
    //{

    //}

    [PunRPC]
    private void OnCollisionEnter()
    {
        Explode();
    }

    [PunRPC]
    void Explode()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);

        for (int i = 0; i <= 100; i++)
        {
            Vector3 pos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
            Instantiate(Bolinha, pos, Quaternion.Euler(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100)));
            Instantiate(Bolinha2, pos, Quaternion.Euler(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100)));
        }
        foreach (Collider hit in hitColliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionFocer, transform.localPosition, explosionRadius, 3.0f, ForceMode.Impulse);

            }
        }

        Destroy(this.gameObject);
    }
}
