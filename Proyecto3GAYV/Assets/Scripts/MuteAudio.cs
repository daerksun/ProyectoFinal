using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    private bool muted;

    // Start is called before the first frame update
    void Start()
    {
        muted = PlayerPrefs.GetInt("MUTED") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MutePressed()
    {
        muted = !muted;
        AudioListener.pause = muted;
        PlayerPrefs.SetInt("MUTED", muted ? 1 : 0);
    }
}
