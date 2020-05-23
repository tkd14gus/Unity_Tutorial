using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //재생
        ps.Play();
        //정지
        ps.Stop();
        //일시정지
        ps.Pause();
        //순간 몇개가 뿜어져 나올지
        ps.Emit(1);
    }
}
