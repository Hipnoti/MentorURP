using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Mentor/AI/State Machine Node", fileName = "AI State Machine Node")]
public class AIStateMachineNode : ScriptableObject
{
    public List<AnimatorParameterKeyValuePair> animatorParameters;
    public List<AIStateMachineTransition> transitions;

    public AIStateMachineNode CheckForTransition(AIStateMachineController aiStateMachineController)
    {
        foreach (AIStateMachineTransition transition in transitions)
        {
            if (transition.ShouldMoveToTargetNode(aiStateMachineController))
            {
                return transition.targetNode;
            }
        }

        return null;
    }
}
