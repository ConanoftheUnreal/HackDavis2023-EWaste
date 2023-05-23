using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryButtons : MonoBehaviour
{
    public void ClickPhoneComputer()
    {
        SceneManager.LoadScene("ComputerPhoneInfoGraphic");
    }
    public void ClickCord()
    {
        SceneManager.LoadScene("CordInfoGraphic");
    }
    public void ClickToaster()
    {
        SceneManager.LoadScene("ToasterInfoGraphic");
    }
    public void ClickBlender()
    {
        SceneManager.LoadScene("BlenderInfoGraphic");
    }
    public void ClickMicrowave()
    {
        SceneManager.LoadScene("MicrowaveInfoGraphic");
    }
    public void ClickRefrigerator()
    {
        SceneManager.LoadScene("RefrigeratorInfoGraphic");
    }
    public void ClickPrinter()
    {
        SceneManager.LoadScene("PrinterInfoGraphic");
    }
}