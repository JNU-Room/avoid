using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace ssyo
{

    public class FailZone : MonoBehaviour
    {
        void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == "Player")
            {
                // SceneManager.LoadScene("Practice one");
                GameObject.Find("Player").GetComponent<Player>().SetLife(0);
            }
        }

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