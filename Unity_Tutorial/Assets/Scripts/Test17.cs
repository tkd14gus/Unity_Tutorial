using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{
    ////특정 레이어만 맞게 하기 위해서
    //[SerializeField] private LayerMask layerMask;
    //[SerializeField] private GameObject go_BulletPrefab;
    //
    //private float creatTime = 1f;
    //private float currentCreateTime = 0;
    //
    //// Update is called once per frame
    //void Update()
    //{
    //
    //    currentCreateTime += Time.deltaTime;
    //    if(currentCreateTime >= creatTime)
    //    {
    //        currentCreateTime = 0f;
    //        RaycastHit hitInfo;
    //
    //        if(Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, 10f, layerMask))
    //        {
    //            //Debug.Log(hitInfo.transform.name);
    //            if (hitInfo.transform.tag == "Player")
    //            {
    //                Instantiate(go_BulletPrefab, transform.position, Quaternion.LookRotation(hitInfo.transform.position - transform.position));
    //            }
    //        }
    //    }
    //
    //}

    private float createTime = 1f;
    private float currentCreateTime = 0;

    [SerializeField] private GameObject go_BulletPrefab;

    void Update()
    {



        Collider[] col = Physics.OverlapSphere(transform.position, 5f);

        if(col.Length > 0)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Transform tf_target = col[i].transform;

                if(tf_target.tag == "Player")
                {
                    Quaternion rotation = Quaternion.LookRotation(tf_target.position - this.transform.position);

                    transform.rotation = rotation;
                    currentCreateTime += Time.deltaTime;

                    if (currentCreateTime >= createTime)
                    {
                        GameObject _temp =  Instantiate(go_BulletPrefab, transform.position, rotation);
                        //충돌해도 데미지를 입지 않도록
                        Physics.IgnoreCollision(_temp.GetComponent<Collider>(), tf_target.GetComponent<Collider>());
                        currentCreateTime = 0;
                    }

                }
            }
            {

            }
        }
    }

}
