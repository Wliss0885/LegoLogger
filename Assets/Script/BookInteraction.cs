using System;
using UnityEngine;

public class BookInteraction : MonoBehaviour
{
    // models for open book and closed book
    public GameObject openBook;
    public GameObject closedBook;
    // canvas for the scrollbox
    public GameObject canvas;
    // flag to check if the book is clicked
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
        // just to open and close the book and show the canvas based on the state of the book
        if (!isClicked)
        {
            openBook.SetActive(true);
            closedBook.SetActive(false);
            canvas.SetActive(true);
            isClicked = true;
        }
        else
        {
            closedBook.SetActive(true);
            openBook.SetActive(false);
            canvas.SetActive(false);
            isClicked = false;
        }
        Debug.Log("Book clicked");
    }
}
