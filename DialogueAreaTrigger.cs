using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DialogueAreaTrigger : MonoBehaviour

{ 
    public Animator animator;
    public bool ignoreTrigger;
    public Dialogue dialogue;
    bool enter;
    public List<Quest> questList = new List<Quest> ();
    public List<Textboxes> questtextboxes = new List<Textboxes>();

    // Use this for initialization
    void Start()
    {
        enter = false;
        questList[0] = QuestDatabase.questList[0];
        questList[1] = QuestDatabase.questList[1];
        //questList[0].Completed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enter==true && Input.GetKey(KeyCode.E))
        {
            animator.SetBool("open", true);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
       // if (enter == false)
       // {
            //animator.SetBool("open", false);
           
       // }

    }
    void OnTriggerEnter(Collider target)
    {
        if (ignoreTrigger)
            return;
        if (target.gameObject.tag == "Player")
        {
            enter = true;

        }
    }
    void OnTriggerExit(Collider target)
    {
        if (target.gameObject.tag == "Player")
        {
            enter = false;
            animator.SetBool("open", false);
        }
    }
    public void Toggle(bool value)
    {
        if (value)
        {
            enter = true;
        }
        else
        {
            enter = false;
        }
    }
    public void TriggerQuest()
    {
        Debug.Log("trigger quest");
        if (questList[0] !=null) {
                
            if (questList[0].Completed)
            {
                Debug.Log("ja");
                FindObjectOfType<MissionManager>().StartQuest(questList[1], questtextboxes[0]);
            }
            Debug.Log("ja test");
            FindObjectOfType<MissionManager>().StartQuest(questList[0], questtextboxes[0]);
        }
    }

    void OnDrwaGizmos()
    {
        Gizmos.color = ignoreTrigger ? Color.gray : Color.green;
        var bc2D = GetComponent<BoxCollider2D>();
        var pos = bc2D.transform.position;

        var newPos = new Vector2(pos.x + bc2D.offset.x, pos.y + bc2D.offset.y);
        Gizmos.DrawWireCube(newPos, new Vector2(bc2D.size.x, bc2D.size.y));

        
    }
}