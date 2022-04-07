using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerCam : MonoBehaviour
{
    MeshRenderer renderer;

    public CinemachineVirtualCamera cam;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }
}
