using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_BGM : MonoBehaviour {
    public AudioClip startBGM;
    public AudioClip dmgChkBGM;
    public AudioSource _audio;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void StartGame()
    {
        _audio.clip = startBGM;
        _audio.Play();
        SceneManager.LoadScene("Practice one");
    }
}
