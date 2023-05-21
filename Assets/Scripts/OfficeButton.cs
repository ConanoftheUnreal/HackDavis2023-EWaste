using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficeButton : MonoBehaviour
{
    public void ClickRoom()
    {
        SceneManager.LoadScene("OfficeView");
    }
}