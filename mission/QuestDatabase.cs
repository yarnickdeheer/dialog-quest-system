using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestDatabase : MonoBehaviour {
    public static List<Quest> questList = new List<Quest>();
    // (int questid ,int itemRewardId , string QuestTextLine)
    void Start () {
        questList[0] = new Quest(0, 0, "bammetje");
        questList[1] = new Quest(1, 0, "bammetje test");
        questList[2] = new Quest(2, 0, "bammetje test2");
        questList[3] = new Quest(3, 0, "bammetje test3");
        questList[4] = new Quest(4, 0, "bammetje test4");
    }

    
    void Update () {
		
	}
}
