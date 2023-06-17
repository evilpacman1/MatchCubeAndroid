using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrueOrNot : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] answerCube;
    public GameObject _false;
    public GameObject falePlant;
    public void True() 
    { 
        for (int i = 0; i < answerCube.Length; i++) 
        {

            answerCube[i].SetActive(true);

        }
    
    }
    public void falseAnswer()
    {
        StartCoroutine(WhateFall());
    }

  IEnumerator WhateFall() 
    { 
        falePlant.SetActive(true);
        _false.SetActive(true);
        yield return new WaitForSeconds(1f);
        falePlant.SetActive(false);
        _false.SetActive(false);
    
    }

}
