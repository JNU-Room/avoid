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