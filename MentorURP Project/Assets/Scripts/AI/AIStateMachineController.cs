using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStateMachineController : MonoBehaviour
{
    public bool enemyInRadius = false;
    
    [SerializeField] AIStateMachinesGroup stateMachinesGroup;
    [SerializeField] private AIStateMachineNode currentStateMachineNode;

    [SerializeField] private Animator entityAnimator;
    private void Start()
    {
        EnterStateMachineNode(stateMachinesGroup.entryStateMachine.entryNode);
    }

    private void Update()
    {
        AIStateMachineNode nextStateMachineNode = currentStateMachineNode.CheckForTransition(this);
        if (nextStateMachineNode != null)
        {
            EnterStateMachineNode(nextStateMachineNode);
        }
    }

    void EnterStateMachineNode(AIStateMachineNode aiStateMachineNode)
    {
        currentStateMachineNode = aiStateMachineNode;
        
        foreach (AnimatorParameterKeyValuePair keyValuePair in currentStateMachineNode.animatorParameters)
        {
            switch (keyValuePair.parameterType)
            {
                case AnimatorControllerParameterType.Float:
                    break;
                case AnimatorControllerParameterType.Int:
                    break;
                case AnimatorControllerParameterType.Bool:
                    entityAnimator.SetBool(keyValuePair.parameterName, keyValuePair.boolValue);
                    break;
                case AnimatorControllerParameterType.Trigger:
                    break;

            }
        }
    }
    
}
