using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizResult: MonoBehaviour
{
    [SerializeField] private GameObject location0;
    [SerializeField] private GameObject location1;
    [SerializeField] private GameObject location2;
    [SerializeField] private GameObject location3;
    [SerializeField] private GameObject location4;
    [SerializeField] private GameObject location5;
    [SerializeField] private GameObject fail;
    [SerializeField] private GameObject success;
    [SerializeField] private GameObject button;
    [SerializeField] private Canvas myCanvas;
    private List<bool> result = new List<bool>();
    private int totalResult = 0;
    private bool flag = false;

    public void CalcResult()
    {
        GameObject x;
        result.Add(location0.GetComponent<SlotScript>().result);
        result.Add(location1.GetComponent<SlotScript>().result);
        result.Add(location2.GetComponent<SlotScript>().result);
        result.Add(location3.GetComponent<SlotScript>().result);
        result.Add(location5.GetComponent<SlotScript>().result);
        result.Add(location4.GetComponent<SlotScript>().result);
        if (result.Contains(false))
        {
            Debug.Log("fail");
            x = Instantiate(fail);
            x.transform.SetParent(myCanvas.transform, false);
        }
        else
        {
            Debug.Log("success");
            x = Instantiate(success);
            x.transform.SetParent(myCanvas.transform, false);
        }
        SceneManager.LoadScene("ExitView");
        //x = Instantiate(button);
        //x.transform.SetParent(myCanvas.transform, false);
    }

    /*void Update()
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
    }*/
}