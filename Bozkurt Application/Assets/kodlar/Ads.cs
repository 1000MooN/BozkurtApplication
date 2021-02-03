using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using UnityEngine.UI;
public class Ads : MonoBehaviour
{
      string gameID = "3475609";
    string placementId = "Sabit";

   
    public GameObject startMenu;
 
    private IEnumerator Start()
    {
        Advertisement.Initialize(gameID, false);
        while (!Advertisement.IsReady(placementId))
            yield return null;

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(placementId);
   
    }
   
    public void ReklamSay()
    {


        /*  if (OnUp.x == 2)
          {
              if (Advertisement.IsReady())
              {
                  Advertisement.Show();
                  OnUp.x = 0;
              }

          */
    }
 
    /* public void ShowFullScreenAdd()
    {
        if (fullScreenAd.IsLoaded())
        {
           // if (OnUp.x == 2)
            //{
                fullScreenAd.Show();
                OnUp.x = 0;
            //}

        }
        else
        {
            Debug.Log("Reklam Yoq");
        }
    */}
   


