using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryNextlevel : MonoBehaviour
{
    public static int i;
    void Start()
    {
        i= SceneManager.GetActiveScene().buildIndex;
    }
    
}
