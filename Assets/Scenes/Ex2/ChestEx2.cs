using UnityEngine;

public class ChestEx2 : MonoBehaviour, IDamageableEx2
{
    public void Hurt(int dmg)
    {
        Open();
    }
    public void Open()
    {
        Debug.Log("has trobat un tresor");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
