using UnityEngine;
using System.Collections;

public class TouchListener : MonoBehaviour {
    private GameObject towers;
    private Transform towerOpen;
	// Use this for initialization
	void Start () {
        towers = transform.FindChild("Towers").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                Debug.Log("Se toco la pantalla");
                Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
                foreach (Transform tower in towers.transform){
                    Debug.Log("Muestro los hijos");
                    if (tower.GetComponent<TowerMenuScript>().isOpen())
                    {
                        towerOpen = tower;
                        Debug.Log("Encontre una torreta abierta: " + tower.name);
                    }
                    tower.GetComponent<TowerMenuScript>().hideMenu();   
                }
                if (towerOpen)
                {
                    Debug.Log("Hay una torreta abierta " + towerOpen.name);
                    towerOpen.GetComponent<TowerMenuScript>().setIsOpen(false);
                    Debug.Log(towerOpen.GetComponent<TowerMenuScript>().isOpen());
                    towerOpen.GetComponent<TowerMenuScript>().spawnMenu();
                    towerOpen = null;
                }
                //Instantiate(fire, new Vector3((float)position.x, (float)position.y, 0), Quaternion.identity);
            }
        }
	}
    
}
