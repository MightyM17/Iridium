using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redc : MonoBehaviour
{
    MeshRenderer rend;
    // Start is called before the first frame update
    void Start () {
        rend = GetComponent<MeshRenderer> ();
    }

    // Update is called once per frame
    void Update () {
        rend.material.SetColor ("Color_4338BD79", Color.red);
        rend.material.SetColor ("_BaseColor", Color.red);
    }
}
