using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class asdasd : MonoBehaviour
{
    // Start is called before the first frame update
    public Button myButton;
    public Sprite Button1;
    string placementId = "Sabit";
    string gameID = "3475609";
    private IEnumerator Start()
    {
        myButton = GetComponent<Button>();

        Advertisement.Initialize(gameID, true);
        while (!Advertisement.IsReady(placementId))
            yield return null;

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(placementId);
        
    }
    public void ButonResmıTıklanınca()
    {
     
        myButton.image.overrideSprite = Button1;
           if (OnUp.sayac2 % 3 != 0)
        {
            
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            Advertisement.Banner.Show(placementId);
        }
    }
}
