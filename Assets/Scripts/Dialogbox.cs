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
    float _displaySpeed = 0.02f;

    [Multiline]
    [SerializeField]
    string _displayText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WriteText(_displayText));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WriteText(string displayText)
    {
        Font textFont = _dialogTextTop.font;
        float textLenght = 0;
        var charinfo = new CharacterInfo();
        char[] charset = displayText.ToCharArray();
        int fontsize = _dialogTextBot.fontSize;
        bool computeTopDialog = true;

        gameObject.SetActive(true);

        for (int i = 0; i < displayText.Length; i++)
        {
            textFont.GetCharacterInfo(charset[i], out charinfo, fontsize);
            textLenght += charinfo.advance;
            var test = GetComponent<RectTransform>();
            if ((textLenght >= GetComponent<RectTransform>().rect.width || charset[i] == '\n') && computeTopDialog)
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
            else if ((textLenght >= GetComponent<RectTransform>().rect.width || charset[i] == '\n') && !computeTopDialog)
            {
                yield return new WaitUntil(() => { return AdvanceDialog(); });

                if (charset[i] == ' ' || charset[i] == '\n')
                {
                    textLenght = 0;
                }
                else
                {
                    textLenght = charinfo.advance;
                }
            }

            if (computeTopDialog)
            {
                _dialogTextTop.text += charset[i];
            }
            else
            {
                _dialogTextBot.text += charset[i];
            }
        }

        yield return new WaitUntil(() => { return Input.GetKeyDown(KeyCode.E); });

        gameObject.SetActive(false);
        _dialogTextTop.text = "";
        _dialogTextBot.text = "";
    }

    private bool AdvanceDialog()
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
