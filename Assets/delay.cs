using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayrev : MonoBehaviour
{
    public movement1rev move1rev;
    
    // Start is called before the first frame update
    void Start()
    {
        move1rev.enabled=false;
        StartCoroutine(begin());
    }

    IEnumerator begin()
    {
        yield return new WaitForSeconds(3.1f);
        move1rev.enabled=true;
    } 
}
