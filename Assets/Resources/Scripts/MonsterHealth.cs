using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour {
    private float healthPoint;
    private Slider slider;
    private Image fillArea;
    private Gold money;

	void Start () {
        slider = GetComponentInChildren<Slider>();
        fillArea = slider.transform.FindChild("Fill Area").gameObject.GetComponentInChildren<Image>();
        slider.maxValue = 100;
        slider.minValue = 0;
        //healthPoint = 100;
        money = GameObject.Find("Gold").GetComponent<Gold>();
	}
	
	void Update () {
        slider.value = healthPoint;
        if (slider.value > slider.maxValue * 0.5) fillArea.color = Color.green;
        else if (slider.value > slider.maxValue * 0.25) fillArea.color = Color.yellow;
        else fillArea.color = Color.red;
	}

    public void setHealth(int healthPoints)
    {
        this.healthPoint = healthPoints;
    }

    public void damage(int damageAmount)
    {
        healthPoint -= damageAmount;
        if (healthPoint <= 0)
        {
            Destroy(gameObject);
            money.addGold(5);
        }
    }

    public void heal(int healAmount)
    {
        healthPoint += healAmount;
    }
}
