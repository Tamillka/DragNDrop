﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    public Canvas Canvas;

    public GameObject atkritumi;
    public GameObject atraPalidziba;
    public GameObject autobuss;
    public GameObject b2;
    public GameObject cementa;
    public GameObject e46; 
    public GameObject e61;
    public GameObject eskavators;
    public GameObject policija;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject uguns;

    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atraKord;
    [HideInInspector]
    public Vector2 bussKord;
    [HideInInspector]
    public Vector2 b2Kord;
    [HideInInspector]
    public Vector2 cementaKord;
    [HideInInspector]
    public Vector2 e46Kord;
    [HideInInspector]
    public Vector2 e61Kord;
    [HideInInspector]
    public Vector2 eskavatorsKord;
    [HideInInspector]
    public Vector2 policijaKord;
    [HideInInspector]
    public Vector2 traktors1Kord;
    [HideInInspector]
    public Vector2 traktors5Kord;
    [HideInInspector]
    public Vector2 ugunsKord;

    public Canvas canvas;

    public AudioSource audioAvots;
    public AudioClip[] skanasKoAtskanot;

    [HideInInspector]
    public bool vaiIstajaVieta = false;
    public GameObject pedejaisVilktais = null;


    //objekti rezultāta paradīšanai
    public GameObject izkartne;
    public GameObject uzvara;
    public GameObject reset;
    //mainīgais, kurš skaita punktus (mašīnas uz paraizām vietām)
    public int punkti;

    // Use this for initialization
    void Start()
    {
        atkrKoord = atkritumi.GetComponent<RectTransform>().localPosition;
        atraKord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Kord = b2.GetComponent<RectTransform>().localPosition;
        cementaKord = cementa.GetComponent<RectTransform>().localPosition;
        e46Kord = e46.GetComponent<RectTransform>().localPosition;
        e61Kord = e61.GetComponent<RectTransform>().localPosition;
        eskavatorsKord = eskavators.GetComponent<RectTransform>().localPosition;
        policijaKord = policija.GetComponent<RectTransform>().localPosition;
        traktors1Kord = traktors1.GetComponent<RectTransform>().localPosition;
        traktors5Kord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsKord = uguns.GetComponent<RectTransform>().localPosition;
    }
    public void beigas() {
        //kad visas mašīnas uz vietām, ieslēdz visus objektus, kuri nepieciešami rezultata paradīšanai
        if (punkti == 12) {
            izkartne.SetActive(true);
            uzvara.SetActive(true);
            reset.SetActive(true);
        }
    }
}