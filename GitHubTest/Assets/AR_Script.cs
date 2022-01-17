using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Script : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float td = Time.deltaTime, t1 = Time.time % 10, t2 = (Time.time % 20 - 10) / 10;
        transform.Rotate(Vector3.up * t1 * 48 * t2 * td);
    }
}
