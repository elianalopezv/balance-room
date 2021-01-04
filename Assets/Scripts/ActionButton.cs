using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    public ProgressBar bar;
    public GameObject losePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!bar.filled || losePanel.activeSelf) gameObject.GetComponent<Button>().interactable = false;
        else gameObject.GetComponent<Button>().interactable = true;
    }
}
