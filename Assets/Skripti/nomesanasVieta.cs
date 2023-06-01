using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;

public class nomesanasVieta : MonoBehaviour, IDropHandler
{
    private float vietasZRot, velkObjZRot, rotacijasStarpiba;
    private Vector2 vietasIzm, velkObjIzm;
    private float xIzmeruStarp, yIzmeruStarp;
    public Objekti objectuScripts;



    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;

                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

                rotacijasStarpiba = Mathf.Abs(velkObjZRot - vietasZRot);

                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;

                vietasIzm = GetComponent<RectTransform>().localScale;

                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

                if ((rotacijasStarpiba <= 15 || (rotacijasStarpiba >= 345 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.2 && yIzmeruStarp <= 0.2))
                {

                    objectuScripts.vaiIstajaVieta = true;

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

                    switch (eventData.pointerDrag.tag)
                    {
                        case "atkritumi":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[1]);
                            break;
                        case "medicina":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[2]);
                            break;
                        case "buss":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[3]);
                            break;
                        case "cements":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[5]);
                            break;
                        case "b2":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[4]);
                            break;
                       
                        case "46":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[6]);
                            break;
                        case "61":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[7]);
                            break;
                        case "eskav":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[8]);
                            break;
                        case "policka":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[9]);
                            break;
                        case "traktor1":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[10]);
                            break;
                        case "traktor5":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[11]);
                            break;
                        case "uguni":
                            objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[12]);
                            break;
                    }
                }
            }
            else
            {
                objectuScripts.vaiIstajaVieta = false;
                objectuScripts.audioAvots.PlayOneShot(objectuScripts.skanasKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
                        objectuScripts.atkritumi.GetComponent<RectTransform>().localPosition = objectuScripts.atkrKoord;
                        break;
                    case "medicina":
                        objectuScripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objectuScripts.atraKord;
                        break;
                    case "buss":
                        objectuScripts.autobuss.GetComponent<RectTransform>().localPosition = objectuScripts.bussKord;
                        break;
                    case "cements":
                        objectuScripts.cementa.GetComponent<RectTransform>().localPosition = objectuScripts.cementaKord;
                        break;
                    case "b2":
                        objectuScripts.b2.GetComponent<RectTransform>().localPosition = objectuScripts.b2Kord;
                        break;
                    
                    case "46":
                        objectuScripts.e46.GetComponent<RectTransform>().localPosition = objectuScripts.e46Kord;
                        break;
                    case "61":
                        objectuScripts.e61.GetComponent<RectTransform>().localPosition = objectuScripts.e61Kord;
                        break;
                    case "eskav":
                        objectuScripts.eskavators.GetComponent<RectTransform>().localPosition = objectuScripts.eskavatorsKord;
                        break;
                    case "policka":
                        objectuScripts.policija.GetComponent<RectTransform>().localPosition = objectuScripts.policijaKord;
                        break;
                    case "traktor1":
                        objectuScripts.traktors1.GetComponent<RectTransform>().localPosition = objectuScripts.traktors1Kord;
                        break;
                    case "traktor5":
                        objectuScripts.traktors5.GetComponent<RectTransform>().localPosition = objectuScripts.traktors5Kord;
                        break;
                    case "uguni":
                        objectuScripts.uguns.GetComponent<RectTransform>().localPosition = objectuScripts.ugunsKord;
                        break;
                }
            }
        }
    }
}