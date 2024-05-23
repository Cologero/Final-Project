using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    //Only if you need to collect items to complete the level, add variable below
    [SerializeField] private int _itemsCollected = 0;
    [SerializeField] private int _totalItemsCollected = 5;
    [SerializeField] private TextMeshProUGUI _itemsCollectText;
    [SerializeField] private string _sceneName;
    [SerializeField] private PlayerHealth _playerHealth;
   
    

    // Update is called once per frame
    void Update()
    {
       
        }

       

   

    public void UpdateItemsCollected(int amount)
    {
        _itemsCollected += amount;
        _itemsCollectText.text = "Items: " + _itemsCollected.ToString() + "/" + _totalItemsCollected.ToString();

        if(_itemsCollected >= _totalItemsCollected)
        {
            StartCoroutine("EndLevel");
        }
    }

   
    
}