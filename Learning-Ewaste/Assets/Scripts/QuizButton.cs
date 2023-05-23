using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizButton : MonoBehaviour
{
    public void ClickRoom()
    {
        SceneManager.LoadScene("Quiz");
    }
}