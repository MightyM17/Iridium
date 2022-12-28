using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    Text s;
    public static int coinearn=0;
    // Start is called before the first frame update
    void Start()
    {
        s=GameObject.FindGameObjectWithTag("coins").GetComponent<Text>();
        s.text=PlayerPrefs.GetInt("coin").ToString();
        coinearn=PlayerPrefs.GetInt("coin");
    }

    void Update()
    {
        Debug.Log(coinearn);
        PlayerPrefs.SetInt("coin",coinearn);
        s.text=coinearn.ToString();
    }

   /* void OnTriggerEnter(Collider other) 
    {
        if(other.name=="plyr")
       { 
            coinearn=coinearn+1;
            Debug.Log(coinearn);
            //PlayerPrefs.SetInt("coin",coinearn);
            s.text=coinearn.ToString();
            Destroy(gameObject);
       }
    }*/
}
