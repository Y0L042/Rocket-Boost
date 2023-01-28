using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class VCamFindRocket : MonoBehaviour
{   
    [SerializeField]
    private CinemachineVirtualCamera _virtualPlayerCam;

    [SerializeField]
    private PlayerObject _playerObject;

    private void Awake() 
    {
        _virtualPlayerCam = GetComponent<CinemachineVirtualCamera>();
    }
    void Start()
    {
        _playerObject = FindObjectOfType<PlayerObject>();
        _virtualPlayerCam.Follow = _playerObject.transform;
    }


}
