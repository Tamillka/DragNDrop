using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //objekti rezultāta paradīšanai
    public GameObject izkartne;
    public GameObject uzvara;
    public GameObject reset;
    public GameObject zvaigznes1;
    public GameObject zvaigznes2;
    public GameObject zvaigznes3;
    //mainīgais, kurš skaita punktus (mašīnas uz paraizām vietām)
    public int punkti;
    //laika mērvienības
    public float miliSecond;
    public int second;
    public int minute;
    public int hour;
    //teksta logs, kurš rada laiku
    public GameObject laikaPar;

    public void beigas()
    {
        //kad visas mašīnas uz vietām, ieslēdz visus objektus, kuri nepieciešami rezultata paradīšanai
        if (punkti == 12)
        {
            izkartne.SetActive(true);
            uzvara.SetActive(true);
            reset.SetActive(true);
            laikaPar.SetActive(true);

            // skatoties uz minūšu skaitu, piesaista un ieslēdz zvaigznes
            switch (minute) { 
                case 0: zvaigznes3.SetActive(true); break;
                case 1: case 2: zvaigznes2.SetActive(true); break;
            }
            // ja laiks ir vairak par 3 minutēm, tad viena svaigzne 
            if (minute >= 3)          
                 zvaigznes1.SetActive(true);
        }
    }
    private void FixedUpdate() {
        //ja visas mašīnas nav uz vietām, pieskaita milisekundes
        if (punkti < 12)
            miliSecond += 0.02f;

        //kad ir vismaz viena milisekunde, tā paliek par 0 un parveršas uz sekundi
        if (miliSecond >= 1) {
            second++;
            miliSecond = 0;
        }
        //kad ir vismaz 60 sekundes, tās paliek par 0 un parveršas uz minūti
        if (second >= 60) {
            minute++;
            second = 0;
        }
        //kad ir vismaz 60 minūtes, tās paliek par 0 un parveršas uz stundu
        if (minute >= 60) {
            hour++;
            minute = 0;
        }

        //laika attēlošana teksta logā
        laikaPar.GetComponent<Text>().text = $"{hour} : {minute} : {second}"; 
    }
}
