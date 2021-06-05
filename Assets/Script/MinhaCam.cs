using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MinhaCam : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vcam;
    [SerializeField] private Camera cam;

    private void Awake()
    {
        Instantiate(cam);
        Instantiate(vcam);
    }
}
