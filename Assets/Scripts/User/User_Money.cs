using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class User_Money : MonoBehaviour
{
    public float Money;

    public TextMeshProUGUI MoneyText;

    private void Update()
    {
        MoneyText.text = "$" + Money.ToString();
    }

    public bool CheckIfEnoughMoney(int index)
    {
        if (Money >= Database.Instance.Games[index].Cost)
            return true;
        else
            return false;
    }
}
