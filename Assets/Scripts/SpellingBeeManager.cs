using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BiologySpellingBee : MonoBehaviour
{
    public InputField inputField;
    private int questionArrayNumber = 0;
    public Canvas questionCanvas, answerCanvas;
    public Image descriptionPanel, correctionPanel;
    public Text descriptionText, correctionText;
    public GameObject beeGirlChar, fortuneTellerChar;
    public BeeGirlChar beeGirlCharScript;
    void Start()
    {
        PlayQuestion();
    }

    public void PlayQuestion()
    {
        questionCanvas.GetComponent<CanvasGroup>().blocksRaycasts = true;
        questionCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;

        // play question audio
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);

        // change to answer view
        StartCoroutine(ChangeStageCoroutine());
    }

    IEnumerator ChangeStageCoroutine()
    {
        // change to answer view
        yield return new WaitForSeconds(2);

        questionCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        questionCanvas.GetComponent<CanvasGroup>().blocksRaycasts = false;
        answerCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;
        fortuneTellerChar.SetActive(false);
        beeGirlChar.GetComponent<Renderer>().enabled = true;
    }

    public void CheckButton()
    {
        if (inputField.text == Biology_2_1_QuestionBank.questions[questionArrayNumber].answer)
        {
            beeGirlCharScript.CorrectAnimation();
        //    StartCoroutine(NextCoroutine());

        }
        else
        {
            beeGirlCharScript.IncorrectAnimation();
          //  StartCoroutine(CorrectionOpenCoroutine());
        }

         StartCoroutine(NextCoroutine());
    }

    IEnumerator CorrectionOpenCoroutine()
    {
        yield return new WaitForSeconds(2);

        correctionPanel.GetComponent<CanvasGroup>().alpha = 1.0f;
        // change to question view
        answerCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        beeGirlChar.GetComponent<Renderer>().enabled = false;
        beeGirlCharScript.NeutralAnimation();
    }

    // public void CorrectionClose()
    // {
    //     correctionPanel.GetComponent<CanvasGroup>().alpha = 0.0f;
    // }

    IEnumerator NextCoroutine()
    {
        yield return new WaitForSeconds(2);

        // clear input field
        inputField.text = "";

        // change to next question
        questionArrayNumber++;
        PlayQuestion();

        // change to question view
        answerCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        fortuneTellerChar.SetActive(true);
        beeGirlChar.GetComponent<Renderer>().enabled = false;
        beeGirlCharScript.NeutralAnimation();
    }

    public void RepeatButton()
    {
        // play question audio
        GameObject soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playQuestionSound(Biology_2_1_QuestionBank.questions[questionArrayNumber].questionAudio);
    }

    public void DescriptionOpenButton()
    {
        beeGirlChar.GetComponent<Renderer>().enabled = false;
        // display description
        descriptionPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        descriptionPanel.GetComponent<CanvasGroup>().alpha = 1.0f;
        descriptionText.text = Biology_2_1_QuestionBank.questions[questionArrayNumber].description;
    }

    public void DescriptionCloseButton()
    {
        beeGirlChar.GetComponent<Renderer>().enabled = true;
        // hide description
        descriptionPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
        descriptionPanel.GetComponent<CanvasGroup>().alpha = 0.0f;
        descriptionText.text = "";
    }

}
