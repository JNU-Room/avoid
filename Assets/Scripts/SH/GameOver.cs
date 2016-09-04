using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text gameoverText; // GameOver 시 출력 문구
    public bool IsGameOver = false; // GameOver?
    public int playerLife; // Player의 Life 값

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        playerLife = GameObject.Find("Player").GetComponent<Player>().GetLife();
        if (playerLife <= 0)
        {
            // 게임오버 문구 출력
            IsGameOver = true;
            gameoverText.enabled = true;

            // 게임 정지
        }
	}
}
