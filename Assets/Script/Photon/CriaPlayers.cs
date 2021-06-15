using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class CriaPlayers : MonoBehaviour
{

    void Start()
    {
        for (int i = 0; i == PhotonConnection._photonConnect.ID; i++)
        {
            PhotonNetwork.Instantiate(PhotonConnection._photonConnect._player[PhotonConnection._photonConnect.ID].name, new Vector3(Random.Range(1, 8), 2, Random.Range(1, 8)), Quaternion.identity);
        }

    }
    //    private void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.Escape))
    //        {
    //            PhotonNetwork.LoadLevel(0);
    //        }
    //    }

}
