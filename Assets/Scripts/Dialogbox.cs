using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogbox : MonoBehaviour
{
    [SerializeField]
    Text _dialogTextTop;
    [SerializeField]
    Text _dialogTextBot;
    [SerializeField]
    Image _picker;
    [SerializeField]
    float _displaySpeed = 0.02f;

    //Please dont kill me :(
    public static Dialogbox instance;

    DialogNode _node;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void StartDialogTree(DialogNode node)
    {
        _node = node;
        BeginWriteText(_node.GetDisplayText(StartDialogTree));
    }

    public void BeginWriteText(string displayText)
    {
        StartCoroutine(WriteText(displayText));
    }

    public void OptionSelect(DialogOptionsNode dialogOptionsNode)
    {
        throw new NotImplementedException();
    }

    IEnumerator WriteText(string displayText)
    {
        Font textFont = _dialogTextTop.font;
        float textLenght = 0;
        var charinfo = new CharacterInfo();
        char[] charset = displayText.ToCharArray();
        int fontsize = _dialogTextBot.cachedTextGenerator.fontSizeUsedForBestFit;
        bool computeTopDialog = true;

        gameObject.SetActive(true);

        for (int i = 0; i < displayText.Length; i++)
        {
            textFont.GetCharacterInfo(charset[i], out charinfo, fontsize);
            textLenght += charinfo.advance;
            var test = GetComponent<RectTransform>();
            var test2 = transform;
            if ((textLenght >= GetComponent<RectTransform>().rect.width - 100 || charset[i] == '\n') && computeTopDialog)
            {
                computeTopDialog = false;

                if (charset[i] == ' ' || charset[i] == '\n')
                {
                    textLenght = 0;
                }
                else
                {
                    textLenght = charinfo.advance;
                }
            }
            else if ((textLenght >= GetComponent<RectTransform>().rect.width - 100 || charset[i] == '\n') && !computeTopDialog)
            {
                yield return new WaitUntil(() => { return ShouldAdvanceText(); });

                if (charset[i] == ' ' || charset[i] == '\n')
                {
                    textLenght = 0;
                }
                else
                {
                    textLenght = charinfo.advance;
                }
            }
            if (charset[i] == '\n')
                continue;

            if (computeTopDialog)
            {
                _dialogTextTop.text += charset[i];
                yield return new WaitForSeconds(_displaySpeed);
            }
            else
            {
                _dialogTextBot.text += charset[i];
                yield return new WaitForSeconds(_displaySpeed);
            }
        }

        yield return new WaitUntil(() => { return Input.GetKeyDown(KeyCode.E); });

        gameObject.SetActive(false);
        _dialogTextTop.text = "";
        _dialogTextBot.text = "";
        _node.AdvanceDialogTree();
    }

    private bool ShouldAdvanceText()
    {
        bool keypressed = Input.GetKeyDown(KeyCode.E);
        if (keypressed)
        {
            _dialogTextTop.text = _dialogTextBot.text;
            _dialogTextBot.text = "";
        }
        return keypressed;
    }
}
