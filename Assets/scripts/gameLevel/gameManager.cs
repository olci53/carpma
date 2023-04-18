using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject baslaImage;


    private void Start()
    {
        if(PlayerPrefs.HasKey("Hangi Oyun"))
        {
            

           // Debug.Log(PlayerPrefs.GetString("Hangi Oyun"));
        }

        StartCoroutine(baslaYazisi());
    }

    IEnumerator baslaYazisi()
    {
        baslaImage.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        baslaImage.GetComponent<RectTransform>().DOScale(1.3f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        baslaImage.GetComponent<RectTransform>().DOScale(0, 1f);
        baslaImage.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
        yield return new WaitForSeconds(1f);

        Oyunabasla();

    }


    void Oyunabasla()
    {
        Debug.Log("basladi");

    }
}
