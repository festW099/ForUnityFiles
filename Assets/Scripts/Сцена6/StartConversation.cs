using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class StartConversation : MonoBehaviour
{
    [SerializeField] private NPCConversation GregoryConversation;
    public Animator animBtn;
    public void Click()
    {
        ConversationManager.Instance.StartConversation(GregoryConversation);
        animBtn.SetBool("StartOpen", false);
    }
}
