using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Game : MonoBehaviour
{
    private User_Money userMoney;
    private Filter filter;

    private void Start()
    {
        userMoney = FindObjectOfType<User_Money>();
        filter = FindObjectOfType<Filter>();
    }

    public void BuyTheGame(int index)
    {

        if (userMoney.CheckIfEnoughMoney(index))
        {
            Database.Instance.Games[index].Owned = true;
            userMoney.Money -= Database.Instance.Games[index].Cost;
            filter.OwnedGamesCount++;
        }
        else
        {
            Debug.Log("You dont have enough money");
        }
    }
}
