using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Transform initialPoint;
    public Transform playPoint;
    public Transform sleepPoint;
    public Transform studyPoint;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = initialPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAction(){
        gameObject.transform.position = playPoint.position;
    }

    public void SleepAction(){
        gameObject.transform.position = sleepPoint.position;
    }

    public void StudyAction(){
        gameObject.transform.position = studyPoint.position;
    }
}
