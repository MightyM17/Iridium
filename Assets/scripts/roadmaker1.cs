using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadmaker1 : MonoBehaviour {
    private float spawnz = 1f;
    public GameObject[] prefabs;
    private float RoadLength = 24f;
    private int amt = 4;
     public static float seedv;
    private List<GameObject> roadsList;
    private Transform playertransform;
    // Start is called before the first frame update
    void Start () {
        if(PlayerPrefs.GetInt("seed")==1)
        Random.seed=seed.seedno;

        seedv=(Random.seed);
        Debug.Log(seedv);
        roadsList = new List<GameObject> ();
        for (int i = 0; i < amt; ++i) {
            SpawnRoad (0);
        }
        playertransform = GameObject.FindGameObjectWithTag ("Player").transform;
    }

    // Update is called once per frame
    void Update () {
        int b = Random.Range (0, prefabs.Length - 2);
        if (playertransform.position.z > (spawnz - amt * RoadLength)) {
            SpawnRoad (b);
            
        }
    }
    void SpawnRoad (int prefabIndex) {
        GameObject go;
        go = Instantiate (prefabs[prefabIndex]) as GameObject;
        go.transform.SetParent (transform);
        go.transform.position = Vector3.forward * (spawnz - 30);
        spawnz = spawnz + RoadLength;
        roadsList.Add (go);
    }
}