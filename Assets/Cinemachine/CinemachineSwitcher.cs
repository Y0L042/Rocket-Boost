using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CinemachineSwitcher : MonoBehaviour
{
    private GameManager _gameManager;
    private Animator _animator;
    
    [SerializeField]
    private string _levelCameraState = "LevelCamera";
    [SerializeField]
    private CinemachineVirtualCamera _levelCamera;
    [SerializeField]
    private string _playerCameraState = "PlayerCamera";
    [SerializeField]
    private CinemachineVirtualCamera _playerCamera;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }



    public void StartIntroCameraSequence(float delay = 0f)
    {
        SwitchCameraState(_levelCameraState);
        StartCoroutine(SwitchCameraDelayRoutine(_playerCameraState, delay));
    }



    IEnumerator SwitchCameraDelayRoutine(string newCameraState, float delay)
    {
        yield return new WaitForSeconds(delay);
        SwitchCameraState(newCameraState);
    }


    private void SwitchCameraState(string newCameraState)
    {
        _animator.Play(newCameraState);
    }
}
