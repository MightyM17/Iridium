using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colofr : MonoBehaviour {
    MeshRenderer rend;
    private Transform p;
    Color[] colors = new Color[6];
    int x = 0;
    // Start is called before the first frame update
    void Start () {
        rend = GetComponent<MeshRenderer> ();
        p = GameObject.FindGameObjectWithTag ("Player").transform;
        colors[0] = Color.blue;
        colors[1] = Color.red;
        colors[2] = Color.yellow;
        colors[3] = Color.cyan;
        colors[4] = Color.magenta;
        colors[5] = Color.green;
    }

    // Update is called once per frame
    void Update () {
        if (((int) p.position.z) % 1000 == 0)
           {x = ((int) p.position.z);}
        
        if (((int) p.position.z) >= 1000 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[6]);
            rend.material.SetColor ("_BaseColor", colors[6]);
        }
        else if (((int) p.position.z) >= 800 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[5]);
            rend.material.SetColor ("_BaseColor", colors[5]);
        }
        else if (((int) p.position.z) >= 600 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[4]);
            rend.material.SetColor ("_BaseColor", colors[4]);
        }
        else if (((int) p.position.z) >= 400 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[3]);
            rend.material.SetColor ("_BaseColor", colors[3]);
        }
        else if (((int) p.position.z) >= 200 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[2]);
            rend.material.SetColor ("_BaseColor", colors[2]);
        }
        else if (((int) p.position.z) >= 100 + x) {
            rend.material.SetColor ("Color_4338BD79", colors[1]);
            rend.material.SetColor ("_BaseColor", colors[1]);
        }
    }
}