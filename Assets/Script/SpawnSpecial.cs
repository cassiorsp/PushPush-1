using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpecial : MonoBehaviour
{
    public GameObject special;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 20)
        {
            StartCoroutine(Spawn());
            timer = 0;
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Instantiate(special, new Vector3(Random.Range(-1.30f, 30f), 2.35F, Random.Range(-1.10f, 35f)), Quaternion.identity);
        Instantiate(special, new Vector3(Random.Range(31f, 55f), 2.35F, Random.Range(-1.10f, 35f)), Quaternion.identity);
        
    }
}
