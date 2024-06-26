using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop_GameCard : MonoBehaviour
{
    public string Name;
    //public string Author;
    public string Genre;
    public float Cost;
    public string Sprite;
    public int GameIndex;

    public bool isOwned = false;

    [SerializeField] private TextMeshProUGUI CardNameText;
    [SerializeField] private TextMeshProUGUI CardCostText;

    [SerializeField] private Image CostImage;

    private Shop_Page Page;

    private void Start()
    {
        Page = FindObjectOfType<Shop_Page>();        
    }

    private void Update()
    {
        CheckIfOwned();
    }

    private void CheckIfOwned()
    {
        if (Database.Instance.Games[GameIndex].Owned)
        {
            CardCostText.text = "Owned";
            CardCostText.color = new Color(0, 0, 0, 255);
            CostImage.color = new Color(255, 145, 0, 255);
        }
    }

    public void SetValues(int index)
    {
        Name = Database.Instance.Games[index].Name;
        Cost = Database.Instance.Games[index].Cost;
        Sprite = Database.Instance.Games[index].Sprite;
        GameIndex = index;

        SetCardInfo();
    }

    private void SetCardInfo()
    {
        CardNameText.text = Name;
        CardCostText.text = Cost.ToString();
    }

    public void ShowPage()
    {
        Page.OpenPage();
        Page.SetPageValues(GameIndex);
    }

}
