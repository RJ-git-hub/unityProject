using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Player
{
    private int level;
    public int getPlayerLevel()
    {
        return level;
    }
    
}

public class Monster
{
    private int level;

    public void SetLevel(int _playerLevel)
    {
        level = _playerLevel;
    }
}

public class Game
{
    Player player;
    Monster monster;

    public void Test()
    {
        monster.SetLevel(player.getPlayerLevel());
    }
}
