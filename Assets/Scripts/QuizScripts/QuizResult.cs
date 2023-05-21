using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizResult: MonoBehaviour
{
    [SerializeField] private GameObject location0;
    [SerializeField] private GameObject location1;
    [SerializeField] private GameObject location2;
    [SerializeField] private GameObject location3;
    [SerializeField] private GameObject location4;
    [SerializeField] private GameObject location5;
    private int totalResult = 0;
    private bool flag = false;

    public void CalcResult()
    {
        location0.GetComponent<SlotScript>().SetSubmit(true);
        location1.GetComponent<SlotScript>().SetSubmit(true);
        location2.GetComponent<SlotScript>().SetSubmit(true);
        location3.GetComponent<SlotScript>().SetSubmit(true);
        location4.GetComponent<SlotScript>().SetSubmit(true);
        location5.GetComponent<SlotScript>().SetSubmit(true);
        this.flag = true;
    }

    void Update()
    {
        this.totalResult = 0;
        if (this.flag && location0.GetComponent<SlotScript>().done && location5.GetComponent<SlotScript>().done &&
            location1.GetComponent<SlotScript>().done && location2.GetComponent<SlotScript>().done && location3.GetComponent<SlotScript>().done && 
            location4.GetComponent<SlotScript>().done)
        {
            if(location0.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }
            if(location5.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }

            if(location1.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }
            if(location2.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }
            if(location3.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }
            if(location4.GetComponent<SlotScript>().GetResult())
            {
                totalResult ++;
            }

            if(totalResult >= 6) {
            Debug.Log("Success");
            }
            else
            {
                Debug.Log("No Success");
            }
            this.flag = false;
        }
        //if(location1.GetComponent<SlotScript>().GetResult())
        //{
        //    totalResult ++;
        //}
        //if(location2.GetComponent<SlotScript>().GetResult())
        //{
        //    totalResult ++;
        //}
        //if(location3.GetComponent<SlotScript>().GetResult())
        //{
        //    totalResult ++;
        //}
        //if(location4.GetComponent<SlotScript>().GetResult())
        //{
        //    totalResult ++;
        //}
    }
}