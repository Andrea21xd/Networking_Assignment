using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] GoalscoreUI goalscore;
    [SerializeField] GoalscoreUI1 goalscore2;
    int Goalscore;
    int Goalscore2;
    
    
    public void HandleGoalScore2()
    {
        print("goal1");
        Goalscore++;
        Debug.Log(Goalscore);
        goalscore.Incrementstatcount(Goalscore);
    
    }

    public void HandleGoalScore()
    {
        print("goal2");
        Goalscore2++;
        Debug.Log(Goalscore2);
        goalscore2.Incrementstatcount(Goalscore2);

    }

    private void OnEnable()
    {
        Ball.onGoal += () =>
        {
            HandleGoalScore();
        };

        Ball.onGoal2 += () =>
        {
            HandleGoalScore2();
        };
    }

    private void OnDisable()
    {
        Ball.onGoal -= () =>
        {
            HandleGoalScore();
        };

        Ball.onGoal2 += () =>
        {
            HandleGoalScore2();
        };
    }

}
