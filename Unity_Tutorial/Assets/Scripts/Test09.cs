using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test09 : MonoBehaviour
{

    private Animator anim;
    //재생 속도 조절을 위해
    [SerializeField] private float moveSpeed;

    private bool isMove;

    //점프용
    private Rigidbody rigid;
    private BoxCollider col;
    [SerializeField] private float jumpForce;
    //특정 오브젝트만 레이저에 맞을 수 있도록(아니면 자기 자신도 맞음)
    [SerializeField] private LayerMask layerMask;

    private bool isJump;
    private bool isFall;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        rigid = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        TryWalk();
        TryJump();
        
}

    private void TryWalk()
    {
        //수평 -> A키와 D키 혹은 방향키 왼쪽과 오른쪽
        //오른쪽 = 1, 좌측 = -1, 아무것도 아니면 0이 반환
        float _dirX = Input.GetAxisRaw("Horizontal");
        float _dirY = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(_dirX, 0, _dirY);

        //비효율
        //anim.SetBool("Right", false);
        //anim.SetBool("Left", false);
        //anim.SetBool("Up", false);
        //anim.SetBool("Down", false);

        isMove = false;

        //zero는 정규벡터를 의미
        if (direction != Vector3.zero)
        {
            //여기 들어오면 무조건 움직이는 것
            isMove = true;
            //대각선 움직임도 수평 수직 움직임과 똑같이
            //만들기 위해서 Normalized를 함.
            //하지 않은면 대각선 속도만 유독 빨라짐
            //X와 Z가 둘다 1이면 둘이 합하면 2가 된다. 즉 대각선은 2 속도로 움직인다.
            //하지만 Nomalized를 하면 1이 되어 대각선도 1의 속도로 움직인다.
            this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);

            //비효율
            //if (direction.x > 0)
            //    anim.SetBool("Right", true);
            //else if (direction.x < 0)
            //    anim.SetBool("Left", true);
            //else if (direction.z > 0)
            //    anim.SetBool("Up", true);
            //else if (direction.z < 0)
            //    anim.SetBool("Down", true);

        }
        anim.SetBool("Move", isMove);
        anim.SetFloat("DirX", direction.x);
        anim.SetFloat("DirZ", direction.z);

    }

    private void TryJump()
    {

        if(isJump)
        {
            if(rigid.velocity.y <= -0.1f && !isFall)
            {
                isFall = true;
                anim.SetTrigger("Fall");
            }

            RaycastHit hitInfo;
            //col.bounds.extents.y는 col(지금은 박스)의 y값의 절반
            if (Physics.Raycast(transform.position, -transform.up, out hitInfo, col.bounds.extents.y + 0.1f, layerMask))
            {
                anim.SetTrigger("Land");
                isJump = false;
                isFall = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            rigid.AddForce(Vector3.up * jumpForce);
               //.velocity = new Vector3(0, jumpForce, 0);
            anim.SetTrigger("Jump");
        }
    }
}
