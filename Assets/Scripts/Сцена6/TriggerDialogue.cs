using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TriggerDialogue : MonoBehaviour
{
    [SerializeField] private NPCConversation GregoryConversation;
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ConversationManager.Instance.StartConversation(GregoryConversation);        
        }
    }
}
