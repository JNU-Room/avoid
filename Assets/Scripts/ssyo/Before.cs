using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Before : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void click()
    {
        SceneManager.LoadScene(2);
    }
}
