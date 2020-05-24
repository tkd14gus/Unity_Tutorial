using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test21 : MonoBehaviour
{

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 10f);

        if(col.Length > 0)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Transform tf_Targer = col[i].transform;

                if(tf_Targer.name == "Player")
                {
                    NavMeshPath path = new NavMeshPath();
                    agent.CalculatePath(tf_Targer.position, path);

                    Vector3[] wayPoint = new Vector3[path.corners.Length + 2];
                    wayPoint[0] = transform.position;
                    wayPoint[wayPoint.Length - 1] = tf_Targer.position;

                    float _distance = 0f;
                    for (int p = 0; p < path.corners.Length; p++)
                    {
                        wayPoint[p + 1] = path.corners[p];
                        _distance = Vector3.Distance(wayPoint[p], wayPoint[p + 1]);
                    }

                    if(_distance <= 10f)
                    {
                        agent.SetDestination(tf_Targer.position);
                    }
                }
            }
        }
    }
}
