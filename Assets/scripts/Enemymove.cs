using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymove : MonoBehaviour
{
    [SerializeField]
    Transform _destination;
    NavMeshAgent n;
    public Transform t;
    public Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        n=this.GetComponent<NavMeshAgent>();
        if(n == null)
        {
            Debug.Log("Error");
        }
        else
        {
            SetDestination();
        }
    }
    void FixedUpdate()
    {
        if(t.position.y<-1)
        {
            //t.transform.position=spawn;
            StartCoroutine(Waitnavmesh());
            
            //GetComponent<NavMeshAgent>().enabled = true;
        }
        n=this.GetComponent<NavMeshAgent>();
        if(n == null)
        {
            Debug.Log("Error");
        }
        else
        {
            SetDestination();
        }
    }

    void SetDestination()
    {
        if(_destination != null)
        {
            Vector3 target = _destination.transform.position;
            n.SetDestination(target);
        }
    }
    void OnCollisionEnter(Collision other) {
        if(other.collider.tag=="Player")
        {
            Debug.Log("hi");
            //GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
        }  
        
    }  
    void OnCollisionExit(Collision other) {
        if(other.collider.tag=="Player")
        {
            Debug.Log("ihi");
            StartCoroutine(Waitnavmesh());
        }  
    }
     IEnumerator Waitnavmesh()
    {
        yield return new WaitForSeconds(0.7f);
        GetComponent<NavMeshAgent>().enabled = true;
    }
}
