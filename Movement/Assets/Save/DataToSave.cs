﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataToSave
{
    public int level;
    public string playerName;
    public float maxHp, curHp;
    public float x, y, z;

    //constructor
    public DataToSave(PlayerManager playerMngr)
    {
        level = playerMngr.level;
        playerName = playerMngr.name;
        maxHp = playerMngr.maxHp;
        curHp = playerMngr.curHp;
        x = playerMngr.x;
        y = playerMngr.y;
        z = playerMngr.z;
    }

}
