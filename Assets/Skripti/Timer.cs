using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public GameObject zvaigznes1;
    public GameObject zvaigznes2;
    public GameObject zvaigznes3;
    public GameObject laikaPar;
    public float miliSecond;
    public float second;
    public float minute;
    public float hour;
    public Text text;

    private void FixedUpdate() {
        miliSecond += 0.02f;
        if (miliSecond == 1) {
            second++;
            miliSecond = 0;
        }
        if (second == 60) {
            minute++;
            second = 0;
        }
        if(minute == 60) {
            hour++;
            minute = 0;
        }
        text.text = $"{hour} : {minute} : {second}";
       /* switch (minute)
        {  // pieskaita zvaigznes attiecigi laikam 
            case 0: zvaigznes1.SetActive(true); break;
            case 1: zvaigznes2.SetActive(true); break;
            case 2: zvaigznes3.SetActive(true); break;
       }*/
    }

}
