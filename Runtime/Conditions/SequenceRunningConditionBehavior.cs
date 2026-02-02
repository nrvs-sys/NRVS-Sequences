using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Condition_ Sequence Running_ New", menuName = "Behaviors/Conditions/Sequence Running")]
public class SequenceRunningConditionBehavior : ConditionBehavior
{
    [SerializeField]
    Sequence sequence;

    [SerializeField]
    bool isRunning = true;

    protected override bool Evaluate() => sequence.isRunning == isRunning;
}
