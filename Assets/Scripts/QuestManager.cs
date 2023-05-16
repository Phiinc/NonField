using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クエスト全体を管理

public class QuestManager : MonoBehaviour

{
   
    public StageUIManager stageUI;
    //敵に遭遇するテーブル: -1なら遭遇しない、0なら遭遇
    int[] encountTable = { -1, -1, 0, -1, 0, -1 };
    
    int currentStage = 0; //現在のステージ

    private void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    //Next buttonを押されたら
    public void OnNextButton()
    {
        currentStage++;
        //進行度をUIに反映
        stageUI.UpdateUI(currentStage);

        if(encountTable.Length <= currentStage)
        {
            Debug.Log("クエストクリア");
            //クリア処理
        }

        else if (encountTable[currentStage] == 0)
        {
            Debug.Log("敵に遭遇");
        }
    }
}
