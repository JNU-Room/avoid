using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text score_te;
    public float score_ti;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        score_ti++;
        
        score_te.text = score_ti + "점";



    }
}