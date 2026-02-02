using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sequence_ Condition_ New", menuName = "Sequences/Condition")]
public class ConditionSequence : Sequence
{
    [SerializeField, Expandable]
    ConditionBehavior condition;

    protected override IEnumerator Do()
    {
        while (!condition.If())
            yield return null;
    }
}
