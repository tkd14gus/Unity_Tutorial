﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test20 : MonoBehaviour
{

    Rigidbody mtRigid;
    [SerializeField] private float moveSpeed;

    NavMeshAgent agent;

    [SerializeField] private Transform[] tf_Destination;
    //private Vector3 originPos;

    private Vector3[] wayPoints;

    // Start is called before the first frame update
    void Start()
    {
        mtRigid = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        //originPos = transform.position;

        //+1은 자신이 원래 있던 위치값
        wayPoints = new Vector3[tf_Destination.Length + 1];

        for (int i = 0; i < tf_Destination.Length; i++)
            wayPoints[i] = tf_Destination[i].position;

        wayPoints[wayPoints.Length - 1] = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    //그날 collider쓸 때
        //    //앞에 장애물 있으면 못 지나감
        //    //mtRigid.MovePosition(this.transform.position + transform.forward * moveSpeed * Time.deltaTime);
        //    agent.SetDestination(tf_Destination.position);
        //}
        Patrol();
    }

    private void Patrol()
    {
        //if (Vector3.Distance(transform.position, tf_Destination.position) < 0.1f)
        //    agent.SetDestination(originPos);
        //else if (Vector3.Distance(transform.position, originPos) < 0.1f)
        //    agent.SetDestination(tf_Destination.position);

        for (int i = 0; i < wayPoints.Length; i++)
        {
            if(Vector3.Distance(transform.position, wayPoints[i]) <= 0.1f)
            {
                if (i != wayPoints.Length - 1)
                    agent.SetDestination(wayPoints[i + 1]);
                else
                    agent.SetDestination(wayPoints[0]);
            }
        }
    }
}
