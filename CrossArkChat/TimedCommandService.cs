namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    public class TimedCommandService
    {
        private readonly SendTimeCommandService _rcon;
        private readonly TimedCommandSettings _settings;
        private Timer _timer;

        public TimedCommandService(SendTimeCommandService rcon, TimedCommandSettings settings)
        {
            this._rcon = rcon;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< StartAsync > d__4))]
        public Task StartAsync()
        {
            < StartAsync > d__4 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartAsync > d__4 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StopAsync > d__5))]
        public Task StopAsync()
        {
            < StopAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StopAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private void TimerProc(object state)
        {
            Func<TimedCommand, bool> func1 = <> c.<> 9__6_0;
            if (<> c.<> 9__6_0 == null)
            {
                Func<TimedCommand, bool> local1 = <> c.<> 9__6_0;
                func1 = <> c.<> 9__6_0 = delegate (TimedCommand i)
                {
                    return i.Active && (i.NextRunTime <= DateTime.get_Now());
                };
            }
            foreach (TimedCommand timedCommand in Enumerable.ToList<TimedCommand>(Enumerable.Where<TimedCommand>((IEnumerable<TimedCommand>)this._settings.TimedCommands, func1)))
            {
                foreach (TimedCommandItem command in timedCommand.Commands)
                {
                    Task task = null;
                    string str = command.Type.ToLower();
                    if (str == "broadcast")
                    {
                        task = (Task)Task.get_Factory().StartNew<Task>(delegate
                        {
                            return this._rcon.GenericCommandAsync("Broadcast " + command.Command, timedCommand);
                        });
                    }
                    else if (str == "command")
                    {
                        task = (Task)Task.get_Factory().StartNew<Task>(delegate
                        {
                            return this._rcon.GenericCommandAsync(command.Command, timedCommand);
                        });
                    }
                    if (task != null)
                    {
                        Task[] taskArray1 = new Task[] { task };
                        Task.WaitAll(taskArray1, 0x1388);
                    }
                }
                timedCommand.UpdateNextRunTime();
            }
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly TimedCommandService.<>c<>9 = new TimedCommandService.<>c();
        public static Func<TimedCommand, bool> <>9__6_0;

            internal bool <TimerProc>b__6_0(TimedCommand i) =>
                i.Active && (i.NextRunTime <= DateTime.get_Now());
    }

    [CompilerGenerated]
    private struct <StartAsync>d__4 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public TimedCommandService<>4__this;
            private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        TimedCommandService service = this.<> 4__this;
        try
        {
            TaskAwaiter awaiter;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0004;
            }
            else
            {
                service._timer = new Timer(new TimerCallback(service.TimerProc));
                service._timer.Change(0x3e8, 0xea60);
                awaiter = Task.Delay(0x3e8).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0004;
                }
                else
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, TimedCommandService.< StartAsync > d__4 > (ref awaiter, ref this);
                }
            }
            return;
        TR_0004:
            awaiter.GetResult();
            this.<> 1__state = -2;
            this.<> t__builder.SetResult();
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.<> t__builder.SetException(exception);
        }
    }

    [DebuggerHidden]
    private void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        this.<> t__builder.SetStateMachine(stateMachine);
    }
}

[CompilerGenerated]
private struct <StopAsync>d__5: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public TimedCommandService<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    TimedCommandService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter;
        if (num == 0)
        {
            awaiter = this.<> u__1;
            this.<> u__1 = new TaskAwaiter();
            this.<> 1__state = num = -1;
            goto TR_0004;
        }
        else
        {
            if (service._timer != null)
            {
                service._timer.Dispose();
            }
            service._timer = null;
            awaiter = Task.Delay(0x3e8).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, TimedCommandService.< StopAsync > d__5 > (ref awaiter, ref this);
            }
        }
        return;
    TR_0004:
        awaiter.GetResult();
        this.<> 1__state = -2;
        this.<> t__builder.SetResult();
    }
    catch (Exception exception)
    {
        this.<> 1__state = -2;
        this.<> t__builder.SetException(exception);
    }
}

[DebuggerHidden]
private void SetStateMachine(IAsyncStateMachine stateMachine)
{
    this.<> t__builder.SetStateMachine(stateMachine);
}
        }
    }
}

