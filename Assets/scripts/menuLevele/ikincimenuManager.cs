using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ikincimenuManager : MonoBehaviour
{
    [SerializeField] private GameObject ikincimenupanel;


    private void Start()
    {
        ikincimenupanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        ikincimenupanel.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);

    }

    public void geridon()
    {
        SceneManager.LoadScene("menuLevel");

    }




}
