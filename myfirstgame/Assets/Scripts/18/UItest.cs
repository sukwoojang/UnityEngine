using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItest : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;

    private bool isCoolTime = false;

    private float currentTime = 5f;

    private float delayTime = 5f;

    void Update()
    {
        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime/delayTime;
            if (currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }
    public void Change()
    {
        txt_name.text = "변경됨";
        //img_name.fillAmount = 0.5f;
        isCoolTime = true;
    }
}
