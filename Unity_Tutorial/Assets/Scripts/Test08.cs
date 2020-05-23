using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test08 : MonoBehaviour
{

    private Animation anim;
    //현재 애니메이션 바꾸기 위해서
    private AnimationClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            ////누르면 바로
            //anim.Play("Cube_02");
            ////끝나고 나서
            //anim.PlayQueued("Cube_02");
            ////둘이 같이
            //anim.Blend("Cube_02");
            //전에 것이 자연스럽게 사라지고 실행
            //anim.CrossFade("Cube_02");
            ////
            //if(!anim.IsPlaying("Cube_02"))
            //{
            //    anim.Play("Cube_02");
            //}

            //멈추기
            anim.Stop();
            //모드 바꾸기
            anim.wrapMode = WrapMode.Loop;
            //현재 애니메이션 바꾸기
            anim.clip = clip;
        }
    }
}
