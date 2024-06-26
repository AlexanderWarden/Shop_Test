using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public int Index;
    public string Name;
    public string Author;
    public string Genre;
    public float Cost;

    public string Sprite;
    public bool Owned;
    

    public Game(int index, string name, string author, string genre, float cost, string sprite, bool owned)
    {
        Index = index;
        Name = name;
        Author = author;
        Genre = genre;
        Cost = cost;
        Sprite = sprite;
        Owned = owned;
        
    }

}

