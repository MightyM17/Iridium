using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timer : MonoBehaviour
{
    float time;
    public Text txt;
    public Animator transition;
    public Transform p;
    public int endpoint,endtime;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        t=endtime;
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        //float t=endtime - Time.time;
        string min = ((int)t/60).ToString();
        int s = ((int) t%60);
        if(t<=endtime-3)
        txt.text=min+" : "+s.ToString();
        if(p.position.z>=endpoint)
        {
            Scene("Win");
        }
        if(s<1)
        {
           Scene("Lose");
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
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            t--;
        }
    }
}
