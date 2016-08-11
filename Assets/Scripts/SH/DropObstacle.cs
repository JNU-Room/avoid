using UnityEngine;
using System.Collections;
namespace SH
{
    public class DropObstacle : Obstacle
    {
        
        public void OnCollisionEnter() // 충돌 시 호출 메소드
        {
            // Ground와 충돌 시, Destory
        }

        public bool IsInside() // 범위 내에 Player가 접근했는가?
        {
            /*
            if (Object의 x - Player의 x < 범위)
                return true;
            else
                return false;
            */

            return true; // 임시 return 값 
        }

        // 오버라이딩
        public override void ObstacleMoving()
        {
            if (IsInside()) // Player가 범위 내에 들어오면
            {
                // 아래로 떨어진다
            }
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
            ObstacleMoving(); // Obstacle 이동
        }
    }
}