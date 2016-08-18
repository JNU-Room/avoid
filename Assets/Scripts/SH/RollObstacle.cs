using UnityEngine;
using System.Collections;
namespace SH
{
    public class RollObstacle : Obstacle
    {
        // 인식범위 내에 들어오면 타겟(x-10) 까지 가서 destroy
        Vector3 target; // 타겟 위치
        new float delta = 0.15f; // 이동속도

        // 오버라이딩
        public override void ObstacleMoving()
        {
            // target으로 이동
            transform.position = Vector3.MoveTowards(transform.position, target, delta); // (현재, 타겟, 속도)

           // target에 도달하면 Destroy
           if (transform.position == target)
            {
                Destroy(gameObject);
            }
        }

        // Use this for initialization
        void Start()
        {
            // target 설정
            target = new Vector3(transform.position.x - 10, transform.position.y, transform.position.z);
        }

        // Update is called once per frame
        void Update()
        {
           
            // if) Player가 인식 범위로 들어오면 (수정 필요)
            ObstacleMoving(); // Obstacle 이동
        }
    }
}