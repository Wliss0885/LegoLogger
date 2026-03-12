using System;
using System.Collections.Generic;
using UnityEngine;

public class LegoLoggerManager : MonoBehaviour
{
    // singleton pattern
    public static LegoLoggerManager instance;
    // dictionary of lego sets
    public Dictionary<String, Sprite> legoSetList = new Dictionary<String, Sprite>();
    // prefab for the scrollbox
    public GameObject legoEntryPrefab;
    // where the prefabs are going to be placed
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
        // check if the lego set is already in the dictionary
        if (!legoSetList.ContainsKey(legoSetName))
        {
            legoSetList.Add(legoSetName, legoSetImage);
            // add a LegoSetEntry object to the scrollbox
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
