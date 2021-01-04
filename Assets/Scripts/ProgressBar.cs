using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public RectTransform amount;
    public int increaseFactor;
    public GameObject losePanel;

    [HideInInspector]
    public bool filled;
    
    Vector2 initialSize;
    Vector2 initialOffsetMin;

    // Start is called before the first frame update
    void Start()
    {
        amount.gameObject.GetComponent<Image>().color = new Color(53f/255f, 206f/255f, 141f/255f, 1f);
        initialSize = amount.sizeDelta;
        initialOffsetMin = amount.offsetMin;
        filled = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if(amount.rect.width > 0 && !filled && !losePanel.activeSelf) {   
            amount.offsetMin += new Vector2(increaseFactor * Time.deltaTime, 0);
        }
        if(amount.rect.width <= 0){
            filled = true;
            amount.offsetMin = initialOffsetMin;
            amount.sizeDelta = initialSize;
            amount.gameObject.GetComponent<Image>().color = new Color(53f/255f, 206f/255f, 141f/255f, 1f);
        }
    }

    public void Unfill(){
        amount.gameObject.GetComponent<Image>().color = new Color(248f/255f, 241f/255f, 255f/255f, 1f);
        filled = false;
    }
}
