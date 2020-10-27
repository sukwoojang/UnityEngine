using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttest : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private bool isClick;

    private float dotTime = 1f;
    private float currentDotTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        currentDotTime = dotTime;
    }
    void Update()
    {
        if (isClick) {
            currentDotTime -= Time.deltaTime;

            if (currentDotTime <= 0)
            {
                slider.value -= Time.deltaTime;

                if(currentDotTime < 0)
                {
                    currentDotTime = dotTime;
                }
            }
            
        }
        
    }
    public void Button()
    {
        isClick = true;
    }
}
