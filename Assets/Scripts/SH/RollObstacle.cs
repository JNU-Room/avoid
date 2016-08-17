using UnityEngine;
using System.Collections;
namespace SH
{
    public class RollObstacle : Obstacle
    {
        Vector3 target; // 타겟 위치
        new float delta = 0.15f; // 이동속도
        
        public float ToAbsolute(float number)
        {
            if (number < 0)
                return number * (-1);
            else
                return number;
        }

        // 오버라이딩
        public override void ObstacleMoving()
        {
            // target(Player 인식 위치)으로 이동
            transform.position = Vector3.MoveTowards(transform.position, target, delta); // (현재, 타겟, 속도)

           // target에 도달하면 Destroy
           if (transform.position == target)
            {
                Destroy(gameObject);
            }
           
           // 시야를 벗어나면 or Ground에 충돌하면 Destory (수정 필요)
        }

        // 오버라이딩
        public override void PlayerCollision() // Player와의 충돌
        {
            base.PlayerCollision(); // 부모 메소드 호출
                                    // 자기자신 파괴
                                    //   Destroy(gameObject);
        }

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            // target 계속 설정
            target = GameObject.Find("Player").transform.position; // 카메라 시야 내에서만 잡게 해야함 (수정 필요)

            ObstacleMoving(); // Obstacle 이동
        }
    }
}