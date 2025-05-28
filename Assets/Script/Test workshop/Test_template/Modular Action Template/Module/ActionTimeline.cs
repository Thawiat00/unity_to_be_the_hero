using System.Collections.Generic;
using UnityEngine;

#region Action Timeline

public class TimelineAction<T>
{
    public IAction<T> Action;
    public float Delay;

    public TimelineAction(IAction<T> action, float delay)
    {
        Action = action;
        Delay = delay;
    }
}

public class ActionTimeline<T> : MonoBehaviour
{
    private readonly List<(TimelineAction<T> data, float triggerTime)> _timeline = new();
    private T _context;

    public void Init(T context) => _context = context;

    public void ScheduleAction(IAction<T> action, float delaySeconds)
    {
        float triggerTime = Time.time + delaySeconds;
        _timeline.Add((new TimelineAction<T>(action, delaySeconds), triggerTime));
    }

    void Update()
    {
        float now = Time.time;
        for (int i = _timeline.Count - 1; i >= 0; i--)
        {
            if (now >= _timeline[i].triggerTime)
            {
                _timeline[i].data.Action.Execute(_context);
                _timeline.RemoveAt(i);
            }
        }
    }
}

#endregion