using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private AudioSource _as;
    private GameManager _gameManager;

    private void Awake() 
    {
        _as = this.GetComponent<AudioSource>();
    }

    private void Start() 
    {
        _gameManager = FindObjectOfType<GameManager>();    
    }

    public bool PlayAudio(AudioClip audioClip, bool play = true, float volumeScale = 1)
    {
        bool isAudioPlaying = _as.isPlaying && _as.clip == audioClip;
        if (!isAudioPlaying && play)
        {
            // _as.PlayOneShot(audioClip, volumeScale);
        }
        
        if (isAudioPlaying && !play)
        {
            _as.Stop();
        }

        return isAudioPlaying;
    }


    // DevTools

    [SerializeField] public bool _enableDevTools = true;

    private void FixedUpdate() 
    {
        if (_DT_NextLevel){ _gameManager.NextLevel(); }
        if (_DT_RestartLevel){ _gameManager.RestartLevel(); }
        if (_DT_Invincible_isPressed){ _DT_Invincible = !_DT_Invincible; }
        if (_DT_Reset_Spaceship)
        {
            Rigidbody _rb = this.GetComponent<Rigidbody>();    
            _rb.freezeRotation = true;
            _rb.rotation = Quaternion.identity;
            _rb.angularVelocity = Vector3.zero;
            _rb.freezeRotation = false;
            _DT_Reset_Spaceship = false;
        }
    }

    // DevTools
    [SerializeField] public bool _DT_NextLevel = false;
    private void OnDT_NextLevel(InputValue value)
    {
        _DT_NextLevel = value.isPressed;
    }

    [SerializeField] public bool _DT_RestartLevel {get; private set;} = false;
    private void OnDT_RestartLevel(InputValue value)
    {
        _DT_RestartLevel = value.isPressed;
    }


    [SerializeField] public bool _DT_Invincible = false;
    private bool _DT_Invincible_isPressed = false;
    private void OnDT_Invincible(InputValue value)
    {
        _DT_Invincible_isPressed = true;
    }

    [SerializeField] private bool _DT_Reset_Spaceship = false;
    private void OnDT_ResetSpaceship(InputValue value)
    {
        _DT_Reset_Spaceship = true;
    }

}
