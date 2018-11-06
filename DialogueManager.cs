using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QuestSystem;
public class DialogueManager : MonoBehaviour {
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    private Queue<string> sentences;
    private string[] names;
    public Dialogue dialogue;
    private QuestTracker questTracker;

    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
        questTracker = GameObject.FindObjectOfType<QuestTracker>();
    }
	
    public void StartDialogue (Dialogue dialogue)
    {
        
        animator.SetBool("open", true);

        names = dialogue.names;
        nameText.text = names[0];
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
       
    }


    public void DisplayNextSentence()
    {
        
        
       
        if (sentences.Count % 2 == 1)
        {
            nameText.text = names[1];
            
        }
        else
        {               
            nameText.text = names[0];            
        }
        if (sentences.Count == 0)
        {
            StopAllCoroutines();
            Debug.Log("sentences 0");
            //FindObjectOfType<DialogueAreaTrigger>().TriggerQuest();
            if (names[0] == "jack") {
                questTracker.quest1();
            }
            if (names[0] == "chicken")
            {
                questTracker.quest2();
            }
            animator.SetBool("open", false);
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }
   
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            DisplayNextSentence();
        }
    }
}
