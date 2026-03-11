using System;
using System.Collections.Generic;
using UnityEngine;

public class LegoLoggerManager : MonoBehaviour
{
    public static LegoLoggerManager instance;
    public Dictionary<String, GameObject> legoSetList = new Dictionary<String, GameObject>();

    void Awake()
    {
        // singleton pattern
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToDictionary(String legoSetName, GameObject legoSet)
    {
        if (!legoSetList.ContainsKey(legoSetName)) legoSetList.Add(legoSetName, legoSet);
        else Debug.Log("Lego set already there");
    }
}
