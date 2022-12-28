using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class c : MonoBehaviour {
    //public GameObject otherobj; //your other object 
    int coins,b,r,g,y,cy,rd;
    public Text blue,red,green,yellow,cyan,random;
    public void Blue () 
    {
        PlayerPrefs.SetInt("color",0);
    }
    public void Red () 
    {
        coins=PlayerPrefs.GetInt("coin");
        if(r!=1)
        {
        if(coins>=500)
        {
        coins-=500;
        PlayerPrefs.SetInt("color",1);
        r=1;
        PlayerPrefs.SetInt("coin",coins);
        red.text="Owned";
        }
        }
        if(r==1)
        {
            PlayerPrefs.SetInt("color",1);
        red.text="Owned";
        }
        
    }
    public void Green () 
    {
        coins=PlayerPrefs.GetInt("coin");
        if(g!=2)
        {
        if(coins>=500)
        {
            PlayerPrefs.SetInt("color",2);
        coins-=500;
        g=2;
        PlayerPrefs.SetInt("coin",coins);
        green.text="Owned";
        }
        }
        if(g==2)
        {
            PlayerPrefs.SetInt("color",2);
        green.text="Owned";
        }
    }
    public void Cyan () 
    {
        coins=PlayerPrefs.GetInt("coin");
        if(cy!=3)
        {
        if(coins>=500)
        {
            PlayerPrefs.SetInt("color",3);
        coins-=500;
        cy=3;
        PlayerPrefs.SetInt("coin",coins);
        cyan.text="Owned";
        }
        }
        if(cy==3)
        {
            PlayerPrefs.SetInt("color",3);
        cyan.text="Owned";
        }
    }
    public void Yellow () 
    {
        coins=PlayerPrefs.GetInt("coin");
        if(y!=4)
        {
        if(coins>=500)
        {
            PlayerPrefs.SetInt("color",4);
        coins-=500;
        y=1;
        PlayerPrefs.SetInt("coin",coins);
        
        yellow.text="Owned";
        }
        }
        if(y==4)
        {
            PlayerPrefs.SetInt("color",4);
        yellow.text="Owned";
        }
    }
    public void Rndm () 
    {
        coins=PlayerPrefs.GetInt("coin");
        if(rd!=5)
        {
        if(coins>=1000)
        {
            PlayerPrefs.SetInt("color",5);
        coins-=1000;
        rd=5;
        PlayerPrefs.SetInt("coin",coins);
       
        random.text="Owned";
        }
        }
        if(rd==5)
        {
            PlayerPrefs.SetInt("color",5);
        random.text="Owned";
        }
    }
}