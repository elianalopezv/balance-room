using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthBar : MonoBehaviour
{
    public RectTransform amount;
    public int decreaseFactor;
    public GameObject losePanel;
    public Text loseText;
    public Text timeText;
    public string barName;
    float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(amount.rect.width > 0 && !losePanel.activeSelf) {   
            amount.offsetMax -= new Vector2(decreaseFactor * Time.deltaTime, 0);
            timeElapsed += Time.deltaTime;
        } else if(!losePanel.activeSelf) {
                loseText.text= "Parece que te quedaste sin " + barName; 
                timeText.text= "No paraste durante " + Math.Round(timeElapsed, 1) + " segundos"; 
                losePanel.SetActive(true);
        }
        
    }

    public void ModifyBarAmount(int factor){
        float minFactor;
        if(Math.Abs(decreaseFactor * timeElapsed) < Math.Abs(factor)){
            minFactor = decreaseFactor * timeElapsed * Math.Sign(factor);
        } else {
            minFactor = factor;
        }
        amount.offsetMax -= new Vector2(minFactor, 0);
    }
}
