using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTester : MonoBehaviour, IDataPersistence
{
    public int deathCount;


    public void onPlayerDeath()
    {
        deathCount++;
    }

    public void checkDeaths()
    {
        Debug.Log(deathCount);
    }

    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }

    public void SaveData(ref GameData data)
    {
        data.deathCount = this.deathCount;
    }
}
