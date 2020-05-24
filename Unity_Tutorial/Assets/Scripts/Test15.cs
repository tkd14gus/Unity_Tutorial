using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}
public class Test15 : MonoBehaviour
{

    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialouge;

    public void ShowDialogue()
    {
        //sprite_DialogueBox.gameObject.SetActive(true);
        //sprite_StandingCG.gameObject.SetActive(true);
        //txt_Dialogue.gameObject.SetActive(true);

        OnOff(true);
        count = 0;
        NextDialogue();
    }

    //private void HideDialogue()
    //{
    //    sprite_DialogueBox.gameObject.SetActive(false);
    //    sprite_StandingCG.gameObject.SetActive(false);
    //    txt_Dialogue.gameObject.SetActive(false);
    //    
    //    isDialogue = false;
    //}
    private void OnOff(bool _flage)
    {
        sprite_DialogueBox.gameObject.SetActive(_flage);
        sprite_StandingCG.gameObject.SetActive(_flage);
        txt_Dialogue.gameObject.SetActive(_flage);
        isDialogue = _flage;
    }
    private void NextDialogue()
    {
        txt_Dialogue.text = dialouge[count].dialogue;
        sprite_StandingCG.sprite = dialouge[count].cg;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialouge.Length)
                    NextDialogue();
                else
                    //HideDialogue();
                    OnOff(false);
            }
        }
    }
}
