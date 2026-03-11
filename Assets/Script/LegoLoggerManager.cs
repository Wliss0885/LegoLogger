using System;
using System.Collections.Generic;
using UnityEngine;

public class LegoLoggerManager : MonoBehaviour
{
    public static LegoLoggerManager instance;
    public Dictionary<String, Sprite> legoSetList = new Dictionary<String, Sprite>();
    public GameObject legoEntryPrefab;
    public Transform uiParent;

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

    public void AddToDictionary(String legoSetName, Sprite legoSetImage)
    {
        if (!legoSetList.ContainsKey(legoSetName))
        {
            legoSetList.Add(legoSetName, legoSetImage);
            GameObject entry = Instantiate(legoEntryPrefab, uiParent);
            LegoSetEntry uiEntry = entry.GetComponent<LegoSetEntry>();
            uiEntry.Setup(legoSetName, legoSetImage);
        }
        else
        {
            Debug.Log("Lego set already there");
        }
    }
}
