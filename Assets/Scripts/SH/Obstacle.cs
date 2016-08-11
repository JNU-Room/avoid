using UnityEngine;
using System.Collections;
namespace SH
{
    public abstract class Obstacle : MonoBehaviour
    {
        public float delta = 0.1f; // y좌표 이동 
        
        public void PlayerCollision() // Player와의 충돌 처리
        {
            // Player의 Life 감소
            // Player의 위치 변화
            // Player 일시정지 or 무적

            Debug.Log("Player와 충돌"); // 테스트용 출력
        }

        public void OnTriggerEnter(Collider collider) // 충돌 발생 시 자동 호출 
                                                       // Collision? Trigger?
        {
            if (collider.gameObject.name == "Player") // Player와의 충돌이면
            {
                PlayerCollision(); // Player와의 충돌 처리
            }
        }

        public abstract void ObstacleMoving(); // Obstract의 이동

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}