using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private float _restartDelay = 3f;
    [SerializeField]
    private float _cameraIntroDelay = 0.5f;
    
    private CinemachineSwitcher _cinemachineSwitcher;

    private void Start() 
    {
        _cinemachineSwitcher = FindObjectOfType<CinemachineSwitcher>();    
        _cinemachineSwitcher.StartIntroCameraSequence(_cameraIntroDelay);
    }


	public void RestartLevel()
    {
        Debug.Log("game over");
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(LoadLevelRoutine(currentSceneIndex, _restartDelay));
    }

    public void NextLevel()
    {
        Debug.Log("next level");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex+1;
        if (nextSceneIndex ==  SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        StartCoroutine(LoadLevelRoutine(nextSceneIndex, _restartDelay));
    }

    IEnumerator LoadLevelRoutine(int levelIndex, float delay)
    {
        Debug.Log("LoadLevelRoutine");
        yield return new WaitForSeconds(delay);
        LoadLevel(levelIndex);
    }


    private void LoadLevel(int levelIndex)
    {
        Debug.Log("Loading level: " + levelIndex);
        SceneManager.LoadScene(levelIndex);
    }

    private void OnEscape(InputValue value) => Application.Quit();

}
