using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
    public Start_BGM Audio_BGM;
    // Use this for initialization
    void Start ()
    {
        Audio_BGM = GameObject.Find("Start_BGM").GetComponent<Start_BGM>();
        Audio_BGM.StartGame();
    }
	
	// Update is called once per frame
	void Update () {

	}
}
