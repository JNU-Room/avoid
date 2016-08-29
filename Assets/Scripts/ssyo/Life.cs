using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public Text lifePrint; // Life 프린트
    public int playerLife; // Player의 Life 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        playerLife = GameObject.Find("Player").GetComponent<Player>().GetLife(); // Player Life 가져옴

        lifePrint.text = "Life : " + playerLife;
	}
}
