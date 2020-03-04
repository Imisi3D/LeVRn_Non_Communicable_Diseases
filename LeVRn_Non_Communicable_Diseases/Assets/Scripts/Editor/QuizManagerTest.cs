using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using NUnit.Framework;


public class QuizManagerTest
{
    [Test]
    public void QuizAndResultChecker() {
        var quiz = new GameObject();
        quiz.AddComponentAndInit<QuizManager> ();
        quiz.tag = "Player";

        var resultTracker = new GameObject ();
        resultTracker.AddComponentAndInit<ResultManager>();
        resultTracker.GetComponent<ResultManager> ().currentOption = 5;

        quiz.GetComponent<QuizManager>().SubmitAnswers();
        
        Assert.AreNotEqual(1 * 50, resultTracker.GetComponent<ResultManager> ().currentOption);
    }
}
