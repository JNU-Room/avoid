using UnityEngine;
using System.Collections;
namespace SH
{
    public class MoveObstacle : Obstacle
    {

        
        // 충돌 시 호출 메소드
        public override void OnTriggerEnter (Collider collider)
        {
            base.OnTriggerEnter(collider);

            // Ground, Ceiling와 충돌 시
            if (collider.gameObject.name == "Ground" || collider.gameObject.name == "Ceiling")
            { delta *= -1; } // 방향 반전
        }

        // 오버라이딩
        public override void ObstacleMoving() // Obstacle 이동 메소드
        {
            // 좌표 이동
            float newYPosition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPosition, 0);
        }

        // 오버라이딩
        public override void PlayerCollision() // Player와의 충돌
        {
            base.PlayerCollision(); // 부모 메소드 호출
           // Destroy(gameObject); // 자기자신 파괴
            Debug.Log("Move의 Player와의 충돌"); // Test용 출력 
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