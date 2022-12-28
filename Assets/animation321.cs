using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation321 : MonoBehaviour
{
    public Animator a;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(animation());
    }
    IEnumerator animation()
    {
        yield return new WaitForSeconds(3f);
        a.enabled=false;
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
