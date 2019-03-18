using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public int level;
    public new string name;  // using 'new string' because 'name' is sorta reserved/already there
    public float maxHp, curHp;
    public DelayedHealth.Health health;
    public CheckPoint checkPoint;
    public float x, y, z;

    public void SavePlayer()
    {

        maxHp = health.maxHealth;
        curHp = health.CurrentHealth;
        x = checkPoint.curCheckPoint.x;
        y = checkPoint.curCheckPoint.y;
        z = checkPoint.curCheckPoint.z;
        Save.SavePlayerData(this);
    }

    public void LoadPlayer()
    {
        DataToSave data = Save.LoadPlayerData();
        name = data.playerName;
        level = data.level;
        maxHp = data.maxHp;
        curHp = data.curHp;
        x = data.x;
        y= data.y;
        z= data.z;
        this.transform.position = new Vector3(x, y, z);

    }
}
