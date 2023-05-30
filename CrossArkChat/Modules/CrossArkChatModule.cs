namespace CrossArkChat.Modules
{
    using CrossArkChat;
    using CrossArkChat.Enums;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    [Name("CrossArkChat")]
    public class CrossArkChatModule : ModuleBase<SocketCommandContext>
    {
        private readonly CrossArkChatService _service;
        private readonly GeneralSettings _settings;
        public static CancellationTokenSource cts = new CancellationTokenSource();
        public CancellationToken ct = cts.get_Token();

        public CrossArkChatModule(GeneralSettings settings, CrossArkChatService service)
        {
            this._settings = settings;
            this._service = service;
        }

        [AsyncStateMachine((Type)typeof(< ClearCrossArkChatAsync > d__8)), Command("clearchat", RunMode = RunMode.Async), RequireRole(SpecialRole.ClearChat), Summary("clears the cross ark chat message que"), Remarks("clearchat")]
        public Task ClearCrossArkChatAsync()
        {
            < ClearCrossArkChatAsync > d__8 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ClearCrossArkChatAsync > d__8 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RebootCrossArkChatAsync > d__9)), Command("reboot", RunMode = RunMode.Async), RequireRole(SpecialRole.RebootProgram), Summary("restarts the cross ark chat program"), Remarks("reboot")]
        public Task RebootCrossArkChatAsync()
        {
            < RebootCrossArkChatAsync > d__9 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RebootCrossArkChatAsync > d__9 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RestartCrossArkChatAsync > d__7)), Command("restartchat", RunMode = RunMode.Async), RequireRole(SpecialRole.RestartChat), Summary("restarts the cross ark chat"), Remarks("restartchat")]
        public Task RestartCrossArkChatAsync()
        {
            < RestartCrossArkChatAsync > d__7 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RestartCrossArkChatAsync > d__7 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StartCrossArkChatAsync > d__5)), Command("startchat", RunMode = RunMode.Async), RequireRole(SpecialRole.StartChat), Summary("Starts the cross ark chat"), Remarks("startchat")]
        public Task StartCrossArkChatAsync()
        {
            < StartCrossArkChatAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartCrossArkChatAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StopCrossArkChatAsync > d__6)), Command("stopchat", RunMode = RunMode.Async), RequireRole(SpecialRole.StopChat), Summary("Stops the cross ark chat"), Remarks("stopchat")]
        public Task StopCrossArkChatAsync()
        {
            < StopCrossArkChatAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StopCrossArkChatAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <ClearCrossArkChatAsync>d__8 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public CrossArkChatModule<>4__this;
            private TaskAwaiter<> u__1;
        private TaskAwaiter<IUserMessage> <>u__2;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            CrossArkChatModule module = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                TaskAwaiter<IUserMessage> awaiter2;
                switch (num)
                {
                    case 0:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        break;

                    case 1:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0010;

                    case 2:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_000E;

                    case 3:
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter<IUserMessage>();
                        this.<> 1__state = num = -1;
                        goto TR_000C;

                    case 4:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_000A;

                    case 5:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0009;

                    default:
                        awaiter = module.StopCrossArkChatAsync().GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            break;
                        }
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter, ref this);
                        return;
                }
                awaiter.GetResult();
                awaiter = Task.Delay(1).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 1;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter, ref this);
                    return;
                }
                goto TR_0010;
            TR_0009:
                awaiter.GetResult();
                this.<> 1__state = -2;
                this.<> t__builder.SetResult();
                return;
            TR_000A:
                awaiter.GetResult();
                awaiter = module.StartCrossArkChatAsync().GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0009;
                }
                else
                {
                    this.<> 1__state = num = 5;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter, ref this);
                }
                return;
            TR_000C:
                awaiter2.GetResult();
                awaiter = Task.Delay(1).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 4;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter, ref this);
                    return;
                }
                goto TR_000A;
            TR_000E:
                awaiter.GetResult();
                awaiter2 = module.ReplyAsync(module._settings.ChatClear, false, null, null).GetAwaiter();
                if (!awaiter2.IsCompleted)
                {
                    this.<> 1__state = num = 3;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter2, ref this);
                    return;
                }
                goto TR_000C;
            TR_0010:
                awaiter.GetResult();
                awaiter = module._service.ClearConcurrentQuesAsync().GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 2;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< ClearCrossArkChatAsync > d__8 > (ref awaiter, ref this);
                }
                else
                {
                    goto TR_000E;
                }
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
    private struct <RebootCrossArkChatAsync>d__9 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public CrossArkChatModule<>4__this;
            private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        CrossArkChatModule module = this.<> 4__this;
        try
        {
            TaskAwaiter awaiter;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
            }
            else if (num == 1)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0005;
            }
            else
            {
                awaiter = module.StopCrossArkChatAsync().GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< RebootCrossArkChatAsync > d__9 > (ref awaiter, ref this);
                    return;
                }
            }
            awaiter.GetResult();
            awaiter = Task.Delay(0x1388).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0005;
            }
            else
            {
                this.<> 1__state = num = 1;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< RebootCrossArkChatAsync > d__9 > (ref awaiter, ref this);
            }
            return;
        TR_0005:
            awaiter.GetResult();
            Process.Start("CrossArkChat");
            Environment.Exit(0);
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
private struct <RestartCrossArkChatAsync>d__7: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatModule module = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter;
        switch (num)
        {
            case 0:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                break;

            case 1:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0007;

            case 2:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0006;

            default:
                awaiter = module.StopCrossArkChatAsync().GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    break;
                }
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< RestartCrossArkChatAsync > d__7 > (ref awaiter, ref this);
                return;
        }
        awaiter.GetResult();
        awaiter = Task.Delay(1).GetAwaiter();
        if (!awaiter.IsCompleted)
        {
            this.<> 1__state = num = 1;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< RestartCrossArkChatAsync > d__7 > (ref awaiter, ref this);
            return;
        }
        goto TR_0007;
    TR_0006:
        awaiter.GetResult();
        this.<> 1__state = -2;
        this.<> t__builder.SetResult();
        return;
    TR_0007:
        awaiter.GetResult();
        awaiter = module.StartCrossArkChatAsync().GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_0006;
        }
        else
        {
            this.<> 1__state = num = 2;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< RestartCrossArkChatAsync > d__7 > (ref awaiter, ref this);
        }
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
private struct <StartCrossArkChatAsync>d__5: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatModule<> 4__this;
private object <> 7__wrap1;
private int <> 7__wrap2;
private TaskAwaiter<IUserMessage> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatModule module = this.<> 4__this;
    try
    {
        TaskAwaiter<IUserMessage> awaiter;
        if (num > 1)
        {
            if (num == 2)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_0005;
            }
            else
            {
                this.<> 7__wrap2 = 0;
            }
        }
        try
        {
            TaskAwaiter awaiter2;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
            }
            else if (num == 1)
            {
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_000C;
            }
            else
            {
                awaiter = module.ReplyAsync(module._settings.ChatStart, false, null, null).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, CrossArkChatModule.< StartCrossArkChatAsync > d__5 > (ref awaiter, ref this);
                    return;
                }
            }
            awaiter.GetResult();
            awaiter2 = module._service.CrossArkChatAsync(CrossArkChatModule.cts.get_Token()).GetAwaiter();
            if (awaiter2.IsCompleted)
            {
                goto TR_000C;
            }
            else
            {
                this.<> 1__state = num = 1;
                this.<> u__2 = awaiter2;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< StartCrossArkChatAsync > d__5 > (ref awaiter2, ref this);
            }
            return;
        TR_000C:
            awaiter2.GetResult();
        }
        catch (OperationCanceledException)
        {
            goto TR_0002;
        }
        catch (Exception exception)
        {
            this.<> 7__wrap1 = exception;
            this.<> 7__wrap2 = 1;
        }
        goto TR_0008;
    TR_0004:
        this.<> 7__wrap1 = null;
        goto TR_0002;
    TR_0005:
        awaiter.GetResult();
        goto TR_0004;
    TR_0008:
        if (this.<> 7__wrap2 != 1)
                    {
    goto TR_0004;
}
                    else
{
    Console.WriteLine((Exception)this.<> 7__wrap1);
    awaiter = module.ReplyAsync(module._settings.ChatStartFailed, false, null, null).GetAwaiter();
    if (awaiter.IsCompleted)
    {
        goto TR_0005;
    }
    else
    {
        this.<> 1__state = num = 2;
        this.<> u__1 = awaiter;
        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, CrossArkChatModule.< StartCrossArkChatAsync > d__5 > (ref awaiter, ref this);
    }
}
                }
                catch (Exception exception2)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetException(exception2);
}
return;
TR_0002:
this.<> 1__state = -2;
this.<> t__builder.SetResult();
            }

            [DebuggerHidden]
private void SetStateMachine(IAsyncStateMachine stateMachine)
{
    this.<> t__builder.SetStateMachine(stateMachine);
}
        }

        [CompilerGenerated]
private struct <StopCrossArkChatAsync>d__6: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatModule<> 4__this;
private TaskAwaiter<> u__1;
private TaskAwaiter<IUserMessage> <> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatModule module = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter;
        TaskAwaiter<IUserMessage> awaiter2;
        if (num == 0)
        {
            awaiter = this.<> u__1;
            this.<> u__1 = new TaskAwaiter();
            this.<> 1__state = num = -1;
        }
        else if (num == 1)
        {
            awaiter2 = this.<> u__2;
            this.<> u__2 = new TaskAwaiter<IUserMessage>();
            this.<> 1__state = num = -1;
            goto TR_0005;
        }
        else
        {
            CrossArkChatModule.cts.Cancel();
            awaiter = Task.Delay(1).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatModule.< StopCrossArkChatAsync > d__6 > (ref awaiter, ref this);
                return;
            }
        }
        awaiter.GetResult();
        CrossArkChatModule.cts = new CancellationTokenSource();
        awaiter2 = module.ReplyAsync(module._settings.ChatStop, false, null, null).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0005;
        }
        else
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, CrossArkChatModule.< StopCrossArkChatAsync > d__6 > (ref awaiter2, ref this);
        }
        return;
    TR_0005:
        awaiter2.GetResult();
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

