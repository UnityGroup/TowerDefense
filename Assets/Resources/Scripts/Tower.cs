using UnityEngine;
using System.Collections;

public class Tower {

    private int damage;
    private string type;
    private int price;

    public Tower(int damage, string type, int price)
    {
        this.damage = damage;
        this.type = type;
        this.price = price;
    }

    public int getDamage()
    {
        return this.damage;
    }

    public string getType()
    {

        return this.type;
    }

    public int getPrice()
    {
        return this.price;
    }

}
