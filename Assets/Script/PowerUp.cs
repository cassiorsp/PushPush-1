using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Move move;
    public int powerUpID;
    

    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType(typeof(Move)) as Move;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                if (powerUpID == 1)
                {
                    move.forçaImpulso++;
                    Destroy(gameObject);
                }
                else if (powerUpID == 2)
                {
                    move.GrowUp();
                    Destroy(gameObject);

                }
                else if (powerUpID == 3)
                {
                    move.limitePowerUpSpeed++;
                    if (move.limitePowerUpSpeed <= 3)
                    {
                        move.speed++;
                    }
                    Destroy(gameObject);

                }
                break;

        }
    }
}
