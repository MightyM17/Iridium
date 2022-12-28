using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showcoins : MonoBehaviour
{
    public Text t;
    // Update is called once per frame
    void Update()
    {
        t.text=PlayerPrefs.GetInt("coin").ToString();
    }
}
