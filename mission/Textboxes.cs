using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textboxes  {
    public int textboxID { get; private set; }
    public int QuestID { get; private set; }
 public Textboxes (int boxid,int questid)
    {
        this.textboxID = boxid;
        this.QuestID = questid;
    }   
}
