using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    public Transform freelook;
    public float force;
    public float forceJump;

    Rigidbody rb;
    float hor;
    float ver;
    Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * forceJump);
        }
    }

    private void FixedUpdate()
    {
        Vector3 camFoward = transform.position - freelook.position;
        camFoward = new Vector3(camFoward.x, 0, camFoward.z).normalized;
        Vector3 camRight = Vector3.Cross(Vector3.up, camFoward).normalized;

        direction = camFoward * ver + camRight * hor; 
        rb.AddForce(direction * force);
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerCam tmpTriggerCam;

        if (other.TryGetComponent<TriggerCam>(out tmpTriggerCam))
        {
            GameManager.INSTANCE.ChangeCam(tmpTriggerCam.cam);
        }



        /*if (other.CompareTag("Trigger"))
        {
            CinemachineVirtualCamera tmpCam = other.GetComponent<TriggerCam>().cam;
            GameManager.INSTANCE.ChangeCam(tmpCam);
        }*/
    }
}
