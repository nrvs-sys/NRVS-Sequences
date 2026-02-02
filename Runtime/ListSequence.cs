using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sequence_ List_ New", menuName = "Sequences/List")]
public class ListSequence : Sequence
{
    [SerializeField]
    List<Sequence> sequences = new List<Sequence>();

    protected override IEnumerator Do()
    {
        foreach (var sequence in sequences)
        {
            yield return sequence.DoStart();
        }
    }
}
