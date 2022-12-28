using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public GameObject cam;
    public static float pcmove,andmove;
    float swidth;
    // Start is called before the first frame update
    void Start()
   {
       swidth=Screen.width/2;
       pcmove=3*movement.sideforce;
       andmove=movement.sideforce; 
   }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cam.transform.rotation.eulerAngles.z);
        
        if((cam.transform.rotation.eulerAngles.z<=45&&cam.transform.rotation.eulerAngles.z>=0)||(cam.transform.rotation.eulerAngles.z<=360&&cam.transform.rotation.eulerAngles.z>=315))
        {
        if(Input.GetKeyDown("d")||Input.GetKey(KeyCode.RightArrow))
        {
            cam.transform.Rotate(0f,0f,Time.deltaTime * 45.0f, Space.Self);
        }
        if(Input.GetKeyDown("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            cam.transform.Rotate(0f,0f,Time.deltaTime * -45.0f, Space.Self);
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
}
