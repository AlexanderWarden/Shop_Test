using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Shop_Page : MonoBehaviour
{
    private Buy_Game buyGame;

    [SerializeField] private GameObject PageScreen;

    public string Name;
    public string Author;
    public string Genre;
    public float Cost;

    public string Sprite;

    public int GameIndex;

    [SerializeField] private TextMeshProUGUI GameNameText;
    [SerializeField] private TextMeshProUGUI GameAuthorText;
    [SerializeField] private TextMeshProUGUI GameGenreText;
    //[SerializeField] private TextMeshProUGUI GameSpriteText;

    [SerializeField] private TextMeshProUGUI GameCostText;

    [SerializeField] private GameObject BuyButton;
    [SerializeField] private GameObject CostText;
    [SerializeField] private GameObject OwnedObj;

    private void Start()
    {
        buyGame = FindObjectOfType<Buy_Game>();
    }

    private void Update()
    {
        CheckIfOwned();
    }

    private void CheckIfOwned()
    {
        if (Database.Instance.Games[GameIndex].Owned)
        {
            BuyButton.SetActive(false);
            CostText.SetActive(false);
            OwnedObj.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(true);
            CostText.SetActive(true);
            OwnedObj.SetActive(false);
        }
    }

    private void SetPageInfo()
    {
        GameNameText.text = Name;
        GameAuthorText.text = Author;
        GameGenreText.text = Genre;
        GameCostText.text = Cost.ToString();
    }

    public void SetPageValues(int index)
    {
        Name = Database.Instance.Games[index].Name;
        Author = Database.Instance.Games[index].Author;
        Genre = Database.Instance.Games[index].Genre;
        Cost = Database.Instance.Games[index].Cost;
        Sprite = Database.Instance.Games[index].Sprite;
        GameIndex = index;

        SetPageInfo();
    }

    public void OpenPage()
    {
        PageScreen.SetActive(true);
    }

    public void ClosePage()
    {
        PageScreen.SetActive(false);
    }

    public void BuyButtonClicked()
    {
        buyGame.BuyTheGame(GameIndex);
    }

    
}
