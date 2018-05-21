using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoRestart : MonoBehaviour {

    public GameObject gameObject1;
    private VideoPlayer videoPlayer1;
    public GameObject gameObject2;
    private VideoPlayer videoPlayer2;
    public GameObject gameObject3;
    private VideoPlayer videoPlayer3;
    public ParticleSystem particles;
    public ParticleSystem particles2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Restart()
    {
        videoPlayer1 = gameObject1.GetComponent<VideoPlayer>();
        videoPlayer2 = gameObject2.GetComponent<VideoPlayer>();
        videoPlayer3 = gameObject3.GetComponent<VideoPlayer>();
        gameObject1.SetActive(true);
        videoPlayer1.Play();
        videoPlayer1.frame = 1;
        gameObject2.SetActive(false);
        gameObject3.SetActive(false);
        videoPlayer2.Stop();
        videoPlayer3.Stop();
        particles.Stop();
        particles2.Stop();
    }
}
