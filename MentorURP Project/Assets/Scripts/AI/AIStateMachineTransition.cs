using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AIStateMachineTransition
{
    public AIStateMachineNode targetNode;
    public bool isEnemyInRadius;

    public bool ShouldMoveToTargetNode(AIStateMachineController aiStateMachineController)
    {
        if (isEnemyInRadius && aiStateMachineController.enemyInRadius)
            return true;
        return false;
    }
}
