using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "QuestionSO", menuName = "Scriptable Objects/QuestionSO")]
public class QuestionSO : TextSO
{
    public List<AnswerSO> answers;
}
