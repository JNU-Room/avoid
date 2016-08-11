using UnityEngine;
using System.Collections;
namespace SH
{
    public class StopObstacle : Obstacle
    {

        // 오버라이딩
        public override void ObstacleMoving()
        {
            // 좌표 고정
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