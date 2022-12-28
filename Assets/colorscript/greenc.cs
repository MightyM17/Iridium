using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenc : MonoBehaviour
{
    MeshRenderer rend;
    // Start is called before the first frame update
    void Start () {
        rend = GetComponent<MeshRenderer> ();
    }

    // Update is called once per frame
    void Update () {
            rend.material.SetColor ("_BaseColor", Color.green);
    }
}
