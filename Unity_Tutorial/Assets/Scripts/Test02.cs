using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    //private는 보안을 걸어 inspector창에 뜨지 않음
    //[SerializeField]는 강제로 inspector창에 나오게 해준다.
    [SerializeField]
    //LookAt을 위해 선언한 변수
    private GameObject go_camera;

    //회전할때 90도 이상 돌아가면 막히는 현상을 풀기위해 사용
    //Vector3 rotation;
    //void Start()
    //{
    //    rotation = this.transform.eulerAngles;
    //}
    // Update is called once per frame

    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    //이동
        //    //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; // 대략 60분의 1
        //    //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //
        //    //회전
        //    //transform.eulerAngles은 값이 이상하게 바뀜.
        //    //그걸 받아와서 계속 사용하면 계속 이상해짐 => rotation을 고정값으로 받아와서 사용한다.
        //    //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
        //    //this.transform.eulerAngles = rotation; //transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
        //    //Debug.Log(transform.eulerAngles);
        //
        //    //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
        //
        //    //Quaternion은 4개의 인자가 필요한데 어떤게 들어가야 할 지 모름.
        //    //그냥 vector로 넣어도 돌아가게끔 구현되어 있음.
        //    //복잡. 하지만 짐벌락(한쪽 각도가 변했을 때 다른 각도로 회전이 고장나는 현상)을 막기위해 사용
        //    //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
        //    //this.transform.rotation = Quaternion.Euler(rotation);
        //
        //    //크기변화
        //    //this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2) * Time.deltaTime;
        //
        //    //moveSpeed * this.transform.forward * Time.deltaTime;//정규화 벡터(방향만을 알려주는 녀석 new Vector3(0, 0, 1) -> z축 방향이다.
        //    //                            //firward는  up, right등으로 방향을 가르쳐줄 수 있다.
        //
        //    this.transform.LookAt(go_camera.transform.position);
        //}

        //up이니까 y축 기준으로 카메라 주위를 빙빙 돈다.
        transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
