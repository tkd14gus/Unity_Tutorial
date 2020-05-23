using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    //[SerializeField]
    private Rigidbody myRigid;

    //MoveRotation에 Quaternion이 필요해서
    //private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        //[SerializeField]대신 myRigid를 채워넣기 위해서
        myRigid = GetComponent<Rigidbody>();
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //순간 속도가 변화하면 그것을 적용
            //myRigid.velocity = new Vector3(0, 0, 1);
            //              // = Vector3.forward;

            //회전
            //myRigid.angularVelocity = Vector3.right;
            //                    //  = new Vector3(1, 0, 0);

            //myRigid.mass -> 질량
            //myRigid.drag -> 저항
            //myRigid.angularDrag -> 회전저항

            //회전의 최대속도를 변경(7이 최대속도)
            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;

            //이렇게 체크를 하고 뺄 수 있다.
            //myRigid.isKinematic = true;
            //myRigid.useGravity = true;

            //아래 두개는 관성영향X 강제로
            //일정 방향으로 움직이기
            //myRigid.MovePosition(transform.forward);
            //각도
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));

            //물리 영향
            //myRigid.AddForce(Vector3.forward);
            //myRigid.AddTorque(Vector3.up);
            //폭발
            myRigid.AddExplosionForce(10, this.transform.right, 10);


            //add->물리 영향
            //move->강제
        }
    }
}
