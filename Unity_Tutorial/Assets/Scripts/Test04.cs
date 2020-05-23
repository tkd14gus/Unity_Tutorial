using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{

    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    //if(Input.GetKeyDown(KeyCode.W))
    //    //{
    //    //    Debug.Log("col.bounds" + col.bounds);
    //    //    Debug.Log("col.bounds.extents" + col.bounds.extents);
    //    //    Debug.Log("col.bounds.extents.x" + col.bounds.extents.x);
    //    //    Debug.Log("col.size" + col.size);
    //    //    Debug.Log("col.center" + col.center);
    //    //
    //    //    //수정도 가능
    //    //    //col.size = new Vector3(3, 3, 3);
    //    //    //bounds는 read only라서 수정 불가
    //    //}
    //
    //    //0은 좌, 1은 우버튼
    //    //if (Input.GetMouseButtonDown(0))
    //    //{
    //    //    //메인카메라
    //    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    //    RaycastHit hitInfo;
    //    //    if (col.Raycast(ray, out hitInfo, 1000))
    //    //    {
    //    //        this.transform.position = hitInfo.point;
    //    //    }
    //    //}
    //}

    //isTrigger가 체크 되었을떄 발동
    //들어왔을 떄
    //private void OnTriggerEnter(Collider other)
    //{
    //
    //}
    //나갔을 떄
    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
    //머물 때
    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.1f);   
    }

    //isTrigger과 상관없이 물리적 충돌이 일어났을 때 사용
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    //물리적 충돌이면 겹치지 않는다.
    //하지만 강제로 이동시키다가 겹치게 되면
    //그것을 강제로 원래 위치로 이동시켜주는 역할
    private void OnCollisionStay(Collision collision)
    {
        
    }
}
