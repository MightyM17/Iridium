using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REtrynextlevelgetit : MonoBehaviour
{
    public Animator transition;
    int c=RetryNextlevel.i;
    public static int x;
    void Start()
    {
        x=c;
    }
    public void Retry()
    {
        Scene(c);
    }
    public void NextLvl()
    {
        Scene(c+1);
    }
    void Scene(int a)
    {
        StartCoroutine(LoadScene(a));
    }
    IEnumerator LoadScene(int s)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(s);
    } 
}
