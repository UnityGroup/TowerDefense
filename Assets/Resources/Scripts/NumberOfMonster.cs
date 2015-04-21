using UnityEngine;
using System.Collections;

public class NumberOfMonster{

    private GameObject monster;
    private int number;
    private int health;

    public NumberOfMonster(GameObject monster, int number, int health)
    {
        this.monster = monster;
        this.number = number;
        this.health = health;
    }

    public GameObject getMonster()
    {
        return monster;
    }

    public int getNumber()
    {
        return number;
    }

    public void decreaseNumber()
    {
        this.number--;
    }


}
