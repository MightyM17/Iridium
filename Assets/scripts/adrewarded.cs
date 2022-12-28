using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;


public class adrewarded : MonoBehaviour, IUnityAdsListener
{
    string gameID="3545853";
    string myplacementid="rewardedVideo";
    bool testmode = false;
    int coins;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener (this);
        Advertisement.Initialize (gameID, testmode);
    }

    public void ShowRewardVideo()
    {
        Advertisement.Show (myplacementid);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            coins=PlayerPrefs.GetInt("coin");
            coins+=20;
            PlayerPrefs.SetInt("coin",coins);
        } else if (showResult == ShowResult.Skipped) {
            Debug.Log("Skip");
        } else if (showResult == ShowResult.Failed) {
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady (string placementId) {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myplacementid) {
            
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string placementId) {
        // Optional actions to take when the end-users triggers an ad.
    }
}
