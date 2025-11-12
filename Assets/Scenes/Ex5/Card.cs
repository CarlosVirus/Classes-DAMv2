using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] CardSO cardSO;
    private string Name;
    private string Description;
    private int HP;
    private int Damage;
    private Sprite Image;

    private SpriteRenderer _sr;
    public void Awake()
    {
        _sr = GetComponent<SpriteRenderer>();
        CardInjection();
    }
    public void CardInjection()
    {
        Name = cardSO.Name;
        Description = cardSO.Description;
        HP = cardSO.HP;
        Damage = cardSO.Damage;
        _sr.sprite = cardSO.Image;
    }
    private void Update()
    {
        cardSO.Action();
    }
}
