using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlunlock : MonoBehaviour
{
    int levels=0;
    public GameObject b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11;
    // Start is called before the first frame update
    void Start()
    {
        levels=REtrynextlevelgetit.x;
        if(levels==0)
        {
            b1.SetActive(true);
        }
        if(levels>=14)
        {
            b1.SetActive(true);
            b2.SetActive(true);
        }
        if(levels>=15)
        {
            b1.SetActive(true);
            b2.SetActive(true);
        }
        if(levels>=16)
        {
           b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
        }
        if(levels>=17)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
        }
        if(levels>=18)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
        }if(levels>=19)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
        }
        if(levels>=20)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
            b7.SetActive(true);
        }
        if(levels>=21)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
            b7.SetActive(true);
            b8.SetActive(true);
        }
        if(levels>=22)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
            b7.SetActive(true);
            b8.SetActive(true);
            b9.SetActive(true);
        }
        if(levels>=23)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
            b7.SetActive(true);
            b8.SetActive(true);
            b9.SetActive(true);
            b10.SetActive(true);
           // b11.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
