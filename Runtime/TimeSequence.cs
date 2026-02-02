using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sequence_ Time_ New", menuName = "Sequences/Time")]
public class TimeSequence : Sequence
{
    [SerializeField]
    private float duration = 1f;

    override protected IEnumerator Do()
    {
        yield return new WaitForSeconds(duration);
    }
}
