using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MissionManager : MonoBehaviour {
    public List<Text> questtextboxes = new List<Text>();
    private string[] Quests;
    private int maxquests;
    
    public Quest quest;
    public Textboxes textboxes;
    
    // Use this for initialization
    void Start() {
        
    }
    public void StartQuest(Quest quest, Textboxes textboxes)
    {
        if(quest==null)
        {
            return;
        }

        /*  if (questTextboxes[0].text == "")
          {
              questTextboxes[0].text = quest.TextLine;

          }*/
        

        for (int i = 0;  i < questtextboxes.Count; i++)
        {
            if (questtextboxes[i].text == "" && questtextboxes[i].text != quest.TextLine /*&& textboxes.QuestID != quest.QuestID*/)
            {
                questtextboxes[i].text = quest.TextLine;
                return;
            
            }else if (questtextboxes[i].text == quest.TextLine)
            {
            return;
            }
        }


    }
}
