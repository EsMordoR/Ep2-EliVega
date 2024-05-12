using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hola: MonoBehaviour
{

}
public interface IState

{
    void Enter();
    void Execute();
    void Exit();
}

 /*   private IState currentlyRunningState;
    private IState previousState;



    public void ChangeState(IState newState)
    {
        if (this.currentlyRunningState != null)
        {
            this.currentlyRunningState = Exit();
        }

        this.previousState = this.currentlyRunningState;
        this.currentlyRunningState = newState;
        this.currentlyRunningState = Enter();
    }

    public void ExecuteStateUpdate()
    {
        if (this.currentlyRunningState != null)
        {
            this.currentlyRunningState.Execute();
        }
    }

    public void SwitchToPreviousState()
    {
        this.currentlyRunningState.Exit();
        this.currentlyRunningState = this.previousState;
        this.currentlyRunningState.Execute;
    }
}
*/
