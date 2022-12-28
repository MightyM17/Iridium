using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneanim : MonoBehaviour
{
    public Animator transition;
    // Update is called once per frame
    public void Scene(string sceneNamee)
    {
        StartCoroutine(LoadScene(sceneNamee));
    }
    IEnumerator LoadScene(string sceneName)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    } 

    public void SceneNumberChange()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex+1));
    }
    IEnumerator LoadScene(int x)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(x);
    } 
}
