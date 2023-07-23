using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> onClick)
    {
            button.onClick.AddListener(delegate()
            {
                onClick(param);
            });
    }
}

public class Shop : MonoBehaviour
{
    [Serializable]
    public struct ShopItem{
        public string Name;
        public string Price;
        public Sprite Icon;
    }

    [SerializeField] ShopItem[] allShopItems;
    // Start is called before the first frame update
    void Start()
    {
        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        int n = allShopItems.Length;
        for(int i = 0; i< n; i++) 
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<Image>().sprite = allShopItems[i].Icon;
            g.transform.GetChild(1).GetComponent<TMP_Text>().text = allShopItems[i].Name;
            g.transform.GetChild(2).GetComponent<TMP_Text>().text = allShopItems[i].Price;

            g.GetComponent<Button>().AddEventListener(i, ItemClicked);
            

        }
        Destroy (buttonTemplate);
    }

    void ItemClicked(int itemIndex) 
    {
        Debug.Log("item " + itemIndex + " clicked");
        Debug.Log("name " + allShopItems[itemIndex].Name);
        Debug.Log("price " + allShopItems[itemIndex].Price);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
