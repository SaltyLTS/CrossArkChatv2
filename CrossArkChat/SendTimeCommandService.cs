namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class SendTimeCommandService
    {
        private readonly GeneralSettings _settings;

        public SendTimeCommandService(GeneralSettings settings)
        {
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< GenericCommandAsync > d__2))]
        public Task GenericCommandAsync(string command, TimedCommand timeCommand)
        {
            < GenericCommandAsync > d__2 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.command = command;
            d__.timeCommand = timeCommand;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GenericCommandAsync > d__2 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <GenericCommandAsync>d__2 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public TimedCommand timeCommand;
        public SendTimeCommandService<>4__this;
            public string command;
        private List<string>.Enumerator<>7__wrap1;
            private TaskAwaiter<string> <>u__1;
            private IEnumerator<ServerItem> <>7__wrap2;
            private TaskAwaiter<> u__2;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            SendTimeCommandService service = this.<> 4__this;
            try
            {
                if (num > 2)
                {
                    this.<> 7__wrap1 = this.timeCommand.Servers.GetEnumerator();
                }
                try
                {
                    ServerItem item;
                    TaskAwaiter<string> awaiter;
                    if (num == 0)
                    {
                        goto TR_000D;
                    }
                    else if ((num - 1) <= 1)
                    {
                        goto TR_0026;
                    }
                    goto TR_002B;
                TR_000D:
                    try
                    {
                        if (num == 0)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            goto TR_0008;
                        }
                        else
                        {
                            awaiter = item.Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0008;
                            }
                            else
                            {
                                this.<> 1__state = num = 0;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, SendTimeCommandService.< GenericCommandAsync > d__2 > (ref awaiter, ref this);
                            }
                        }
                        return;
                    TR_0008:
                        awaiter.GetResult();
                    }
                    catch (Exception)
                    {
                    }
                    goto TR_002B;
                TR_0026:
                    try
                    {
                        if ((num - 1) > 1)
                        {
                            this.<> 7__wrap2 = service._settings.ServerDictionary.get_Values().GetEnumerator();
                        }
                        try
                        {
                            ServerItem current;
                            if ((num - 1) > 1)
                            {
                                goto TR_0021;
                            }
                        TR_001E:
                            try
                            {
                                TaskAwaiter awaiter2;
                                if (num == 1)
                                {
                                    awaiter = this.<> u__1;
                                    this.<> u__1 = new TaskAwaiter<string>();
                                    this.<> 1__state = num = -1;
                                }
                                else if (num == 2)
                                {
                                    awaiter2 = this.<> u__2;
                                    this.<> u__2 = new TaskAwaiter();
                                    this.<> 1__state = num = -1;
                                    goto TR_0015;
                                }
                                else
                                {
                                    awaiter = current.Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                                    if (!awaiter.IsCompleted)
                                    {
                                        this.<> 1__state = num = 1;
                                        this.<> u__1 = awaiter;
                                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, SendTimeCommandService.< GenericCommandAsync > d__2 > (ref awaiter, ref this);
                                        return;
                                    }
                                }
                                awaiter.GetResult();
                                awaiter2 = Task.Delay(0x3e8).GetAwaiter();
                                if (awaiter2.IsCompleted)
                                {
                                    goto TR_0015;
                                }
                                else
                                {
                                    this.<> 1__state = num = 2;
                                    this.<> u__2 = awaiter2;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, SendTimeCommandService.< GenericCommandAsync > d__2 > (ref awaiter2, ref this);
                                }
                                return;
                            TR_0015:
                                awaiter2.GetResult();
                            }
                            catch (Exception)
                            {
                            }
                        TR_0021:
                            while (true)
                            {
                                if (this.<> 7__wrap2.MoveNext())
                                    {
                                    current = this.<> 7__wrap2.Current;
                                }
                                    else
                                {
                                    goto TR_0012;
                                }
                                break;
                            }
                            goto TR_001E;
                        }
                        finally
                        {
                            if ((num < 0) && (this.<> 7__wrap2 != null))
                                {
                                this.<> 7__wrap2.Dispose();
                            }
                        }
                        goto TR_002B;
                    TR_0012:
                        this.<> 7__wrap2 = null;
                    }
                    catch (Exception)
                    {
                    }
                TR_002B:
                    while (true)
                    {
                        if (this.<> 7__wrap1.MoveNext())
                            {
                            string current = this.<> 7__wrap1.Current;
                            if (!service._settings.ServerDictionary.ContainsKey(current.Trim()))
                            {
                                if (current.ToLower() != "all")
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                service._settings.ServerDictionary.TryGetValue(current, out item);
                                goto TR_000D;
                            }
                        }
                            else
                        {
                            goto TR_0006;
                        }
                        break;
                    }
                    goto TR_0026;
                }
                finally
                {
                    if (num < 0)
                    {
                        this.<> 7__wrap1.Dispose();
                    }
                }
                return;
            TR_0006:
                this.<> 7__wrap1 = new List<string>.Enumerator();
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

