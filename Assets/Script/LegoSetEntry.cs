using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LegoSetEntry : MonoBehaviour
{
    // UI elements for the prefab
    public Image legoSetImage;
    public TMP_Text legoSetName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Setup(string setName, Sprite setImage)
    {
        legoSetName.text = setName;
        legoSetImage.sprite = setImage;
    }
}
