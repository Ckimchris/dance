using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMLoop : MonoBehaviour
{
    public Text timeSamples_Now_text;   //確認用に現在再生サンプル位置を表示
    public Text LOOPSTART_text;     //確認用
    public Text LOOPLENGTH_text;        //確認用

    public AudioSource audioSource;
    int timeSamples_Now = 0;
    public int LOOPSTART = 0;       //ループ開始箇所のサンプル数
    public int LOOPLENGTH = 0;      //ループ区間に含まれるサンプル数

    // Start is called before the first frame update
    void Start()
    {
        LOOPSTART_text.text = "LOOPSTART:" + string.Format("{0:D}", LOOPSTART);
        LOOPLENGTH_text.text = "LOOPLENGTH:" + string.Format("{0:D}", LOOPLENGTH);

        audioSource.Play(0);
    }

    void Update()
    {

        timeSamples_Now_text.text = "timeSamples_Now:" + string.Format("{0:D}", audioSource.timeSamples);


        if (!audioSource.isPlaying)
        {    //chrome系のブラウザではポーズ時にBGM停止状態でtimeSamplesが進んでしまう事が有る事象への対策
            audioSource.timeSamples = 0;
        }

        if (audioSource.timeSamples > LOOPSTART + LOOPLENGTH)
        {   //ループするタイミング判定
            audioSource.timeSamples = LOOPSTART + ((audioSource.timeSamples - LOOPSTART - 1) % LOOPLENGTH);
        }

    }
}
