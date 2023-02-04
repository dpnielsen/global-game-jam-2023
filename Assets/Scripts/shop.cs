using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Button btnBuyTrousers;
    public Button btnBuyFartPack;
    public Button btnBuyBagPack;
    public Button btnFreeEggs;
    public int priceTrousers;
    public int priceFartPack;
    public int priceBagPack;
    public int slotsTrousers;
    public int slotsBagPack;
    public TMPro.TextMeshProUGUI eggsText;
    
    public void Start()
    {
        btnBuyTrousers.onClick.AddListener(buyTrousers);
        btnBuyBagPack.onClick.AddListener(buyBagPack);
        btnBuyFartPack.onClick.AddListener(buyFartPack);
        btnFreeEggs.onClick.AddListener(freeEggs);
        updateEggsText();
    }

    private void updateEggsText()
    {
        eggsText.text = "Eggs: " + PlayerPrefs.GetInt("eggs") + " / " + PlayerPrefs.GetInt("max_eggs");
    }
    
    public void FixedUpdate()
    {
        Debug.Log("Eggs: " + PlayerPrefs.GetInt("eggs"));
        updateEggsText();
    }

    public void freeEggs()
    {
        PlayerPrefs.SetInt("eggs", 100);
    }

    public void buyTrousers()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceTrousers)
        {
            PlayerPrefs.SetInt("eggs", eggs - priceTrousers);
            PlayerPrefs.SetInt("max_eggs", maxEggs + slotsTrousers);
        }
    }
    
    public void buyBagPack()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceBagPack)
        {
            PlayerPrefs.SetInt("eggs", eggs - priceBagPack);
            PlayerPrefs.SetInt("max_eggs", maxEggs + slotsBagPack);
        }
    }

    public void buyFartPack()
    {
        int eggs = PlayerPrefs.GetInt("eggs");
        int maxEggs = PlayerPrefs.GetInt("max_eggs");
        
        if (eggs >= priceFartPack)
        {
            PlayerPrefs.SetInt("eggs", eggs - priceFartPack);
        }
    }
}
