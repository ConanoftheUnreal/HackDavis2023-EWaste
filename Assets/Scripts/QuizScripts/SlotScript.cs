using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Answers;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public int id;
    [SerializeField] private List<TYPES> a;
    private List<int> answers = new List<int>();
    private List<TYPES> potentialAnswers = new List<TYPES>();
    private QuizAnswers correctAnswers;
    private bool submit = false;
    private bool result = false;
    [SerializeField] private int correctNeeded = 0;
    public bool done = false;

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

            answers.Add(x.id);
            this.potentialAnswers.Add(x.group);
            Debug.Log(answers[id]);
            Debug.Log(potentialAnswers[id]);
            id ++;
         }
    }

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
    }
}
