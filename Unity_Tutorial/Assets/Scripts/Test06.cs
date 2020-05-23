using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    ////(카메라가) 따라갈 타겟
    //[SerializeField]
    //private GameObject go_Target;
    //
    ////속도
    //[SerializeField]
    //private float speed;
    //
    ////거리
    //private Vector3 difValue;

    private Camera theCam;

    // Start is called before the first frame update
    void Start()
    {
        ////거리 계산
        //difValue = transform.position - go_Target.transform.position;
        ////음수가 나올수도 있으니 절대값 해서 양수로
        //difValue = new Vector3(-Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), -Mathf.Abs(difValue.z));

        //시점 설정
        theCam.fieldOfView = 50;
        //flag변경
        //theCam.clearFlags
    }

    // Update is called once per frame
    void Update()
    {
        ////Lerp = 움직임 보관법 -> 중간 값 계산
        //this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position + difValue, speed);
    }
}
