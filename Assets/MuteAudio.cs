using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MuteAudio : MonoBehaviour
{
    public Flowchart flowchart;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int sound = flowchart.GetIntegerVariable("sound1");
        if(sound == 0)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
