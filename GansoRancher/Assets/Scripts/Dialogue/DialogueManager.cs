using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public GameObject dialogueObj;
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        dialogueObj.SetActive(false);
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue){
        dialogueObj.SetActive(true);
        sentences.Clear();

        nameText.text = dialogue.name;

        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue(){
        Debug.Log("End of conversation");
        dialogueObj.SetActive(false);
    }
}
