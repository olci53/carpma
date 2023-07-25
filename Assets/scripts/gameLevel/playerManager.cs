using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    [SerializeField] private Transform mermiyeri;

    [SerializeField] private Transform gun;

    float angle;

    [SerializeField] float donushizi = 8f;

    float ikiMermiarasiHiz = 200f;

    float sonrakiatis;

    [SerializeField] private GameObject[] mermiPrefab;

    private void Update()
    {
        RotateDegistir();
    }

    void RotateDegistir()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position;

        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;

        if (angle<45 && angle>-45)
        {
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            gun.transform.rotation = Quaternion.Slerp(gun.transform.rotation, rotation, donushizi * Time.deltaTime);

        }

        

        if (Input.GetMouseButtonDown(0)) 
        {
            

            if (Time.time > sonrakiatis) 
            {
                sonrakiatis = Time.time + ikiMermiarasiHiz / 1000;
                MermiAt();
            }

            
        }

        


        
    }


    void MermiAt()
    {
        GameObject mermi = Instantiate(mermiPrefab[Random.Range(0,mermiPrefab.Length)], mermiyeri.position, mermiyeri.rotation) as GameObject;
    }
    
}
