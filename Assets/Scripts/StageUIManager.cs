using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//�X�e�[�WUI���Ǘ�(�X�e�[�W����UI/Next button/ BacktoTownButton)�̊Ǘ� 
public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public GameObject nextButton;
    public GameObject toTownButton;

    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("�X�e�[�W�F{0}", currentStage+1);
    }

    public void HideButtons()
    {
        nextButton.SetActive(false);
        toTownButton.SetActive(false);
    }
    public void ShowButtons()
    {
        nextButton.SetActive(true);
        toTownButton.SetActive(true);
    }
}
