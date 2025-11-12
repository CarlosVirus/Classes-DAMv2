using UnityEngine;

[CreateAssetMenu(fileName = "PriestSO", menuName = "Scriptable Objects/PriestSO")]
public class PriestSO : CardSO
{
    public override void Action()
    {
        Debug.Log("Healing shits");
    }
}
