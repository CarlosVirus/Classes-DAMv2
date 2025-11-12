using UnityEngine;

[CreateAssetMenu(fileName = "WarriorSO", menuName = "Scriptable Objects/WarriorSO")]
public class WarriorSO : CardSO
{
    public override void Action()
    {
        Debug.Log("Dar con palo");
    }
}
