using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
        
    public int playerLife; // Player의 Life 값
    public GUITexture gameoverGUITexture; //GameOver 시 출력 문구
    public Start_BGM Audio_BGM;
    // Use this for initialization
    void Start ()
    {
        GameObject.Find("GameManager").GetComponent<restart>().enabled = false; // rt버튼 처음에 안 뜨게
        Audio_BGM = GameObject.Find("Start_BGM").GetComponent<Start_BGM>();
    }
	
	// Update is called once per frame
	void Update () {
        playerLife = GameObject.Find("Player").GetComponent<Player>().GetLife();
        if (playerLife <= 0)
        {
            

            // 게임오버 문구 출력
            gameoverGUITexture.enabled = true;
            // 재도전 버튼 출력
            GameObject.Find("GameManager").GetComponent<restart>().enabled = true;
            // 게임 정지
            GameObject.Find("Player").GetComponent<SpriteRenderer>().enabled = false; // Player 캐릭터 감추기
            GameObject.Find("Player").GetComponent<Player>().enabled = false; // Player 스크립트 비활성화

            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle"); // Obstacle 불러와서 
            for (int i = 0; i < obstacles.Length; i++) 
            {
                Destroy(obstacles[i]); // Obstacle 전부 파괴
            }
            Audio_BGM.RestartGame();
            
        }
	}
}
