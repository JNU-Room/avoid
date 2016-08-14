using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject mapA;

    public void MakeMap() // 맵 생성 메소드
    {
        // MapA 생성
        for (int i = 0; (20 * i) < 700; i++)
        {
            Vector3 mapAPosition = new Vector3(20 * i, 2.5f, 0);
            Debug.Log("Map A 생성 " + i);
            Instantiate(mapA, mapAPosition, Quaternion.identity);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
