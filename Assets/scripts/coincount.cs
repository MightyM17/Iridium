using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincount : MonoBehaviour
{
    public AudioClip clip;
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            coins.coinearn+=1;
            Destroy(gameObject);
            
        }
    }
}
