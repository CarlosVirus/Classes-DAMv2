using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
public class NPC : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button next;
    public GameObject parent;
    public NPCSO nPCSO;
    private int _counter = 0;
    public Button button;
    private int _sequence =0;
    private void Awake()
    {
        button = parent.GetComponentInChildren<Button>();
        button.gameObject.SetActive(false);
        LoadText(_counter);
    }
    public void Next()
    {
        /*if (nPCSO.textSOs[_counter] is QuestionSO)
        {

        }*/
        _counter++;
        LoadText(_counter);   
    }
    public void Next(int i)
    {
        _counter+= i;
        LoadText(_counter);
    }
    public void LoadText(int i)
    {
        var typer = nPCSO.GetType();
        if(nPCSO.textSOs[i] is QuestionSO)
        {
            text.text = nPCSO.textSOs[i].text;
            QuestionSO question = (QuestionSO)nPCSO.textSOs[i];
            for (int j = 0; j < question.answers.Count; j++)
            {
                var buttonn = Instantiate(button, parent.transform);
                buttonn.GetComponentInChildren<TextMeshProUGUI>().text = question.answers[j].text;
                buttonn.gameObject.SetActive(true);
                button.GetComponent<Button>().onClick.AddListener(Next);
            }
            Debug.Log("QUESTION");
        }
        else
        {
            text.text = nPCSO.textSOs[i].text;
            var Children = parent.GetComponentsInChildren<Transform>();
            for (int j = 1; j < parent.GetComponentsInChildren<Transform>().Length; j++)
                Destroy(Children[j]);
            Debug.Log("NOT A QUESTION");
        }
    }
    
}
