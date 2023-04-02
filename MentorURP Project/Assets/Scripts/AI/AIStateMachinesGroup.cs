using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mentor/AI/State Machines Group", fileName = "State Machines Group")]
public class AIStateMachinesGroup : ScriptableObject
{
    public List<AIStateMachine> stateMachines;
    public AIStateMachine entryStateMachine;
}
