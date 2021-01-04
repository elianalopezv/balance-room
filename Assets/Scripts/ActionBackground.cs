using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionBackground : MonoBehaviour
{
    public Sprite StudyAction1;
    public Sprite StudyAction2;
    public Sprite TVAction1;
    public Sprite TVAction2;
    public Sprite BedAction1;
    public Sprite BedAction2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBackgroundAction(string action){
        switch (action)
      {
          case "study_1":
              gameObject.GetComponent<Image>().sprite = StudyAction1;
              break;
          case "study_2":
              gameObject.GetComponent<Image>().sprite = StudyAction2;
              break;
          case "tv_1":
              gameObject.GetComponent<Image>().sprite = TVAction1;
              break;
          case "tv_2":
              gameObject.GetComponent<Image>().sprite = TVAction2;
              break;
          case "bed_1":
              gameObject.GetComponent<Image>().sprite = BedAction1;
              break;
          case "bed_2":
              gameObject.GetComponent<Image>().sprite = BedAction2;
              break;
          default:
              gameObject.GetComponent<Image>().sprite = StudyAction1;
              break;
      }
    }
}
