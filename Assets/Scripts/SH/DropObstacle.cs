using UnityEngine;
using System.Collections;
namespace SH
{
    public class DropObstacle : Obstacle
    {
        float dropRange = 5.0f; // Drop 인식 범위
        new float delta = -0.12f; // Drop 속도

        public override void OnTriggerEnter(Collider collider) // 충돌 시 호출 메소드
        {
            base.OnTriggerEnter(collider);

            if (collider.name == "Ground") // Ground와 충돌
            {
                delta = 0; // 더이상 떨어지지 않음
            }
        }

        public bool IsInside() // 범위 내에 Player가 접근했는가?
        {
            // 인식 범위 내인지 판별
            if (transform.position.x - GameObject.Find("Player").transform.position.x < dropRange)
                return true;
            else
                return false;
        }

        // 오버라이딩
        public override void ObstacleMoving()
        {
            if (IsInside()) // Player가 범위 내에 들어오면
            {
                // 아래로 떨어진다 (Ground와 충돌 시, OnTriggerEnter에 의해 정지)
                transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);
            }
        }
        
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            ObstacleMoving(); // Obstacle 이동
        }
    }
}