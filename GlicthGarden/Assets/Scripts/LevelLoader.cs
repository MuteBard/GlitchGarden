using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadDelay;
    [SerializeField] int currentSceneIndex;
    void Start()
    {
        LoadStartScreen();
    }

    void LoadStartScreen(){
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0){
            StartCoroutine(LoadNextWithDelay());
        }
    }
    void LoadNextScreen(){
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    IEnumerator LoadNextWithDelay(){
        yield return new WaitForSeconds(loadDelay);
        SceneManager.LoadScene(currentSceneIndex + 1);   
    }
}
