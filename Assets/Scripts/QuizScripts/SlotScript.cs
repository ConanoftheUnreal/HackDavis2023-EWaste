using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Answers;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public int id;
    [SerializeField] private List<TYPES> a;
    [SerializeField] private List<int> b;
    private List<int> answers = new List<int>();
    private List<TYPES> potentialAnswers = new List<TYPES>();
    private List<bool> results = new List<bool>();
    private QuizAnswers correctAnswers;
    private bool submit = false;
    public bool result = false;
    [SerializeField] private int correctNeeded = 0;
    public bool done = false;

void Start()
{
    if (id == 3)
    {
        result = true;
    }
}

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");
       if (eventData.pointerDrag != null)
        {
            var x = eventData.pointerDrag.GetComponent<DragAndDrop>();
            if (answers.Contains(x.id))
            {
                Destroy(eventData.pointerDrag.gameObject);
                return;
            }

            if (id == 3)
            {
                result = false;
                return;
            }
            answers.Add(x.id);
            /*
            answers.Add(x.id);
            this.potentialAnswers.Add(x.group);
            Debug.Log(answers[id]);
            Debug.Log(potentialAnswers[id]);
            id ++;*/
            Debug.Log("========");
            //Debug.Log(b.Count);
            foreach (int answer in answers)
            {
                Debug.Log(answer);
            }
            /*if (TYPES.COMPUTER == (TYPES) 2)
            {
                Debug.Log("ENUMS works?");
            }*/
            Debug.Log("========");
            foreach (int answer in b)
            {
                //Debug.Log(answer);
                if (answers.Contains(answer))
                {
                    Debug.Log("here");
                    results.Add(true);
                    continue;
                }
                results.Add(false);
            }
            if (results.Contains(false))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Debug.Log("=========");
            foreach (bool r in results)
            {
                Debug.Log(r);
            }
            Debug.Log("========");
            results = new List<bool>();
            Debug.Log(result);
         }
    }
}
    /*
    public void SetSubmit(bool value)
    {
        this.submit = value;
    }

    public bool GetResult()
    {
        return this.result;
    }

    // Start is called before the first frame update
    void OnAwake()
    {
        this.correctAnswers = new QuizAnswers(a, correctNeeded);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.submit)
        {
            this.result = this.correctAnswers.checkAnswers(potentialAnswers, id);
            Debug.Log(this.result + this.gameObject.name);
            this.submit = false;
            this.done = true;
        }
    }*/

