using System;
using UnityEngine;

public class BookInteraction : MonoBehaviour
{
    public GameObject openBook;
    public GameObject closedBook;
    private Boolean isClicked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        if (!isClicked)
        {
            openBook.SetActive(true);
            closedBook.SetActive(false);
            isClicked = true;
        }
        else
        {
            closedBook.SetActive(true);
            openBook.SetActive(false);
            isClicked = false;
        }
        Debug.Log("Book clicked");
    }
}
