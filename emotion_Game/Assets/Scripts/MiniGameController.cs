using UnityEngine;
using TMPro;

public class MiniGameController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public Renderer childRenderer; // נגרור לכאן את הילד

    void Start()
    {
        dialogueText.text = "The house is a mess. What is your move?";
        childRenderer.material.color = Color.white; // צבע רגיל בהתחלה
    }

    public void OnChoiceSelected(int choiceIndex)
    {
        if (choiceIndex == 1) // תוקפני
        {
            dialogueText.text = "Father: 'STOP IT NOW!' \nChild is angry and red.";
            childRenderer.material.color = Color.red;
        }
        else if (choiceIndex == 2) // סקרן
        {
            dialogueText.text = "Father: 'What happened?' \nChild is confused (Yellow).";
            childRenderer.material.color = Color.yellow;
        }
        else if (choiceIndex == 3) // אמפתי
        {
            dialogueText.text = "Father: 'I see you're busy.' \nChild feels safe (Green).";
            childRenderer.material.color = Color.green;
        }
    }
}