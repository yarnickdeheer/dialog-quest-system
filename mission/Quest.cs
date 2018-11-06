using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Quest{
    public string TextLine;
    public int QuestID { get; private set; }
    public int ItemRewardID { get; private set;}
    public bool Completed { get;set; }


    public Quest(int questid ,int itemRewardId , string QuestTextLine)
    {
        this.QuestID = questid;
        this.ItemRewardID = itemRewardId;
        this.TextLine= QuestTextLine;
        this.Completed = false;

    }
}

