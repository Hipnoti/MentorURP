using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = @"Mentor/AI/State Machine", fileName = "AI State Machine")]
public class AIStateMachine : ScriptableObject
{
    public List<AIStateMachineNode> stateNodes;
    public AIStateMachineNode entryNode;
}
