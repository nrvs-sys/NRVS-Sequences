using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Sequence : ScriptableObject
{
    [SerializeField, TextArea]
    string developerNote;

    [Space(10)]

    public UnityEvent onComplete;

    public bool isRunning => coroutine != null;

    Coroutine coroutine;

    public void Start() => DoStart();

    public Coroutine DoStart()
    {
        if (coroutine != null)
            CoWorker.Stop(coroutine);

        return coroutine = CoWorker.Work(Invoke());
    }

    public void Stop()
    {
        if (coroutine != null)
        {
            CoWorker.Stop(coroutine);
            OnStop();
        }
        coroutine = null;
    }

    IEnumerator Invoke()
    {
        yield return Do();

        onComplete?.Invoke();
    }

    protected abstract IEnumerator Do();

    virtual protected void OnStop()
    {

    }
}
