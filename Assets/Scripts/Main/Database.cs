using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{

    public static Database Instance;

    public List<Game> Games = new List<Game>();

    private void Awake()
    {
        if(Instance == null)
            Instance = this;

        AddToDatabase( 0, "Dato 3", "Velve", "MOBA", 100, "sprite", false);
        AddToDatabase( 1, "Lel", "Riat", "MOBA", 500, "sprite", false);

        AddToDatabase( 2, "Kontra", "Velve", "Shooter", 100, "sprite", false);
        AddToDatabase( 3, "Velorant", "Riat", "Shooter", 500, "sprite", false);

        AddToDatabase( 4, "Eldar Ring", "Software", "RPG", 3000, "sprite", false);
        AddToDatabase( 5, "Watcher", "AD Project", "RPG", 2000, "sprite", false);

        AddToDatabase( 6, "Civochka", "Cid Meier", "Strategy", 1500, "sprite", false);
        AddToDatabase( 7, "Starik", "Blyzzard", "Strategy", 500, "sprite", false);

        for (int i = 0; i < Games.Count; i++)
            Debug.Log("Game " + (i + 1) + " - Name:" + Games[i].Name + " Author: " + Games[i].Author + " Genre: " + Games[i].Genre + " Cost: " + Games[i].Cost);

    }

    // для дальнейшего добавления игр в магазин
    private void AddToDatabase(int index, string name, string author, string genre, float cost, string sprite, bool owned)
    {
        Games.Add(new Game(index, name, author, genre, cost, sprite, owned));
    }

}
