
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class OnUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Button myButton;
    public Sprite Button2;
    public Animator res;
    string gameID = "3475609";
    string VideoID = "video";
     
    void  Start()
    {
        myButton.GetComponent<Button>();
        Advertisement.Initialize(gameID, false);
    }
 
    // Update is called once per frame
    // Update is called once per frame
    public static float sayac = 0;
    public static float x = 0;
    public static int sayac2 = 1;
  
    public void ButonResmiBırakınca()
    {
        res.Play("New Animation", -1, 0f);
        x++;
        myButton.image.overrideSprite = Button2;
        //SceneManager.LoadScene(0);
        sayac++;
        if(sayac2%3==0)
        {
            Advertisement.Banner.Hide();
            Advertisement.Show(VideoID);
          
        }
     
        sayac2++;
    }
}
