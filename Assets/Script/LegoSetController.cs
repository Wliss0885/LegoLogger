using System;
using UnityEngine;

public class LegoSetController : MonoBehaviour
{
    public String legoSetName;
    public Sprite legoSetImage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLegoSetFound()
    {
        Debug.Log($"{legoSetName} Set Found");
        LegoLoggerManager.instance.AddToDictionary(legoSetName, legoSetImage);
    }

    public void OnLegoSetLost()
    {
        Debug.Log($"{legoSetName} Set Lost");
    }
}
