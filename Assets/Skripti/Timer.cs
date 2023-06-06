using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //objekti rezultāta paradīšanai
    public GameObject izkartne;
    public GameObject uzvara;
    public GameObject reset;
    //mainīgais, kurš skaita punktus (mašīnas uz paraizām vietām)
    public int punkti;
    public GameObject zvaigznes1;
    public GameObject zvaigznes2;
    public GameObject zvaigznes3;
    public float miliSecond;
    public int second;
    public int minute;
    public int hour;
    public Text text;
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

            switch (minute)
            {  // pieskaita zvaigznes attiecigi laikam 
                case 0: zvaigznes1.SetActive(true); break;
                case 1: zvaigznes2.SetActive(true); break;
                case 2: zvaigznes3.SetActive(true); break;
            }
        }
    }
    private void FixedUpdate() {
        while(punkti<12){
            miliSecond += 0.02f;
        }
        
        if (miliSecond >= 1) {
            second++;
            miliSecond = 0;
        }
        if (second >= 60) {
            minute++;
            second = 0;
        }
        if(minute >= 60) {
            hour++;
            minute = 0;
        }
        text.text = $"{hour} : {minute} : {second}";

       
    }

}
