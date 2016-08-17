using UnityEngine;
using System.Collections;
namespace SH
{
    public abstract class Obstacle : MonoBehaviour
    {
        public float delta = 0.1f; // y좌표 이동 
        
        public virtual void PlayerCollision() // Player와의 충돌 처리
        {
            /*
            Debug.Log("Object의 Player와 충돌"); // 테스트용 출력

            
            GameObject playerObj = GameObject.Find("Player");
            if (playerObj == null)
                return;
            // error 발생 :: player에 아무것도 안 들어감 ;; (수정 필요)
            Player player = playerObj.GetComponent<Player>(); // 컴포넌트 Player를 갖는 Player 객체 player
            if (player == null)
                return;

            // Player의 Life 감소
            player.SetLife(player.GetLife() - 5);

            // Player의 위치 변화 (수정 필요)
            player.SetPosition(player.transform.position.x - 5, player.transform.position.y, player.transform.position.z);

            // Player 일시정지 or 무적 (수정 필요)

*/
        }

        public virtual void OnTriggerEnter(Collider collider) // 충돌 발생 시 자동 호출 
                                                       // Collision? Trigger?
        {
            if (collider.gameObject.name == "Player") // Player와의 충돌이면
            {
                PlayerCollision(); // Player와의 충돌 처리
            }
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