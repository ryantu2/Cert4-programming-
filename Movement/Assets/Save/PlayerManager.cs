using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public int level;
    public new string name;  // using 'new string' because 'name' is sorta reserved/already there
    public float maxHp, curHp;
    public DelayedHealth.Health health;

    public void SavePlayer()
    {

        maxHp = health.maxHealth;
        curHp = health.CurrentHealth;
        Save.SavePlayerData(this);
    }

    public void LoadPlayer()
    {
        DataToSave data = Save.LoadPlayerData();
        name = data.playerName;
        level = data.level;
        maxHp = data.maxHp;
        curHp = data.curHp;

    }
}
