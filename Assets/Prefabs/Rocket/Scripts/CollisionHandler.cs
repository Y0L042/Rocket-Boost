// using System.Collections;
// using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private AudioClip _deathAudio;
    [SerializeField] private ParticleSystem _deathParticleSystem;
    [SerializeField] private AudioClip _victoryAudio;
    [SerializeField] private ParticleSystem _victoryParticleSystem;


    private GameManager _gameManager;
    private PlayerManager _playerManager;

    private bool isTransitioning = false;

    private void Start() 
    {
        _gameManager = FindObjectOfType<GameManager>();
        _playerManager = this.GetComponent<PlayerManager>();
    }


    void OnCollisionEnter(Collision other)
    {   
        if (isTransitioning){return;}
        string tag = other.gameObject.tag;
        switch(tag)
        {
            case ("Obstacle"):
                Debug.Log("Hit obstacle");
                StartDeathSequence();
                break;
            case ("Friendly"):
                Debug.Log("Hit friendly");
                break;
            case ("Finish"):
                Debug.Log("Hit finish");
                StartVictorySequence();
                break;
            default:
                StartDeathSequence();
                break; 
        }
    }

    private void StartDeathSequence()
    {   
        // DevTool
        if (_playerManager._DT_Invincible){ return; }

        isTransitioning = true;
        StartDeathFx();
        GetComponent<Movement>().enabled = false;
        _gameManager.RestartLevel();
    }

    private void StartDeathFx()
    {
        _deathParticleSystem.Play();
        _playerManager.PlayAudio(_deathAudio);
    }


    private void StartVictorySequence()
    {
        isTransitioning = true;
        StartVictoryFx();
        _gameManager.NextLevel();
    }

    private void StartVictoryFx()
    {
        _victoryParticleSystem.Play();
        _playerManager.PlayAudio(_victoryAudio);
    }


}
