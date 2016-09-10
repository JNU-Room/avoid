using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text score_te;
    public int score_ti;
    public float player_first_x; // player 최초 x 좌표
    public float player_cur_x; // player 현재 x 좌표
    public float player_distance; // player 이동거리
    public int size = 6;

    // Use this for initialization
    void Start()
    {
        player_first_x = GameObject.Find("Player").transform.position.x; // 최초 x 초기화
    }

    // Update is called once per frame
    void Update()
    {
        player_cur_x = GameObject.Find("Player").transform.position.x; // 현재 x Update
        player_distance = player_cur_x - player_first_x; // 이동거리 설정
        score_ti = (int) (player_distance * 50); // 점수 = 이동거리 * 50

        score_te.text = score_ti + "점";
        score_te.fontSize = Screen.height * size / 100;


    }
}