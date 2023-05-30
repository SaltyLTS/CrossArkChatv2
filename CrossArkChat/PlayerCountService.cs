namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class PlayerCountService
    {
        private readonly DiscordSocketClient _discord;
        private readonly LoggingService _log;
        private readonly GeneralSettings _settings;

        public PlayerCountService(DiscordSocketClient discord, LoggingService log, GeneralSettings settings)
        {
            this._discord = discord;
            this._log = log;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< PlayerCountAsync > d__4))]
        public Task PlayerCountAsync()
        {
            < PlayerCountAsync > d__4 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << PlayerCountAsync > d__4 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StartPlayCountAsync > d__5))]
        public Task StartPlayCountAsync()
        {
            < StartPlayCountAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartPlayCountAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <PlayerCountAsync>d__4 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public PlayerCountService<>4__this;
            private PlayerCountService.<>c__DisplayClass4_0<>8__1;
            private string <noResponce>5__2;
            private string <noPlayer>5__3;
            private ITextChannel<channelName>5__4;
            private IEnumerator<KeyValuePair<string, ServerItem>> <>7__wrap4;
            private KeyValuePair<string, ServerItem> <serverItem>5__6;
            private TaskAwaiter<string> <>u__1;
            private TaskAwaiter<> u__2;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            PlayerCountService service = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter2;
                if (num > 2)
                {
                    if (num == 3)
                    {
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                    }
                    else
                    {
                        goto TR_003D;
                    }
                }
                else
                {
                    goto TR_003B;
                }
            TR_0003:
                awaiter2.GetResult();
                this.<> 8__1 = null;
                this.< noResponce > 5__2 = null;
                this.< noPlayer > 5__3 = null;
                this.< channelName > 5__4 = null;
                goto TR_003D;
            TR_0004:
                awaiter2 = Task.Delay(service._settings.PlayerCountCheckTimeInMs).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                    goto TR_0003;
                }
                else
                {
                    this.<> 1__state = num = 3;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, PlayerCountService.< PlayerCountAsync > d__4 > (ref awaiter2, ref this);
                }
                return;
            TR_003B:
                try
                {
                    if (num > 1)
                    {
                        if (num == 2)
                        {
                            awaiter2 = this.<> u__2;
                            this.<> u__2 = new TaskAwaiter();
                            this.<> 1__state = num = -1;
                            goto TR_000D;
                        }
                        else
                        {
                            this.<> 7__wrap4 = service._settings.ServerDictionary.GetEnumerator();
                        }
                    }
                    try
                    {
                        if (num > 1)
                        {
                            goto TR_0034;
                        }
                        goto TR_0031;
                    TR_0015:
                        this.< serverItem > 5__6 = new KeyValuePair<string, ServerItem>();
                        goto TR_0034;
                    TR_0031:
                        try
                        {
                            TaskAwaiter<string> awaiter;
                            if (num == 0)
                            {
                                awaiter = this.<> u__1;
                                this.<> u__1 = new TaskAwaiter<string>();
                                this.<> 1__state = num = -1;
                            }
                            else if (num == 1)
                            {
                                awaiter2 = this.<> u__2;
                                this.<> u__2 = new TaskAwaiter();
                                this.<> 1__state = num = -1;
                                goto TR_0016;
                            }
                            else
                            {
                                awaiter = this.< serverItem > 5__6.Value.Server.Rcon.SendCommandAsync(service._settings.ListPlayersCmd).GetAwaiter();
                                if (!awaiter.IsCompleted)
                                {
                                    this.<> 1__state = num = 0;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, PlayerCountService.< PlayerCountAsync > d__4 > (ref awaiter, ref this);
                                    return;
                                }
                            }
                            string result = awaiter.GetResult();
                            if ((result != null) && !result.StartsWith(this.< noResponce > 5__2.Trim()))
                            {
                                if (result.StartsWith(this.< noPlayer > 5__3.Trim()))
                                {
                                    this.<> 8__1.tempPlayerCounter = 0;
                                }
                                else
                                {
                                    StringReader reader = new StringReader(result);
                                    try
                                    {
                                        string str2;
                                        while ((str2 = reader.ReadLine()) != null)
                                        {
                                            if ((str2.Length < 1) || (string.IsNullOrWhiteSpace(str2) || (str2.Split(' ', (StringSplitOptions)StringSplitOptions.None)[1] == null)))
                                            {
                                                continue;
                                            }
                                            this.<> 8__1.playerCounter++;
                                            this.<> 8__1.tempPlayerCounter++;
                                        }
                                    }
                                    finally
                                    {
                                        if ((num < 0) && (reader != null))
                                        {
                                            reader.Dispose();
                                        }
                                    }
                                }
                                if (!service._settings.SendServerChatToOwnChannel)
                                {
                                    goto TR_0015;
                                }
                                else
                                {
                                    ServerItem item;
                                    service._settings.ServerDictionary.TryGetValue(this.< serverItem > 5__6.Key, out item);
                                    Action<TextChannelProperties> action2 = this.<> 8__1.<> 9__1;
                                    if (this.<> 8__1.<> 9__1 == null)
                                    {
                                        Action<TextChannelProperties> local1 = this.<> 8__1.<> 9__1;
                                        action2 = this.<> 8__1.<> 9__1 = new Action<TextChannelProperties>(this.<> 8__1.< PlayerCountAsync > b__1);
                                    }
                                    awaiter2 = (service._discord.GetChannel(item.DiscordChannelId) as ITextChannel).ModifyAsync(action2, null).GetAwaiter();
                                    if (awaiter2.IsCompleted)
                                    {
                                        goto TR_0016;
                                    }
                                    else
                                    {
                                        this.<> 1__state = num = 1;
                                        this.<> u__2 = awaiter2;
                                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, PlayerCountService.< PlayerCountAsync > d__4 > (ref awaiter2, ref this);
                                    }
                                }
                                return;
                            }
                            goto TR_0034;
                        TR_0016:
                            awaiter2.GetResult();
                            goto TR_0015;
                        }
                        catch (Exception)
                        {
                            PlayerCountService.<> c__DisplayClass4_0 CS$<> 8__locals1 = this.<> 8__1;
                            if (service._settings.LogErrors)
                            {
                                PlayerCountService.<> c__DisplayClass4_1 class_;
                                Task.Run(new Func<Task>(class_.< PlayerCountAsync > b__2));
                            }
                            goto TR_0034;
                        }
                        return;
                    TR_0034:
                        while (true)
                        {
                            if (this.<> 7__wrap4.MoveNext())
                                {
                                this.< serverItem > 5__6 = this.<> 7__wrap4.Current;
                            }
                                else
                            {
                                goto TR_000E;
                            }
                            break;
                        }
                        goto TR_0031;
                    }
                    finally
                    {
                        if ((num < 0) && (this.<> 7__wrap4 != null))
                            {
                            this.<> 7__wrap4.Dispose();
                        }
                    }
                    goto TR_0004;
                TR_000D:
                    awaiter2.GetResult();
                    goto TR_0004;
                TR_000E:
                    this.<> 7__wrap4 = null;
                    awaiter2 = this.< channelName > 5__4.ModifyAsync(new Action<TextChannelProperties>(this.<> 8__1.< PlayerCountAsync > b__0), null).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_000D;
                    }
                    else
                    {
                        this.<> 1__state = num = 2;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, PlayerCountService.< PlayerCountAsync > d__4 > (ref awaiter2, ref this);
                    }
                    return;
                }
                catch (Exception)
                {
                    PlayerCountService.<> c__DisplayClass4_0 CS$<> 8__locals2 = this.<> 8__1;
                    if (service._settings.LogErrors)
                    {
                        PlayerCountService.<> c__DisplayClass4_2 class_2;
                        Task.Run(new Func<Task>(class_2.< PlayerCountAsync > b__3));
                    }
                }
                goto TR_0004;
            TR_003D:
                while (true)
                {
                    this.<> 8__1 = new PlayerCountService.<> c__DisplayClass4_0();
                    this.<> 8__1.<> 4__this = service;
                    this.<> 8__1.playerCounter = 0;
                    this.<> 8__1.tempPlayerCounter = 0;
                    this.< noResponce > 5__2 = service._settings.NoResponceTag;
                    this.< noPlayer > 5__3 = service._settings.NoPlayerTag;
                    this.< channelName > 5__4 = service._discord.GetChannel(service._settings.ChatDiscordChannelID) as ITextChannel;
                    break;
                }
                goto TR_003B;
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
    private struct <StartPlayCountAsync>d__5 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public PlayerCountService<>4__this;
            private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        PlayerCountService service = this.<> 4__this;
        try
        {
            if ((num == 0) || service._settings.UsePlayerCountChannelUpdater)
            {
                try
                {
                    TaskAwaiter awaiter;
                    if (num == 0)
                    {
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0007;
                    }
                    else
                    {
                        List<Task> list1 = new List<Task>();
                        list1.Add(Task.Run(new Action(service.< StartPlayCountAsync > b__5_0)));
                        awaiter = Task.WhenAll(list1.ToArray()).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0007;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, PlayerCountService.< StartPlayCountAsync > d__5 > (ref awaiter, ref this);
                        }
                    }
                    return;
                TR_0007:
                    awaiter.GetResult();
                }
                catch (Exception)
                {
                    PlayerCountService <> 4__this = service;
                    if (service._settings.LogErrors)
                    {
                        PlayerCountService.<> c__DisplayClass5_0 class_;
                        Task.Run(new Func<Task>(class_.< StartPlayCountAsync > b__1));
                    }
                }
            }
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.<> t__builder.SetException(exception);
            return;
        }
        this.<> 1__state = -2;
        this.<> t__builder.SetResult();
    }

    [DebuggerHidden]
    private void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        this.<> t__builder.SetStateMachine(stateMachine);
    }
}
    }
}

