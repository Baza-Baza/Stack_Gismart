﻿using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using System;
 
public class AdManager : MonoBehaviour
{
 
    //THE SCRIPT HAS ORIGNAL ID'S OF ADMOB
    InterstitialAd interstitial;
    BannerView bannerView;
    // Use this for initialization
    void Start()
    {
 
        RequestBanner();
        RequestInterstitial();
    }
 
 
    public void RequestBanner()
    {
   // replace this id with your orignal admob id for banner ad
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";
 
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
        bannerView.OnAdLoaded += HandleOnAdLoaded;
 
    }
 
    void HandleOnAdLoaded(object a, EventArgs args)
    {
        print("loaded");
        bannerView.Show();
    }
 
 
    public void RequestInterstitial()
    {
 
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
 
 
        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
 
 
    }
 
    public void show()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
 
 
}