using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject cam;
    public static float pcmove,andmove;
    float swidth;
    // Start is called before the first frame update
    void Start()
   {
       swidth=Screen.width/2;
       pcmove=2*movement.sideforce;
       andmove=(4/3)*movement.sideforce; 
   }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("d"))
        {
            cam.transform.Rotate(0f,0f,Time.deltaTime * pcmove, Space.Self);
        }
        if(Input.GetKeyDown("a"))
        {
            cam.transform.Rotate(0f,0f,Time.deltaTime * -pcmove, Space.Self);
        }
        if(Input.touchCount>0)
        {
            Touch t=Input.GetTouch(0);
            if(t.position.x>swidth)
            {
                cam.transform.Rotate(0f,0f,Time.deltaTime * andmove, Space.Self);
            }
            else if(t.position.x<swidth)
            {
                cam.transform.Rotate(0f,0f,Time.deltaTime * -andmove, Space.Self);
            }
        }
    }
}
