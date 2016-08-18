using UnityEngine;
using System.Collections;
namespace SH
{
    public abstract class Obstacle : MonoBehaviour
    {
        public float delta = 0.1f; // y좌표 이동 
      
        public virtual void OnTriggerEnter(Collider collider) // 충돌 발생 시 자동 호출 
                                                       // Collision? Trigger?
        {
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