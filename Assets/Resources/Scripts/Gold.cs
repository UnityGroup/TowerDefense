using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gold : MonoBehaviour {
    private int initialGold = 2000;
    private int gold;

	void Start () {
        gold = initialGold;
	}
	

	void Update () {
        GetComponent<Text>().text = "" + gold;
	}

    public int getGold()
    {
        return gold;
    }

    public void addGold(int amount)
    {
        gold += amount;
    }

    public void spendGold(int amount)
    {
        gold -= amount;
    }
}
