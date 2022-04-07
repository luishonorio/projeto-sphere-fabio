using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager INSTANCE;

    private void Awake()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    public CamManager camManager;
    public Player player;

    public void ChangeCam(CinemachineVirtualCamera cam)
    {
        camManager.ChangeCam(cam);
    }
}
