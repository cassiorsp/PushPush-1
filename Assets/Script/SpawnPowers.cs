using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax, zMin, zMax;
}
public class SpawnPowers : MonoBehaviour
{
    [SerializeField] private GameObject[] powers;
    private bool spawn;

    public Boundary boundary;
    void Start()
    {
        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true)
            StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        spawn = false;
        yield return new WaitForSeconds(10);
        Instantiate(powers[Random.Range(0, powers.Length)], new Vector3(Random.Range(boundary.xMin, boundary.xMax), Random.Range(boundary.yMin, boundary.yMax), Random.Range(boundary.zMin, boundary.zMax)), Quaternion.identity);
        yield return new WaitForSeconds(1);
        spawn = true;
    }
    //-2.3f, 55.8f
    //1f, 8f
    //-2f, 36f
}
