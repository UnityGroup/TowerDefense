using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    private int initialHealth = 20;
    private int health;

    void Start()
    {
        health = initialHealth;
    }


    void Update()
    {
        GetComponent<Text>().text = "" + health;
    }

    public int getHealth()
    {
        return health;
    }

    public void addHealth(int amount)
    {
        health += amount;
    }

    public void spendHealth(int amount)
    {
        health -= amount;
    }
}
