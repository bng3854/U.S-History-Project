using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[]  options;
    public int currentQuestion;
    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI ScoreText;

    public GameObject Quizpanel;
    public GameObject Gopanel;
 

    int totalQuestions = 0;
    public int totalScore = 0;

    // Start is called before the first frame update
    private void Start()
    {
        totalQuestions = QnA.Count;
        Gopanel.SetActive(false);
        generateQuestion();

    }

    public void correct()
    {
        totalScore += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);  
        generateQuestion();
    }    

    public void GameOver()
    {
        Quizpanel.SetActive(false);
        Gopanel.SetActive(true);

        ScoreText.text = "Score: " + totalScore;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
    
    void SetAnswers()
    {
        for (int i =0; i < options.Length; i++) 
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        if  (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questioons");
            GameOver();
        }
        
    }
}
