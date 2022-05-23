using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugetSystem : MonoBehaviour
{
    public int budget, incomes, outcomes, transition ;

    public bugetSystem()
    {
        budget = 50000;
        incomes = 0;
        transition = 0;
        outcomes = 0;
    }
    public int getBuget()
    {
        return budget;
    }
    public int getIncomes()
    {
        return incomes;
    }
    public int getOutcomes()
    {
        return outcomes;
    }
    public int getTransition()
    {
        return transition;
    }
    public void setBuget(int budget)
    {
        this.budget = budget;
    }
    public void setIncomes(int incomes)
    
    {
        this.incomes = incomes;
    }
    public void setOutcomes(int outcomes)
    {
        this.outcomes = outcomes;
    }
    public void setTrasition(int transition)
    {
        this.transition = transition;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
