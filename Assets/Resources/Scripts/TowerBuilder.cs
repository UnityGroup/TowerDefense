using UnityEngine;
using System.Collections;

public class TowerBuilder : MonoBehaviour {
    private GameObject tower;
    private Gold money;
    public TowerData towerData;

	void Start () {
        money = GameObject.Find("Gold").GetComponent<Gold>();
        towerData = new TowerData();
	}

	void Update () {
	
	}

    void OnMouseDown()
    {
        tower = Resources.Load("Prefabs/Towers/"+gameObject.name) as GameObject;
        Instantiate(tower, transform.parent.position, Quaternion.identity);
        Tower tower2;
        towerData.getTowerData().TryGetValue(gameObject.name, out tower2);
        money.spendGold(tower2.getPrice());
        transform.parent.gameObject.SetActive(false);
    }
}
