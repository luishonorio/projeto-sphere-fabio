using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamManager : MonoBehaviour
{
    public List<CinemachineVirtualCamera> lstCam = new List<CinemachineVirtualCamera>();

    public void ChangeCam(CinemachineVirtualCamera newCam)
    {
        DisableAllCams();
        newCam.gameObject.SetActive(true);
    }

    private void DisableAllCams()
    {
        foreach(CinemachineVirtualCamera camTmp in lstCam)
        {
            camTmp.gameObject.SetActive(false);
        }
    }
}
