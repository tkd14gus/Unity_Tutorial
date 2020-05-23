using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test11 : MonoBehaviour
{

    [SerializeField] private Text txt_Name;
    [SerializeField] private Image img_Name;

    //스프라이트 직접 넣기
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;

    void Update()
    {

        //속성
        //이미지 변경
        //img_Name.sprite = 
        //색
        img_Name.color = Color.red;
        //색에 맞춰 이미지 사라지게 하기
        Color color = img_Name.color;
        color.a = 0f;
        img_Name.color = color;

        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_Name.fillAmount = currentTime / delayTime;

            if(currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_Name.fillAmount = currentTime;
            }
        }
    }
    public void Change()
    {
        txt_Name.text = "변경됨";
        //img_Name.fillAmount = 0.5f;
        isCoolTime = true;
    }
}
