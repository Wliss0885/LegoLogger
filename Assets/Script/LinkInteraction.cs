using UnityEngine;

public class LinkInteraction : MonoBehaviour
{
    // url for the lego set
    public string url;
    
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
        Application.OpenURL(url);
    }
}