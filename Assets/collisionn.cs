using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionn : MonoBehaviour
{
    public Animator transition;
    public movement m;
    void OnCollisionEnter(Collision other) 
    {
        if(other.collider.tag=="Obstacle")
        {
            m.enabled = false;
            Scene("Endscene");
        }   
    }
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
}
