using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public float distPlayer;
    public Dialogue dialogue;
    public float minDist = 2f;
    public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
       distPlayer = Vector3.Distance(player.transform.position, gameObject.transform.position);
       if(distPlayer <= minDist && Input.GetKeyDown(KeyCode.Z))
        {
            TriggerDialogue();
        }
    }
}
