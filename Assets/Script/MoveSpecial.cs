using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpecial : MonoBehaviour
{
    [SerializeField] private float speedx, speedz;
    private int wall;
    public float speedRotation;
    void Start()
    {
        
        Destroy(gameObject,10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedRotation* Time.deltaTime,0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,transform.position.x, transform.position.x), Mathf.Clamp(transform.position.y, 2f, 5f), Mathf.Clamp(transform.position.z, transform.position.z, transform.position.z));
    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(speedx * Time.deltaTime, 0, speedz * Time.deltaTime));
       
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "chao")
        {
            if (speedz != 0)
            {
                speedz = 0;
                wall = Random.Range(0, 2);

                if (wall == 0)
                    speedx = 10;
                else if (wall == 1)
                    speedx = -10;


            }
            else if (speedx != 0)
            {
                speedx = 0;
                wall = Random.Range(0, 2);

                if (wall == 0)
                    speedz = 10;
                else if (wall == 1)
                    speedz = -10;
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            if (speedx < 0)
            {
                StartCoroutine(Moverz());
            }
            else if (speedx > 0)
            {
                StartCoroutine(MoverzN());
            }
            if (speedz < 0)
            {
                StartCoroutine(Moverx());
            }
            else if (speedz > 0)
            {
                StartCoroutine(MoverxN());
            }

        }
    }
    IEnumerator Moverz()
    {
        yield return new WaitForSeconds(3);
        speedx = 0;
        speedz = 10;
    }
    IEnumerator MoverzN()
    {
        yield return new WaitForSeconds(3);
        speedx = 0;
        speedz = -10;
    }
    IEnumerator Moverx()
    {
        yield return new WaitForSeconds(3);
        speedz = 0;
        speedx = 10;
    }
    IEnumerator MoverxN()
    {
        yield return new WaitForSeconds(3);
        speedz = 0;
        speedx = -10;
    }
}
    //SPAWN SPECIAL
    

