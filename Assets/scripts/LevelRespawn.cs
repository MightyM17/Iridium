using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRespawn : MonoBehaviour {
    public Animator transition;
    public Transform plyr;
    bool gameEnd = false;
    public Vector3 spawn;

    public void EndGame () 
    {
        if (gameEnd == false) 
        {
            gameEnd = true;
            StartCoroutine (Respawn ());
        }

    }
    IEnumerator Respawn () 
    {
        transition.SetTrigger ("end");
        yield return new WaitForSeconds (1f);
        plyr.position=spawn;
    }
}