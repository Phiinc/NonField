using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//ステージUIを管理(ステージ数のUI/Next button/ BacktoTownButton)の管理 
public class StageUIManager : MonoBehaviour
{
    public Text stageText;

    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("ステージ：{0}", currentStage+1);
    }
}
