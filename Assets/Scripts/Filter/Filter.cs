using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Filter : MonoBehaviour
{
    private Shop_Grid Grid;

    //private int AllGamesCount;
    public int OwnedGamesCount;

    [SerializeField] private TextMeshProUGUI OwnedCountText;

    private void Awake()
    {
        Grid = FindObjectOfType<Shop_Grid>();
    }

    private void Update()
    {
        OwnedCountText.text = OwnedGamesCount.ToString();
    }

    public void GamesFilter(string genre = "", bool isAll = false, bool isOwned = false)
    {
        for(int i = 0; i < Grid.GridGames.Count; i++)
        {
            Grid.GridGames[i].SetActive(false);

            if (isAll)
            {
                Grid.GridGames[i].SetActive(true);
            }
            else if(isOwned)
            {
                if (Database.Instance.Games[i].Owned)
                {
                    Grid.GridGames[i].SetActive(true);
                }
            }

            if (Database.Instance.Games[i].Genre == genre)
            {
                Grid.GridGames[i].SetActive(true);
            }
        }
    }

    public void AllFilterButton()
    {
        GamesFilter("", true, false);
    }

    public void OwnedFilterButton()
    {
        GamesFilter("", false, true);
    }

    public void MOBAFilterButton()
    {
        GamesFilter("MOBA");
    }

    public void ShooterFilterButton()
    {
        GamesFilter("Shooter");
    }

    public void RPGFilterButton()
    {
        GamesFilter("RPG");
    }

    public void StrategyFilterButton()
    {
        GamesFilter("Strategy");
    }
}
