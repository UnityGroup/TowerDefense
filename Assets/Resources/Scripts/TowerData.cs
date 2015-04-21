using UnityEngine;
using System.Collections.Generic;

public class TowerData {
    private Dictionary <string,Tower> towerData;

    public TowerData()
    {
        towerData = new Dictionary<string,Tower>();
        towerData.Add("Fire", new Tower(10,"Fire", 20));
        towerData.Add("Water", new Tower(30, "Water", 50));
        towerData.Add("Normal", new Tower(50, "Normal", 70));
        towerData.Add("Grass", new Tower(70, "Grass", 90));
    }

    public Dictionary<string,Tower> getTowerData()
    {
        return towerData;
    }
}
