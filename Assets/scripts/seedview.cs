using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class seedview : MonoBehaviour
{
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        t.text="Seed : "+(roadmaker.seedv).ToString("f0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
