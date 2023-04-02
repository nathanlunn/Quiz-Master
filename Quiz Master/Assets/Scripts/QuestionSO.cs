using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Questions")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter New Question Text Here";

    public string GetQuestion()
    {
        return question;
    }
}