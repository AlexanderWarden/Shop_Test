using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Grid : MonoBehaviour
{
    public List<GameObject> GridGames = new List<GameObject>();

    public GameObject GamePrefab;

    private void Start()
    {
        for(int i = 0; i < Database.Instance.Games.Count; i++)
        {
            InstantiateGame(i);
        }
    }

    private void InstantiateGame(int index)
    {
        GameObject GameCard = Instantiate(GamePrefab);
        GridGames.Add(GameCard);
        GameCard.transform.SetParent(this.transform);
        GameCard.GetComponent<Shop_GameCard>().SetValues(index);
    }

}
