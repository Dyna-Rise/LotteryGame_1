using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LotteryManager : MonoBehaviour
{
    public OptionData optionData;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isSpinning)
        {
            if (!GameManager.isLottery)
            {
                GameManager.isLottery = true;
                GameManager.isResult = false;
                StartLottery();
            }
        }
    }

    public void StartLottery()
    {
        //ランダムな数字を生成
        GameManager.resultIndex = Random.Range(0, optionData.option.prizeName.Length);
        Debug.Log("抽選番号結果:" + GameManager.resultIndex);

        //抽選中を解除
        GameManager.isResult = true;

    }

}
