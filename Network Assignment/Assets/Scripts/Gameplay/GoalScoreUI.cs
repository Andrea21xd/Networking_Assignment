using UnityEngine;
using UnityEngine.UI;

public class GoalscoreUI : Text
{
    
    public void Incrementstatcount(int Goalscore) 
    {
        text = $"{Goalscore}";    
    }
    
   
}
