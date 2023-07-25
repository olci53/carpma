using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject baslaImage;

    string hangiOyun;
    float birinciCarpan;
    float ikinciCarpan;
    float dogruSonuc;
    float birinciYanlisSonuc, ikinciYanlisSonuc;
    [SerializeField] private Text soruText,birinciText,ikinciText,ucuncuText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("hangiOyun"))
        {
            hangiOyun = PlayerPrefs.GetString("hangiOyun");

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

        OyunaBasla();

        SoruyuYazdir();
    }

    void OyunaBasla()
    {
        BirinciCarpaniAyarla();
    }

    void BirinciCarpaniAyarla()
    {
        switch (hangiOyun)
        {
            case "iki":
                birinciCarpan = 2;
                break;

            case "üç":
                birinciCarpan = 3;
                break;
            
            case "dört":
                birinciCarpan = 4;
                break;

            case "beþ":
                birinciCarpan = 5;
                break;

            case "altý":
                birinciCarpan = 6;
                break;

            case "yedi":
                birinciCarpan = 7;
                break;

            case "sekiz":
                birinciCarpan = 8;
                break;

            case "dokuz":
                birinciCarpan = 9;
                break;

            case "on":
                birinciCarpan = 10;
                break;

            case "karýþýk":
                birinciCarpan = Random.Range(2,11);
                break;

        }

        //Debug.Log(birinciCarpan);

    }

    void SoruyuYazdir()
    {
        BirinciCarpaniAyarla();

        ikinciCarpan = Random.Range(2, 51);

        int rastgeleDeger = Random.Range(1, 100);

        if (rastgeleDeger<= 50)
        {
            soruText.text = birinciCarpan.ToString() + "x" + ikinciCarpan.ToString();
        }
        else
        {
            soruText.text = ikinciCarpan.ToString() + "x" + birinciCarpan.ToString();
        }

        dogruSonuc = birinciCarpan * ikinciCarpan;

        sonucText();
    }

    void sonucText()
    {
        birinciYanlisSonuc = dogruSonuc + Random.Range(2, 10);

        if (dogruSonuc>10)
        {
            ikinciYanlisSonuc = dogruSonuc - Random.Range(2, 8);
        }else
        {
            ikinciYanlisSonuc = Mathf.Abs(dogruSonuc - Random.Range(1, 5));
        }

        int rastgeleDeger = Random.Range(1, 100);

        if (rastgeleDeger<=33)
        {
            birinciText.text = dogruSonuc.ToString();
            ikinciText.text = birinciYanlisSonuc.ToString();
            ucuncuText.text = ikinciYanlisSonuc.ToString();
        }
        else if (rastgeleDeger<=66)
        {
            ikinciText.text = dogruSonuc.ToString();
            birinciText.text = birinciYanlisSonuc.ToString();
            ucuncuText.text = ikinciYanlisSonuc.ToString();
        }
        else
        {
            ucuncuText.text = dogruSonuc.ToString();
            ikinciText.text = birinciYanlisSonuc.ToString();
            birinciText.text = ikinciYanlisSonuc.ToString();
        }
            
    }


}
