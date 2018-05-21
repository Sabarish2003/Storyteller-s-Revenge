using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlay : MonoBehaviour {

    public GameObject gameObject1;
    private VideoPlayer videoPlayer1;
    public GameObject gameObject2;
    private VideoPlayer videoPlayer2;
    public GameObject gameObject3;
    private VideoPlayer videoPlayer3;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play() {
        videoPlayer1 = gameObject1.GetComponent<VideoPlayer>();
        videoPlayer1.Play();
        videoPlayer2 = gameObject2.GetComponent<VideoPlayer>();
        videoPlayer2.Play();
        videoPlayer3 = gameObject3.GetComponent<VideoPlayer>();
        videoPlayer3.Play();
    }
}
