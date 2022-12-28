using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rndm : MonoBehaviour
{
    public Text r;
    private string[] tp=new string[] {"Meh what a small high score","Have you checked your emails","You cannot find the end of this game","Go play some other useful game","Yes I'm talking to you","What's the goal of this game?","What are you doing here?","You cant go much farther","You gonna lose any moment now","Go do some stuff instead of playing this game","Did you do your homework?","Who made this game?","Mwahahahaha"};
    public Transform p;
    // Update is called once per frame
    void Update()
    {
       int a=Random.Range(0,11);
               if(((int)p.position.z)==1)
    {
            r.text=tp[a];
    }
        if(((int)p.position.z)%40==0)
        {
            r.text=tp[a];
        }
    }
}
