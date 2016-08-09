using UnityEngine;
using System.Collections;
namespace MH
{
    public class Obstacles : MonoBehaviour
    {
        float delta = 0.1f;
      
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y >= 4.5 || transform.position.y <= -1.5) // 상하단 끝
                delta *= -1;
            float newYPosition = transform.position.y + delta;
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
    }
}