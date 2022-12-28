using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercolorchange : MonoBehaviour
{
    public GameObject otherobj;
    // Start is called before the first frame update
    public void Red()
    {
        otherobj.GetComponent<redc>().enabled = true;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
