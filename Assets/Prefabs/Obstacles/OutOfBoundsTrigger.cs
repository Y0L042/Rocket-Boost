using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsTrigger : MonoBehaviour
{
    private GameManager _gameManager;
    private PlayerObject _playerObject;


    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();  
        _playerObject = FindObjectOfType<PlayerObject>();  
    }


    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            _gameManager.RestartLevel();
        }
    }
}
