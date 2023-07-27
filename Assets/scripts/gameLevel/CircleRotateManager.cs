using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CircleRotateManager : MonoBehaviour
{

    string hangiSonuc;

    gameManager gameManager;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<gameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="mermi")
        {
            gameObject.transform.DORotate(transform.eulerAngles + Quaternion.AngleAxis(45, Vector3.forward).eulerAngles, 0.5f);


            if (collision.gameObject != null)
            {
                Destroy(collision.gameObject);
            }

            if (gameObject.name == "soldaire")
            {
                hangiSonuc = GameObject.Find("soltext").GetComponent<Text>().text;
            } else if(gameObject.name == "ortadaire")
            {
                hangiSonuc = GameObject.Find("ortatext").GetComponent<Text>().text;
            } else if(gameObject.name == "sagdaire")
            {
                hangiSonuc = GameObject.Find("sagtext").GetComponent<Text>().text;
            }

            gameManager.SonucuKontrolEt(int.Parse(hangiSonuc));

        }
    }

}
