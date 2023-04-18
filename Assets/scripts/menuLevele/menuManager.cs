using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;



    private void Start()
    {
        menuPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPanel.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);

    }

    public void basla()
    {
        SceneManager.LoadScene("ikinciMenu");
    }

    public void ayarlar()
    {

    }

    public void cýkýs()
    {
        Application.Quit();
    }

   

}
