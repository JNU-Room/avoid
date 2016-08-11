using UnityEngine;
using System.Collections;
namespace SH
{
    public class GuidedObstacle : Obstacle
    {
        // 오버라이딩
        public override void ObstacleMoving()
        {
            // 플레이어를 목표로 이동
            // 카메라를 벗어나면 (플레이어와 x좌표가 일정 이상 차이가 나면) Destroy
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