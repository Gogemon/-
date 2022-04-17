using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MapManager
{
    public static Tile[,] map;
}
[Serializable]
public class Tile
{    
    public int xPosition;
    public int yPosition;
    [NonSerialized]
    public GameObject baseObject;
    public string type;
}

[Serializable]
public class Wall
{
    public List<Vector2Int> positions;
    public string direction;
    public int length;
    public bool hasFeature = false;
}
[Serializable]
public class Feature
{
    public List<Vector2Int> positions;
    public Wall[] walls;
    public string type;
    public int width;
    public int height;
}
