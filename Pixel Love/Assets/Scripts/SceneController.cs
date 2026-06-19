using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    private void Update()
    {
        
         if (Input.GetMouseButtonDown(0))
            {
                LoadNextScene();
            }
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(0));
       
    }

    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
