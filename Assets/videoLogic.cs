using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class videoLogic : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    private VideoPlayer videoPlayer1;
    private AudioSource audioPlayer1;
    private VideoPlayer videoPlayer2;
    private AudioSource audioPlayer2;
    private VideoPlayer videoPlayer3;
    private AudioSource audioPlayer3;
    public GameObject buttons;
    public ParticleSystem particles;
    public ParticleSystem particles2;

    private VideoClip clip1;

    // Use this for initialization
    void Start () {
        videoPlayer1 = player1.GetComponent<VideoPlayer>();
        audioPlayer1 = player1.GetComponent<AudioSource>();
        videoPlayer2 = player2.GetComponent<VideoPlayer>();
        audioPlayer2 = player2.GetComponent<AudioSource>();
        videoPlayer3 = player3.GetComponent<VideoPlayer>();
        audioPlayer3 = player3.GetComponent<AudioSource>();
        videoPlayer1.url = "https://www.sabarishg.com/clip1.mp4";
        videoPlayer1.Prepare();
        videoPlayer1.Play();
        audioPlayer1.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (videoPlayer1.frame == 230) {
            buttons.SetActive(true);
        }

        if (videoPlayer2.frame == 310)
        {
            particles.Play();
        }

        if (videoPlayer2.frame == 1000)
        {
            particles.Stop();
        }

        if (videoPlayer3.frame == 1800)
        {
            particles2.Play();
        }

        if (videoPlayer2.frame == 1800)
        {
            particles2.Play();
        }
    }

    public void Geyser()
    {
        player1.SetActive(false);
        player3.SetActive(true);
        buttons.SetActive(false);
        videoPlayer3.url = "https://www.sabarishg.com/clip3.mp4";
        videoPlayer3.Play();
    }

    public void Waterfall()
    {
        player1.SetActive(false);
        player2.SetActive(true);
        buttons.SetActive(false);
        videoPlayer2.url = "https://www.sabarishg.com/clip2.mp4";
        videoPlayer2.Play();
    }
}
