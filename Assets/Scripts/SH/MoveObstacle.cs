using UnityEngine;
using System.Collections;
namespace SH
{
    public class MoveObstacle : Obstacle
    {

        
        // 충돌 시 호출 메소드
        public void OnCollisionEnter (Collision collision)
        {
            Debug.Log("Collision 호출"); // Test용 출력

            // Ground나 Ceiling에 충돌 시 방향 반전
            if (collision.gameObject.name == "Ground" || collision.gameObject.name == "Ceiling")
            { delta *= -1; }
            
        }

        // 오버라이딩
        public override void ObstacleMoving() // Obstacle 이동 메소드
        {
            // 좌표 이동
            float newYPosition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPosition, 0);

            // 회전률 고정
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        // 오버라이딩
        public void PlayerCollision() // Player와의 충돌
        {
            base.PlayerCollision(); // 부모 메소드 호출
            // 자기자신 파괴
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            ObstacleMoving(); // Obstacle의 움직임
            
        }
    }
}