using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    
    public bool IsMapMake = true;

    // Use this for initialization
    void Start () {
        if (IsMapMake)
        {
            GameObject.Find("GameManager").GetComponent<MapMaker>().AutoCreateMap(); // Map 생성 시작
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
