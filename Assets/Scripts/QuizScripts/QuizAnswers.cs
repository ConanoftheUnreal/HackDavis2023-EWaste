using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Answers;

//[CreateAssetMenu]
namespace Answers
{
    public class QuizAnswers
    {
        private List<TYPES> answers;
        private int correctNeeded;

/*
        public QuizAnswers (List<TYPES> answers, int correctNeeded)
        {
            this.answers = new List<TYPES>(answers);
            this.correctNeeded = correctNeeded;
        }

        public bool checkAnswers(List<TYPES> currentAnswers, int length)
        {
            int correct = 0;
            int incorrect = 0;
            for (int i = 0; i < length; i ++)
            {
                Debug.Log(currentAnswers[i]);
                if(this.answers.Contains(currentAnswers[i]))
                {
                    correct++;
                    break;
                }
                else
                {
                    incorrect++;
                }
            }
            if (correct < this.correctNeeded || incorrect != 0)
            {
                Debug.Log("Incorrect " + incorrect);
                Debug.Log("Correct " + correct);
                return false;
            }
            return true;
        }
    }*/
    }
}