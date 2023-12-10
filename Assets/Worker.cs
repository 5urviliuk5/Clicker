using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public int count;
    public int cost;
    public int cps = 1;
    public string name;

    private void Start()
    {
        InvokeRepeating("Work", 1f, 1f);
        Load();
    }

    public void Buy()
    {
        if (GameManager.clicks < cost) return;

        count++;
        GameManager.clicks -= cost;
        cost = (int)(cost * 1.3f);

        Save();
    }

    void Work()
    {
        GameManager.clicks += count * cps;
    }

    void Save()
    {
        PlayerPrefs.SetInt(name + "count",count);
        PlayerPrefs.SetInt(name + "cost", cost);
    }
    
    void Load()
    {
        count = PlayerPrefs.GetInt(name + "count");
        cost = PlayerPrefs.GetInt(name + "cost",cost);
    }
}
