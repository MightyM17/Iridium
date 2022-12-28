using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Animator transition;
    bool gameEnd = false;
    public float delay = 0.25f;

    public void EndGame () 
    {
        if (gameEnd == false) 
        {
            gameEnd = true;
            StartCoroutine (LoadScene ());
        }

    }
    IEnumerator LoadScene () 
    {
        transition.SetTrigger ("end");
        yield return new WaitForSeconds (1.5f);
        SceneManager.LoadScene("Endscene");
    }
}