using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissors : MonoBehaviour {

	public enum State
	{
		StartMenu,
		PlayerTurn,
		ComTurn,
		Result
	}

	State currState;
	float stateTimer;

	void SetNextState(State nextState)
	{
		if (CanEnterState (nextState)) {
			LeaveState (nextState);

		}
	}

	void EnterState(State nextState)
	{
	}

	void LeaveState(State nextState)
	{
	}

	bool CanEnterState(State nextState)
	{
	}

	void Update()
	{
		UpdateState();
	}

	void UpdateState()
	{
		stateTimer = 
	}
}
