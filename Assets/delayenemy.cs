using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class delayenemy : MonoBehaviour
{
    public NavMeshAgent n;
    // Start is called before the first frame update
    void Start()
    {
        n.enabled=false;
        StartCoroutine(begin());
    }

    IEnumerator begin()
    {
        yield return new WaitForSeconds(3.1f);
        n.enabled=true;
    }
}
