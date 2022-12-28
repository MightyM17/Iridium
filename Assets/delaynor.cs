using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaynor : MonoBehaviour
{
    public movement1 move1;
    
    // Start is called before the first frame update
    void Start()
    {
        move1.enabled=false;
        StartCoroutine(begin());
    }

    IEnumerator begin()
    {
        yield return new WaitForSeconds(3.1f);
        move1.enabled=true;
    } 
}
