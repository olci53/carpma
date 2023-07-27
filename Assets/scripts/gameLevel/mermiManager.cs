using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiManager : MonoBehaviour
{
    float mermiHizi = 10f;


   

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * mermiHizi);
    }

}
