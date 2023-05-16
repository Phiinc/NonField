using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クエスト全体を管理

public class QuestManager : MonoBehaviour

{
   
    public StageUIManager stageUI;
    
    int currentStage = 0; //現在のステージ

    private void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    //Next buttonを押されたら
    public void OnNextButton()
    {
        currentStage++;
        Debug.Log("進行度増加" + currentStage);
        //進行度をUIに反映
        stageUI.UpdateUI(currentStage);
    }
}
