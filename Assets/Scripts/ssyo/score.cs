using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text score_te; // 출력 텍스트
    public int score_ti; // 점수
    public float player_old_x; // player 이전 x 좌표
    public float player_cur_x; // player 현재 x 좌표
    public float player_distance; // player 이동거리

    // Use this for initialization
    void Start()
    {
        player_old_x = GameObject.Find("Player").transform.position.x; // 최초 x 초기화
        score_ti = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // player x좌표 및 거리
        player_cur_x = GameObject.Find("Player").transform.position.x; // 현재 x Update
        player_distance = player_cur_x - player_old_x; // 이동거리 설정
        player_old_x = player_cur_x; // 이전 위치 초기화

        // score 관련
        score_ti += (int)(player_distance * 50); // 점수 = 점수 + (이동거리 * 50)
        score_te.text = score_ti + "점"; // 점수 출력
    }
}