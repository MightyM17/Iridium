using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
   // GameObject plyr;
    public Transform p,e;
    public int endpoint;
    float pt,et,strt;
    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        strt=Time.time;
    }
    void Update()
    {
         GameObject plyr,enemy;
        if(p.position.z>=endpoint)
        {
           // plyr.GetComponent<movement1>().forforce=0;
            //plyr.GetComponent<movement1>().sideforce=0;
            pt=strt-Time.time;
        }
        if(e.position.z>=endpoint)
        {
            et=strt-Time.time;
        }
        if(pt<et)
        Scene("Win");
        if(et<pt)
        Scene("Lose");
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
