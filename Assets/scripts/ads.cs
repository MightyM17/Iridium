using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour
{
    string Androidid="3545853";
    bool Gamemode=false;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(Androidid,Gamemode);
        Advertisement.Show ();
    }
}
