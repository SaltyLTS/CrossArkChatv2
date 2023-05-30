namespace CrossArkChat
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    public class CrossArkChatService
    {
        private readonly DiscordSocketClient _discord;
        private readonly IConfigurationRoot _config;
        private readonly IServiceProvider _services;
        private readonly LoggingService _log;
        private readonly GeneralSettings _settings;

        public CrossArkChatService(DiscordSocketClient discord, IConfigurationRoot config, IServiceProvider services, LoggingService log, GeneralSettings settings)
        {
            this._discord = discord;
            this._config = config;
            this._services = services;
            this._log = log;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< ClearConcurrentQuesAsync > d__30))]
        public Task ClearConcurrentQuesAsync()
        {
            < ClearConcurrentQuesAsync > d__30 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ClearConcurrentQuesAsync > d__30 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< CrossArkChatAsync > d__38))]
        public Task CrossArkChatAsync(CancellationToken token)
        {
            < CrossArkChatAsync > d__38 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkChatAsync > d__38 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GetChatMessageAsync > d__31))]
        public Task GetChatMessageAsync(CancellationToken token)
        {
            < GetChatMessageAsync > d__31 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GetChatMessageAsync > d__31 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendAdminCommandDiscordMessageAsync > d__35))]
        public Task SendAdminCommandDiscordMessageAsync(CancellationToken token)
        {
            < SendAdminCommandDiscordMessageAsync > d__35 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendAdminCommandDiscordMessageAsync > d__35 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendChatMessageAsync > d__32))]
        public Task SendChatMessageAsync(CancellationToken token)
        {
            < SendChatMessageAsync > d__32 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendChatMessageAsync > d__32 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendDiscordMessageAsync > d__34))]
        public Task SendDiscordMessageAsync(CancellationToken token)
        {
            < SendDiscordMessageAsync > d__34 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendDiscordMessageAsync > d__34 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendGameCommandMessagesAsync > d__37))]
        public Task SendGameCommandMessagesAsync(CancellationToken token)
        {
            < SendGameCommandMessagesAsync > d__37 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendGameCommandMessagesAsync > d__37 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendSupportDiscordMessageAsync > d__36))]
        public Task SendSupportDiscordMessageAsync(CancellationToken token)
        {
            < SendSupportDiscordMessageAsync > d__36 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendSupportDiscordMessageAsync > d__36 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendTribeLogsAsync > d__33))]
        public Task SendTribeLogsAsync(CancellationToken token)
        {
            < SendTribeLogsAsync > d__33 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.token = token;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendTribeLogsAsync > d__33 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private ConcurrentQueue<string> ChatConcurrentQueue { get; set; }

        private ConcurrentQueue<string> TribeLogsConcurrentQueue { get; set; }

        private ConcurrentQueue<string> DiscordConcurrentQueue { get; set; }

        private ConcurrentQueue<string> AdminCommandsConcurrentQueue { get; set; }

        private ConcurrentQueue<string> SupportChannelConcurrentQueue { get; set; }

        private ConcurrentQueue<string> GameCommandsConcurrentQueue { get; set; }

        [CompilerGenerated]
        private struct <ClearConcurrentQuesAsync>d__30 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public CrossArkChatService<>4__this;
            private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            CrossArkChatService service = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                }
                else
                {
                    goto TR_0036;
                }
            TR_0004:
                awaiter.GetResult();
                this.<> 1__state = -2;
                this.<> t__builder.SetResult();
                return;
            TR_000B:
                try
                {
                    while (true)
                    {
                        string str6;
                        if (!service.GameCommandsConcurrentQueue.TryDequeue(out str6))
                        {
                            break;
                        }
                        goto TR_000B;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService <> 4__this = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_5 class_6;
                        Task.Run(new Func<Task>(class_6.< ClearConcurrentQuesAsync > b__5));
                    }
                }
            TR_000E:
                while (true)
                {
                    if (service.GameCommandsConcurrentQueue.IsEmpty)
                    {
                        awaiter = Task.Delay(1).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0004;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< ClearConcurrentQuesAsync > d__30 > (ref awaiter, ref this);
                        }
                        break;
                    }
                    goto TR_000B;
                }
                return;
            TR_0013:
                try
                {
                    while (true)
                    {
                        string str5;
                        if (!service.SupportChannelConcurrentQueue.TryDequeue(out str5))
                        {
                            break;
                        }
                        goto TR_0013;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService service1 = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_4 class_5;
                        Task.Run(new Func<Task>(class_5.< ClearConcurrentQuesAsync > b__4));
                    }
                }
            TR_0016:
                while (true)
                {
                    if (!service.SupportChannelConcurrentQueue.IsEmpty)
                    {
                        break;
                    }
                    goto TR_000E;
                }
                goto TR_0013;
            TR_001B:
                try
                {
                    while (true)
                    {
                        string str4;
                        if (!service.AdminCommandsConcurrentQueue.TryDequeue(out str4))
                        {
                            break;
                        }
                        goto TR_001B;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService service2 = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_3 class_4;
                        Task.Run(new Func<Task>(class_4.< ClearConcurrentQuesAsync > b__3));
                    }
                }
            TR_001E:
                while (true)
                {
                    if (!service.AdminCommandsConcurrentQueue.IsEmpty)
                    {
                        break;
                    }
                    goto TR_0016;
                }
                goto TR_001B;
            TR_0023:
                try
                {
                    while (true)
                    {
                        string str3;
                        if (!service.DiscordConcurrentQueue.TryDequeue(out str3))
                        {
                            break;
                        }
                        goto TR_0023;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService service3 = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_2 class_3;
                        Task.Run(new Func<Task>(class_3.< ClearConcurrentQuesAsync > b__2));
                    }
                }
            TR_0026:
                while (true)
                {
                    if (!service.DiscordConcurrentQueue.IsEmpty)
                    {
                        break;
                    }
                    goto TR_001E;
                }
                goto TR_0023;
            TR_002B:
                try
                {
                    while (true)
                    {
                        string str2;
                        if (!service.TribeLogsConcurrentQueue.TryDequeue(out str2))
                        {
                            break;
                        }
                        goto TR_002B;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService service4 = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_1 class_2;
                        Task.Run(new Func<Task>(class_2.< ClearConcurrentQuesAsync > b__1));
                    }
                }
            TR_002E:
                while (true)
                {
                    if (!service.TribeLogsConcurrentQueue.IsEmpty)
                    {
                        break;
                    }
                    goto TR_0026;
                }
                goto TR_002B;
            TR_0033:
                try
                {
                    while (true)
                    {
                        string str;
                        if (!service.ChatConcurrentQueue.TryDequeue(out str))
                        {
                            break;
                        }
                        goto TR_0033;
                    }
                }
                catch (Exception)
                {
                    CrossArkChatService service5 = service;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass30_0 class_;
                        Task.Run(new Func<Task>(class_.< ClearConcurrentQuesAsync > b__0));
                    }
                }
            TR_0036:
                while (true)
                {
                    if (!service.ChatConcurrentQueue.IsEmpty)
                    {
                        break;
                    }
                    goto TR_002E;
                }
                goto TR_0033;
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
    private struct <CrossArkChatAsync>d__38 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public CrossArkChatService<>4__this;
            public CancellationToken token;
    private CrossArkChatService.<>c__DisplayClass38_0<>8__1;
            private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        CrossArkChatService service = this.<> 4__this;
        try
        {
            if (num != 0)
            {
                this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass38_0();
                this.<> 8__1.<> 4__this = this.<> 4__this;
                this.<> 8__1.token = this.token;
            }
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
                    this.<> 8__1.token.ThrowIfCancellationRequested();
                    List<Task> list1 = new List<Task>();
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__0)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__1)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__2)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__3)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__4)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__5)));
                    list1.Add(Task.Run(new Action(this.<> 8__1.< CrossArkChatAsync > b__6)));
                    this.<> 8__1.token.ThrowIfCancellationRequested();
                    awaiter = Task.WhenAll(list1.ToArray()).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0007;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< CrossArkChatAsync > d__38 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0007:
                awaiter.GetResult();
                this.<> 8__1.token.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception)
            {
                CrossArkChatService.<> c__DisplayClass38_0 CS$<> 8__locals1 = this.<> 8__1;
                if (service._settings.LogErrors)
                {
                    CrossArkChatService.<> c__DisplayClass38_1 class_;
                    Task.Run(new Func<Task>(class_.< CrossArkChatAsync > b__7));
                }
            }
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.<> 8__1 = null;
            this.<> t__builder.SetException(exception);
            return;
        }
        this.<> 1__state = -2;
        this.<> 8__1 = null;
        this.<> t__builder.SetResult();
    }

    [DebuggerHidden]
    private void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        this.<> t__builder.SetStateMachine(stateMachine);
    }
}

[CompilerGenerated]
private struct <GetChatMessageAsync>d__31: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CancellationToken token;
public CrossArkChatService<> 4__this;
private CrossArkChatService.<> c__DisplayClass31_0 <> 8__1;
private string < noResponce > 5__2;
private string < serverRepeat > 5__3;
private string < discordC > 5__4;
private string < supportReply > 5__5;
private string < adminCMDTag > 5__6;
private string < tribeLogsTag > 5__7;
private IEnumerator<KeyValuePair<string, ServerItem>> <> 7__wrap7;
private TaskAwaiter<string> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter2;
        if (num == 0)
        {
            goto TR_0060;
        }
        else if (num == 1)
        {
            awaiter2 = this.<> u__2;
            this.<> u__2 = new TaskAwaiter();
            this.<> 1__state = num = -1;
        }
        else
        {
            goto TR_0060;
        }
    TR_0004:
        awaiter2.GetResult();
        goto TR_0060;
    TR_0005:
        awaiter2 = Task.Delay(service._settings.GetChatTimeInMs, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< GetChatMessageAsync > d__31 > (ref awaiter2, ref this);
        }
        return;
    TR_0060:
        while (true)
        {
            try
            {
                if (num != 0)
                {
                    this.token.ThrowIfCancellationRequested();
                    this.< noResponce > 5__2 = service._settings.NoResponceTag;
                    this.< serverRepeat > 5__3 = service._settings.ServerRepeatTag;
                    this.< discordC > 5__4 = service._settings.DiscordChatPrefix + ":";
                    this.< supportReply > 5__5 = service._settings.SupportPingReply;
                    this.< adminCMDTag > 5__6 = service._settings.AdminCMDTag;
                    this.< tribeLogsTag > 5__7 = service._settings.TribeLogTag;
                    this.<> 7__wrap7 = service._settings.ServerDictionary.GetEnumerator();
                }
                try
                {
                    if (num != 0)
                    {
                        goto TR_005A;
                    }
                    goto TR_0057;
                TR_0016:
                    this.token.ThrowIfCancellationRequested();
                    this.<> 8__1 = null;
                    goto TR_005A;
                TR_0057:
                    try
                    {
                        string str;
                        TaskAwaiter<string> awaiter;
                        if (num == 0)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            goto TR_0051;
                        }
                        else
                        {
                            awaiter = this.<> 8__1.serverItem.Value.Server.Rcon.SendCommandAsync(service._settings.GetChatCmd).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0051;
                            }
                            else
                            {
                                this.<> 1__state = num = 0;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< GetChatMessageAsync > d__31 > (ref awaiter, ref this);
                            }
                        }
                        return;
                    TR_0051:
                        str = awaiter.GetResult();
                        if (str != null)
                        {
                            StringReader reader = new StringReader(str);
                            try
                            {
                                string str2;
                                while ((str2 = reader.ReadLine()) != null)
                                {
                                    if ((str2.Length < 1) || string.IsNullOrWhiteSpace(str2))
                                    {
                                        continue;
                                    }
                                    if (service._settings.UseWordReplacementList)
                                    {
                                        Dictionary<string, string>.Enumerator enumerator = service._settings.WorldReplacementDictionary.GetEnumerator();
                                        try
                                        {
                                            while (enumerator.MoveNext())
                                            {
                                                KeyValuePair<string, string> pair = enumerator.get_Current();
                                                str2 = str2.Replace(pair.Key, pair.Value);
                                            }
                                        }
                                        finally
                                        {
                                            if (num < 0)
                                            {
                                                enumerator.Dispose();
                                            }
                                        }
                                    }
                                    string str3 = this.<> 8__1.serverItem.Key + " " + str2.Trim();
                                    str2 = Regex.Replace(str2, @"\b" + string.Join(@"\b|\b", service._settings.WordFilterList.ToArray()) + @"\b", "");
                                    if (((!str2.StartsWith(this.< noResponce > 5__2.Trim()) && (!str2.StartsWith(this.< discordC > 5__4.Trim()) && (!str2.StartsWith(this.< serverRepeat > 5__3.Trim()) && (!service._settings.UseCustomTags || !Enumerable.Any<string>((IEnumerable<string>)service._settings.CustomTagList, new Func<string, bool>(str2.StartsWith)))))) && (service._settings.ShowTribelogs || !str2.StartsWith(this.< tribeLogsTag > 5__7.Trim()))) && (service._settings.ShowAdminCommands || (service._settings.SendAdminCommandsToOwnChannel || !str2.StartsWith(this.< adminCMDTag > 5__6.Trim()))))
                                    {
                                        string str4 = str2.Split(' ', (StringSplitOptions)StringSplitOptions.None)[1].Replace(":", "");
                                        if (!service._settings.ServerDictionary.ContainsKey(str4.Trim()))
                                        {
                                            string key = str2.Substring(str2.IndexOf(":") + 1).Split(' ', (StringSplitOptions)StringSplitOptions.None)[1];
                                            if (service._settings.UseGameCommands && service._settings.GameCommandsDictionary.ContainsKey(key.Trim()))
                                            {
                                                service.GameCommandsConcurrentQueue.Enqueue(str3.Trim());
                                            }
                                            else
                                            {
                                                if (service._settings.UseSupportPrefix && service._settings.UseDiscord)
                                                {
                                                    if (service._settings.ReplyToSupportPing && str.StartsWith(this.< supportReply > 5__5.Trim()))
                                                    {
                                                        continue;
                                                    }
                                                    if (service._settings.SupportPrefix.ToLower() == key.ToLower())
                                                    {
                                                        string str6 = Regex.Replace(str2.Trim(), "(: " + service._settings.SupportPrefix + @")\w*", ":", RegexOptions.IgnoreCase);
                                                        string str7 = this.<> 8__1.serverItem.Key + " (" + str6.Substring(str6.IndexOf("(") + 1);
                                                        service.SupportChannelConcurrentQueue.Enqueue(str7.Trim());
                                                        continue;
                                                    }
                                                }
                                                if (service._settings.ShowTribelogs && (service._settings.UseDiscord && str2.StartsWith(this.< tribeLogsTag > 5__7.Trim())))
                                                {
                                                    service.TribeLogsConcurrentQueue.Enqueue(str3.Trim());
                                                }
                                                else if (service._settings.SendAdminCommandsToOwnChannel && (service._settings.UseDiscord && str2.StartsWith(this.< adminCMDTag > 5__6.Trim())))
                                                {
                                                    service.AdminCommandsConcurrentQueue.Enqueue(str3.Trim());
                                                    if (service._settings.ShowAdminCommands && str2.StartsWith(this.< adminCMDTag > 5__6.Trim()))
                                                    {
                                                        service.ChatConcurrentQueue.Enqueue(str3.Trim());
                                                        service.DiscordConcurrentQueue.Enqueue(str3.Trim());
                                                    }
                                                }
                                                else if (service._settings.ShowAdminCommands && str2.StartsWith(this.< adminCMDTag > 5__6.Trim()))
                                                {
                                                    service.ChatConcurrentQueue.Enqueue(str3.Trim());
                                                    if (service._settings.UseDiscord)
                                                    {
                                                        service.DiscordConcurrentQueue.Enqueue(str3.Trim());
                                                    }
                                                }
                                                else if (!service._settings.SendChatToServers)
                                                {
                                                    if (!service._settings.SendChatToDiscord || (!service._settings.UsePrefixToSendToDiscord || !service._settings.UseDiscord))
                                                    {
                                                        if (service._settings.SendChatToDiscord && service._settings.UseDiscord)
                                                        {
                                                            string str10 = this.<> 8__1.serverItem.Key + " (" + str2.Substring(str2.IndexOf("(") + 1);
                                                            service.DiscordConcurrentQueue.Enqueue(str10.Trim());
                                                        }
                                                    }
                                                    else if (service._settings.PrefixToSendToDiscord.ToLower() == key.ToLower())
                                                    {
                                                        string str8 = Regex.Replace(str2.Trim(), "(: " + service._settings.PrefixToSendToDiscord + @")\w*", ":", RegexOptions.IgnoreCase);
                                                        string str9 = this.<> 8__1.serverItem.Key + " (" + str8.Substring(str8.IndexOf("(") + 1);
                                                        service.DiscordConcurrentQueue.Enqueue(str9.Trim());
                                                    }
                                                }
                                                else if (service._settings.SendChatToDiscord && (service._settings.UsePrefixToSendToDiscord && (service._settings.UseDiscord && (service._settings.PrefixToSendToDiscord.ToLower() == key.ToLower()))))
                                                {
                                                    string str11 = Regex.Replace(str2.Trim(), "(: " + service._settings.PrefixToSendToDiscord + @")\w*", ":", RegexOptions.IgnoreCase);
                                                    string str12 = this.<> 8__1.serverItem.Key + " (" + str11.Substring(str11.IndexOf("(") + 1);
                                                    service.DiscordConcurrentQueue.Enqueue(str12.Trim());
                                                }
                                                else if (service._settings.UsePrefixToSendChat && service._settings.PrefixDictionary.ContainsKey(key))
                                                {
                                                    string str13 = this.<> 8__1.serverItem.Key + " (" + str2.Substring(str2.IndexOf("(") + 1);
                                                    service.ChatConcurrentQueue.Enqueue(str13.Trim());
                                                    if (service._settings.SendChatToDiscord && service._settings.UseDiscord)
                                                    {
                                                        service.DiscordConcurrentQueue.Enqueue(str13.Trim());
                                                    }
                                                }
                                                else if (!service._settings.UsePrefixToSendChat)
                                                {
                                                    string str14 = this.<> 8__1.serverItem.Key + " (" + str2.Substring(str2.IndexOf("(") + 1);
                                                    service.ChatConcurrentQueue.Enqueue(str14.Trim());
                                                    if (service._settings.SendChatToDiscord && service._settings.UseDiscord)
                                                    {
                                                        service.DiscordConcurrentQueue.Enqueue(str14.Trim());
                                                    }
                                                }
                                                else if (!service._settings.UsePrefixToSendChat || (service._settings.AllServersChatPrefix.ToLower() != key.ToLower()))
                                                {
                                                    if (service._settings.UsePrefixToSendChat && (service._settings.UseDiscord && (service._settings.SendChatToDiscord && !service._settings.UsePrefixToSendToDiscord)))
                                                    {
                                                        string str16 = this.<> 8__1.serverItem.Key + " (" + str2.Substring(str2.IndexOf("(") + 1);
                                                        service.DiscordConcurrentQueue.Enqueue(str16.Trim());
                                                    }
                                                }
                                                else
                                                {
                                                    string str15 = this.<> 8__1.serverItem.Key + " (" + str2.Substring(str2.IndexOf("(") + 1);
                                                    service.ChatConcurrentQueue.Enqueue(str15.Trim());
                                                    if (service._settings.SendChatToDiscord && service._settings.UseDiscord)
                                                    {
                                                        service.DiscordConcurrentQueue.Enqueue(str15.Trim());
                                                    }
                                                }
                                            }
                                        }
                                    }
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
                        else
                        {
                            goto TR_005A;
                        }
                        goto TR_0016;
                    }
                    catch (NullReferenceException)
                    {
                        ServerItem item;
                        Console.WriteLine("Lost connection to " + this.<> 8__1.serverItem.Key + " adding to auto reconnect que.");
                        Task.Run(new Func<Task>(this.<> 8__1.< GetChatMessageAsync > b__0));
                        CollectionExtensions.Remove<string, ServerItem>((IDictionary<string, ServerItem>)service._settings.ServerDictionary, this.<> 8__1.serverItem.Key, ref item);
                    }
                    catch (Exception)
                    {
                        CrossArkChatService.<> c__DisplayClass31_0 CS$<> 8__locals1 = this.<> 8__1;
                        if (service._settings.LogErrors)
                        {
                            CrossArkChatService.<> c__DisplayClass31_1 class_;
                            Task.Run(new Func<Task>(class_.< GetChatMessageAsync > b__1));
                        }
                    }
                TR_005A:
                    while (true)
                    {
                        if (this.<> 7__wrap7.MoveNext())
                                    {
    this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass31_0();
    this.<> 8__1.<> 4__this = service;
    this.<> 8__1.serverItem = this.<> 7__wrap7.Current;
    this.token.ThrowIfCancellationRequested();
}
                                    else
{
    goto TR_000D;
}
break;
                                }
                                goto TR_0057;
                            }
                            finally
{
    if ((num < 0) && (this.<> 7__wrap7 != null))
                                {
        this.<> 7__wrap7.Dispose();
    }
}
break;
TR_000D:
this.<> 7__wrap7 = null;
this.< noResponce > 5__2 = null;
this.< serverRepeat > 5__3 = null;
this.< discordC > 5__4 = null;
this.< supportReply > 5__5 = null;
this.< adminCMDTag > 5__6 = null;
this.< tribeLogsTag > 5__7 = null;
break;
                        }
                        catch (OperationCanceledException)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetResult();
    return;
}
catch (Exception)
{
    CrossArkChatService <> 4__this = service;
    if (service._settings.LogErrors)
    {
        CrossArkChatService.<> c__DisplayClass31_2 class_2;
        Task.Run(new Func<Task>(class_2.< GetChatMessageAsync > b__2));
    }
}
break;
                    }
                    goto TR_0005;
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
private struct <SendAdminCommandDiscordMessageAsync>d__35: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass35_0 <> 8__1;
private TaskAwaiter<RestUserMessage> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter2;
        switch (num)
        {
            case 0:
                goto TR_0017;

            case 1:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0004;

            case 2:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_001B;

            default:
                if (!service._settings.SendAdminCommandsToOwnChannel)
                {
                    awaiter2 = Task.Delay(1, this.token).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_001B;
                    }
                    else
                    {
                        this.<> 1__state = num = 2;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendAdminCommandDiscordMessageAsync > d__35 > (ref awaiter2, ref this);
                    }
                }
                else
                {
                    goto TR_0019;
                }
                break;
        }
        return;
    TR_0004:
        awaiter2.GetResult();
        goto TR_0019;
    TR_0005:
        awaiter2 = Task.Delay(0x7d0, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendAdminCommandDiscordMessageAsync > d__35 > (ref awaiter2, ref this);
        }
        return;
    TR_0017:
        try
        {
            TaskAwaiter<RestUserMessage> awaiter;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                this.<> 1__state = num = -1;
            }
            else
            {
                goto TR_0014;
            }
        TR_000D:
            awaiter.GetResult();
            if (service._settings.LogAdminCommands)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendAdminCommandDiscordMessageAsync > b__0));
            }
            this.token.ThrowIfCancellationRequested();
        TR_0014:
            while (true)
            {
                this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass35_0();
                this.<> 8__1.<> 4__this = service;
                if (!service.AdminCommandsConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
                {
                    this.token.ThrowIfCancellationRequested();
                }
                else
                {
                    this.token.ThrowIfCancellationRequested();
                    Console.WriteLine("DiscordAdminCommand: " + this.<> 8__1.chat.Trim());
                    awaiter = (service._discord.GetChannel(service._settings.AdminCommandsDiscordChannelID) as SocketTextChannel).SendMessageAsync(this.<> 8__1.chat.Trim(), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_000D;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendAdminCommandDiscordMessageAsync > d__35 > (ref awaiter, ref this);
                    }
                    return;
                }
                break;
            }
        }
        catch (OperationCanceledException)
        {
            goto TR_0002;
        }
        catch (Exception)
        {
            CrossArkChatService <> 4__this = service;
            if (service._settings.LogErrors)
            {
                CrossArkChatService.<> c__DisplayClass35_1 class_;
                Task.Run(new Func<Task>(class_.< SendAdminCommandDiscordMessageAsync > b__1));
            }
        }
        goto TR_0005;
    TR_0019:
        while (true)
        {
            if (!service.AdminCommandsConcurrentQueue.IsEmpty)
            {
                break;
            }
            goto TR_0005;
        }
        goto TR_0017;
    TR_001B:
        awaiter2.GetResult();
        goto TR_0002;
    }
    catch (Exception exception)
    {
        this.<> 1__state = -2;
        this.<> t__builder.SetException(exception);
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
private struct <SendChatMessageAsync>d__32: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass32_0 <> 8__1;
private string < chatServerName > 5__2;
private IEnumerator<KeyValuePair<string, ServerItem>> <> 7__wrap2;
private TaskAwaiter<string> <> u__1;
private List<string>.Enumerator<> 7__wrap3;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
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
                goto TR_005C;
            }
        }
        else
        {
            goto TR_005A;
        }
    TR_0004:
        awaiter2.GetResult();
        goto TR_005C;
    TR_0005:
        awaiter2 = Task.Delay(6, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 3;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendChatMessageAsync > d__32 > (ref awaiter2, ref this);
        }
        return;
    TR_005A:
        try
        {
            TaskAwaiter<string> awaiter;
            switch (num)
            {
                case 0:
                    goto TR_0021;

                case 1:
                    goto TR_0032;

                case 2:
                    goto TR_004E;

                default:
                    break;
            }
            goto TR_0058;
        TR_000D:
            this.token.ThrowIfCancellationRequested();
            goto TR_0058;
        TR_000E:
            this.<> 7__wrap2 = null;
            this.< chatServerName > 5__2 = null;
            goto TR_000D;
        TR_0021:
            try
            {
                KeyValuePair<string, ServerItem> current;
                if (num != 0)
                {
                    goto TR_001F;
                }
                goto TR_001B;
            TR_0013:
                this.token.ThrowIfCancellationRequested();
                goto TR_001F;
            TR_001B:
                try
                {
                    if (num == 0)
                    {
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<string>();
                        this.<> 1__state = num = -1;
                        goto TR_0014;
                    }
                    else
                    {
                        if (current.Value.HideNameTag)
                        {
                            this.<> 8__1.chat = this.<> 8__1.chat.Replace(this.< chatServerName > 5__2, "");
                        }
                        awaiter = current.Value.Server.Rcon.SendCommandAsync("serverchat " + this.<> 8__1.chat.Trim()).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0014;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< SendChatMessageAsync > d__32 > (ref awaiter, ref this);
                        }
                    }
                    return;
                TR_0014:
                    awaiter.GetResult();
                    goto TR_0013;
                }
                catch (Exception)
                {
                    CrossArkChatService.<> c__DisplayClass32_0 CS$<> 8__locals1 = this.<> 8__1;
                    if (service._settings.LogErrors)
                    {
                        CrossArkChatService.<> c__DisplayClass32_1 class_;
                        Task.Run(new Func<Task>(class_.< SendChatMessageAsync > b__1));
                    }
                    goto TR_001F;
                }
                return;
            TR_001F:
                while (true)
                {
                    if (this.<> 7__wrap2.MoveNext())
                                {
    current = this.<> 7__wrap2.Current;
    if (this.< chatServerName > 5__2 == current.Key)
    {
        goto TR_0013;
    }
}
                                else
{
    goto TR_000E;
}
break;
                            }
                            goto TR_001B;
                        }
                        finally
{
    if ((num < 0) && (this.<> 7__wrap2 != null))
                            {
        this.<> 7__wrap2.Dispose();
    }
}
TR_0026:
this.<> 7__wrap3 = new List<string>.Enumerator();
goto TR_000D;
TR_0032:
try
{
    if (num == 1)
    {
        awaiter = this.<> u__1;
        this.<> u__1 = new TaskAwaiter<string>();
        this.<> 1__state = num = -1;
    }
    else
    {
        goto TR_002F;
    }
TR_0028:
    awaiter.GetResult();
TR_002F:
    while (true)
    {
        if (this.<> 7__wrap3.MoveNext())
                                {
            ServerItem item;
            string current = this.<> 7__wrap3.Current;
            service._settings.ServerDictionary.TryGetValue(current, out item);
            if (item.HideNameTag)
            {
                this.<> 8__1.chat = this.<> 8__1.chat.Replace(current, "");
            }
            awaiter = item.Server.Rcon.SendCommandAsync("serverchat " + this.<> 8__1.chat.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0028;
            }
            else
            {
                this.<> 1__state = num = 1;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< SendChatMessageAsync > d__32 > (ref awaiter, ref this);
            }
        }
                                else
        {
            goto TR_0026;
        }
        break;
    }
    return;
}
finally
{
    if (num < 0)
    {
        this.<> 7__wrap3.Dispose();
    }
}
TR_003B:
this.<> 7__wrap2 = null;
this.< chatServerName > 5__2 = null;
goto TR_000D;
TR_004E:
try
{
    KeyValuePair<string, ServerItem> current;
    if (num != 2)
    {
        goto TR_004C;
    }
    goto TR_0048;
TR_0040:
    this.token.ThrowIfCancellationRequested();
    goto TR_004C;
TR_0048:
    try
    {
        if (num == 2)
        {
            awaiter = this.<> u__1;
            this.<> u__1 = new TaskAwaiter<string>();
            this.<> 1__state = num = -1;
            goto TR_0041;
        }
        else
        {
            if (current.Value.HideNameTag)
            {
                this.<> 8__1.chat = this.<> 8__1.chat.Replace(this.< chatServerName > 5__2, "");
            }
            awaiter = current.Value.Server.Rcon.SendCommandAsync("serverchat " + this.<> 8__1.chat.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0041;
            }
            else
            {
                this.<> 1__state = num = 2;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< SendChatMessageAsync > d__32 > (ref awaiter, ref this);
            }
        }
        return;
    TR_0041:
        awaiter.GetResult();
        goto TR_0040;
    }
    catch (Exception)
    {
        CrossArkChatService.<> c__DisplayClass32_0 CS$<> 8__locals2 = this.<> 8__1;
        if (service._settings.LogErrors)
        {
            CrossArkChatService.<> c__DisplayClass32_2 class_2;
            Task.Run(new Func<Task>(class_2.< SendChatMessageAsync > b__3));
        }
        goto TR_004C;
    }
    return;
TR_004C:
    while (true)
    {
        if (this.<> 7__wrap2.MoveNext())
                                {
            current = this.<> 7__wrap2.Current;
            if (this.< chatServerName > 5__2 == current.Key)
            {
                goto TR_0040;
            }
        }
                                else
        {
            goto TR_003B;
        }
        break;
    }
    goto TR_0048;
}
finally
{
    if ((num < 0) && (this.<> 7__wrap2 != null))
                            {
        this.<> 7__wrap2.Dispose();
    }
}
TR_0058:
while (true)
{
    this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass32_0();
    this.<> 8__1.<> 4__this = service;
    if (!service.ChatConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
    {
        this.token.ThrowIfCancellationRequested();
    }
    else
    {
        this.token.ThrowIfCancellationRequested();
        if (!service._settings.UsePrefixToSendChat)
        {
            Console.WriteLine("Servers: " + this.<> 8__1.chat.Trim());
            if (service._settings.LogChat)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendChatMessageAsync > b__2));
            }
            this.< chatServerName > 5__2 = this.<> 8__1.chat.Split(' ', (StringSplitOptions)StringSplitOptions.None)[0];
            this.<> 7__wrap2 = service._settings.ServerDictionary.GetEnumerator();
        }
        else
        {
            string oldValue = this.<> 8__1.chat.Split(' ', (StringSplitOptions)StringSplitOptions.None)[2];
            this.<> 8__1.chat = this.<> 8__1.chat.Replace(oldValue, "");
            Console.WriteLine("Servers: " + this.<> 8__1.chat.Trim());
            if (service._settings.LogChat)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendChatMessageAsync > b__0));
            }
            if (oldValue.ToLower() != service._settings.AllServersChatPrefix.ToLower())
            {
                List<string> list;
                service._settings.PrefixDictionary.TryGetValue(oldValue, out list);
                this.<> 7__wrap3 = list.GetEnumerator();
            }
            else
            {
                this.< chatServerName > 5__2 = this.<> 8__1.chat.Split(' ', (StringSplitOptions)StringSplitOptions.None)[0];
                this.<> 7__wrap2 = service._settings.ServerDictionary.GetEnumerator();
                goto TR_0021;
            }
            goto TR_0032;
        }
        goto TR_004E;
    }
    break;
}
                    }
                    catch (OperationCanceledException)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetResult();
    return;
}
catch (Exception)
{
    CrossArkChatService <> 4__this = service;
    if (service._settings.LogErrors)
    {
        CrossArkChatService.<> c__DisplayClass32_3 class_3;
        Task.Run(new Func<Task>(class_3.< SendChatMessageAsync > b__4));
    }
}
goto TR_0005;
TR_005C:
while (true)
{
    if (service.ChatConcurrentQueue.IsEmpty)
    {
        break;
    }
    goto TR_005A;
}
goto TR_0005;
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
private struct <SendDiscordMessageAsync>d__34: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass34_0 <> 8__1;
private ServerItem<serverItem> 5__2;
private string < message > 5__3;
private TaskAwaiter<RestUserMessage> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter2;
        if (num > 1)
        {
            if (num == 2)
            {
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
            }
            else
            {
                goto TR_0026;
            }
        }
        else
        {
            goto TR_0024;
        }
    TR_0004:
        awaiter2.GetResult();
        goto TR_0026;
    TR_0005:
        awaiter2 = Task.Delay(0x7d0, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 2;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendDiscordMessageAsync > d__34 > (ref awaiter2, ref this);
        }
        return;
    TR_0024:
        try
        {
            TaskAwaiter<RestUserMessage> awaiter;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_0012;
            }
            else if (num == 1)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_000F;
            }
            goto TR_001F;
        TR_000E:
            if (service._settings.LogChat)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendDiscordMessageAsync > b__0));
            }
            this.token.ThrowIfCancellationRequested();
            this.< serverItem > 5__2 = null;
            this.< message > 5__3 = null;
            goto TR_001F;
        TR_000F:
            awaiter.GetResult();
            goto TR_000E;
        TR_0012:
            awaiter.GetResult();
            if (!service._settings.SendServerChatToOwnChannel)
            {
                goto TR_000E;
            }
            else
            {
                awaiter = (service._discord.GetChannel(this.< serverItem > 5__2.DiscordChannelId) as SocketTextChannel).SendMessageAsync(this.< message > 5__3.Trim(), false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_000F;
                }
                else
                {
                    this.<> 1__state = num = 1;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendDiscordMessageAsync > d__34 > (ref awaiter, ref this);
                }
            }
            return;
        TR_001F:
            while (true)
            {
                this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass34_0();
                this.<> 8__1.<> 4__this = service;
                if (!service.DiscordConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
                {
                    this.token.ThrowIfCancellationRequested();
                }
                else
                {
                    this.token.ThrowIfCancellationRequested();
                    SocketTextChannel channel = service._discord.GetChannel(service._settings.ChatDiscordChannelID) as SocketTextChannel;
                    string key = this.<> 8__1.chat.Trim().Split(' ', (StringSplitOptions)StringSplitOptions.None)[0].Replace(":", "");
                    service._settings.ServerDictionary.TryGetValue(key, out this.< serverItem > 5__2);
                    if (service._settings.UsePrefixToSendChat)
                    {
                        this.<> 8__1.chat = Regex.Replace(this.<> 8__1.chat.Trim(), "(: " + service._settings.AllServersChatPrefix + @")\w*", ":", RegexOptions.IgnoreCase);
                    }
                    string str2 = this.<> 8__1.chat.Substring(0, this.<> 8__1.chat.IndexOf(":"));
                    str2 = " (" + str2.Substring(str2.IndexOf("(") + 1);
                    string str3 = this.<> 8__1.chat.Substring(this.<> 8__1.chat.IndexOf(":") + 1);
                    string[] textArray1 = new string[] { (string)this.< serverItem > 5__2.ServerTag, (string)key, (string)this.< serverItem > 5__2.ServerPlayerTag, (string)str2, (string)this.< serverItem > 5__2.PlayerChatTag, (string)str3, (string)this.< serverItem > 5__2.ChatTag };
                    this.< message > 5__3 = string.Concat((string[])textArray1);
                    if (this.< serverItem > 5__2.HideNameTag)
                    {
                        this.< message > 5__3 = this.< message > 5__3.Replace(key, "");
                    }
                    Console.WriteLine("Discord: " + this.<> 8__1.chat.Trim());
                    awaiter = channel.SendMessageAsync(this.< message > 5__3.Trim(), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0012;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendDiscordMessageAsync > d__34 > (ref awaiter, ref this);
                    }
                    return;
                }
                break;
            }
        }
        catch (OperationCanceledException)
        {
            this.<> 1__state = -2;
            this.<> t__builder.SetResult();
            return;
        }
        catch (Exception)
        {
            CrossArkChatService <> 4__this = service;
            if (service._settings.LogErrors)
            {
                CrossArkChatService.<> c__DisplayClass34_1 class_;
                Task.Run(new Func<Task>(class_.< SendDiscordMessageAsync > b__1));
            }
        }
        goto TR_0005;
    TR_0026:
        while (true)
        {
            if (service.DiscordConcurrentQueue.IsEmpty)
            {
                break;
            }
            goto TR_0024;
        }
        goto TR_0005;
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
private struct <SendGameCommandMessagesAsync>d__37: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass37_0 <> 8__1;
private TaskAwaiter<string> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter2;
        switch (num)
        {
            case 0:
                goto TR_0017;

            case 1:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0004;

            case 2:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_001B;

            default:
                if (!service._settings.UseGameCommands)
                {
                    awaiter2 = Task.Delay(1, this.token).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_001B;
                    }
                    else
                    {
                        this.<> 1__state = num = 2;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendGameCommandMessagesAsync > d__37 > (ref awaiter2, ref this);
                    }
                }
                else
                {
                    goto TR_0019;
                }
                break;
        }
        return;
    TR_0004:
        awaiter2.GetResult();
        goto TR_0019;
    TR_0005:
        awaiter2 = Task.Delay(0x7d0, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendGameCommandMessagesAsync > d__37 > (ref awaiter2, ref this);
        }
        return;
    TR_0017:
        try
        {
            TaskAwaiter<string> awaiter;
            if (num == 0)
            {
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<string>();
                this.<> 1__state = num = -1;
            }
            else
            {
                goto TR_0014;
            }
        TR_000D:
            awaiter.GetResult();
            if (service._settings.LogChat)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendGameCommandMessagesAsync > b__0));
            }
            this.token.ThrowIfCancellationRequested();
        TR_0014:
            while (true)
            {
                this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass37_0();
                this.<> 8__1.<> 4__this = service;
                if (!service.GameCommandsConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
                {
                    this.token.ThrowIfCancellationRequested();
                }
                else
                {
                    ServerItem item;
                    string str3;
                    this.token.ThrowIfCancellationRequested();
                    string key = this.<> 8__1.chat.Substring(this.<> 8__1.chat.IndexOf(":") + 1).Split(' ', (StringSplitOptions)StringSplitOptions.None)[1];
                    string str2 = this.<> 8__1.chat.Split(' ', (StringSplitOptions)StringSplitOptions.None)[0].Replace(":", "");
                    service._settings.ServerDictionary.TryGetValue(str2, out item);
                    service._settings.GameCommandsDictionary.TryGetValue(key, out str3);
                    awaiter = item.Server.Rcon.SendCommandAsync("serverchat " + str3.Trim()).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_000D;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< SendGameCommandMessagesAsync > d__37 > (ref awaiter, ref this);
                    }
                    return;
                }
                break;
            }
        }
        catch (OperationCanceledException)
        {
            goto TR_0002;
        }
        catch (Exception)
        {
            CrossArkChatService <> 4__this = service;
            if (service._settings.LogErrors)
            {
                CrossArkChatService.<> c__DisplayClass37_1 class_;
                Task.Run(new Func<Task>(class_.< SendGameCommandMessagesAsync > b__1));
            }
        }
        goto TR_0005;
    TR_0019:
        while (true)
        {
            if (!service.GameCommandsConcurrentQueue.IsEmpty)
            {
                break;
            }
            goto TR_0005;
        }
        goto TR_0017;
    TR_001B:
        awaiter2.GetResult();
        goto TR_0002;
    }
    catch (Exception exception)
    {
        this.<> 1__state = -2;
        this.<> t__builder.SetException(exception);
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
private struct <SendSupportDiscordMessageAsync>d__36: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass36_0 <> 8__1;
private TaskAwaiter<RestUserMessage> <> u__1;
private TaskAwaiter<string> <> u__2;
private TaskAwaiter<> u__3;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter3;
        switch (num)
        {
            case 0:
            case 1:
            case 2:
                goto TR_0024;

            case 3:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0004;

            case 4:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0028;

            default:
                if (!service._settings.UseSupportPrefix)
                {
                    awaiter3 = Task.Delay(1, this.token).GetAwaiter();
                    if (awaiter3.IsCompleted)
                    {
                        goto TR_0028;
                    }
                    else
                    {
                        this.<> 1__state = num = 4;
                        this.<> u__3 = awaiter3;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendSupportDiscordMessageAsync > d__36 > (ref awaiter3, ref this);
                    }
                }
                else
                {
                    goto TR_0026;
                }
                break;
        }
        return;
    TR_0004:
        awaiter3.GetResult();
        goto TR_0026;
    TR_0005:
        awaiter3 = Task.Delay(0x7d0, this.token).GetAwaiter();
        if (awaiter3.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 3;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendSupportDiscordMessageAsync > d__36 > (ref awaiter3, ref this);
        }
        return;
    TR_0024:
        try
        {
            TaskAwaiter<RestUserMessage> awaiter;
            TaskAwaiter<string> awaiter2;
            switch (num)
            {
                case 0:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0013;

                case 1:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0017;

                case 2:
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<string>();
                    this.<> 1__state = num = -1;
                    goto TR_000F;

                default:
                    break;
            }
            goto TR_001F;
        TR_000E:
            if (service._settings.LogChat)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendSupportDiscordMessageAsync > b__1));
            }
            this.token.ThrowIfCancellationRequested();
            goto TR_001F;
        TR_000F:
            awaiter2.GetResult();
            goto TR_000E;
        TR_0012:
            if (!service._settings.ReplyToSupportPing)
            {
                goto TR_000E;
            }
            else
            {
                ServerItem item;
                string key = this.<> 8__1.chat.Trim().Split(' ', (StringSplitOptions)StringSplitOptions.None)[0].Replace(":", "");
                service._settings.ServerDictionary.TryGetValue(key, out item);
                awaiter2 = item.Server.Rcon.SendCommandAsync("serverchat " + service._settings.SupportPingReply.Trim()).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                    goto TR_000F;
                }
                else
                {
                    this.<> 1__state = num = 2;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatService.< SendSupportDiscordMessageAsync > d__36 > (ref awaiter2, ref this);
                }
            }
            return;
        TR_0013:
            awaiter.GetResult();
            goto TR_0012;
        TR_0017:
            awaiter.GetResult();
            goto TR_0012;
        TR_001F:
            while (true)
            {
                this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass36_0();
                this.<> 8__1.<> 4__this = service;
                if (!service.SupportChannelConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
                {
                    this.token.ThrowIfCancellationRequested();
                }
                else
                {
                    this.token.ThrowIfCancellationRequested();
                    SocketTextChannel channel = service._discord.GetChannel(service._settings.SupportDiscordChannelID) as SocketTextChannel;
                    Console.WriteLine("DiscordSupportMessage: " + this.<> 8__1.chat.Trim());
                    ulong id = Enumerable.FirstOrDefault<SocketRole>((IEnumerable<SocketRole>)channel.Guild.get_Roles(), new Func<SocketRole, bool>(service.< SendSupportDiscordMessageAsync > b__36_0)).Id;
                    if (!service._settings.PingRoleName)
                    {
                        awaiter = channel.SendMessageAsync(this.<> 8__1.chat.Trim(), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0017;
                        }
                        else
                        {
                            this.<> 1__state = num = 1;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendSupportDiscordMessageAsync > d__36 > (ref awaiter, ref this);
                        }
                    }
                    else
                    {
                        awaiter = channel.SendMessageAsync(MentionUtils.MentionRole(id) + " " + this.<> 8__1.chat.Trim(), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0013;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendSupportDiscordMessageAsync > d__36 > (ref awaiter, ref this);
                        }
                    }
                    return;
                }
                break;
            }
        }
        catch (OperationCanceledException)
        {
            goto TR_0002;
        }
        catch (Exception)
        {
            CrossArkChatService <> 4__this = service;
            if (service._settings.LogErrors)
            {
                CrossArkChatService.<> c__DisplayClass36_1 class_;
                Task.Run(new Func<Task>(class_.< SendSupportDiscordMessageAsync > b__2));
            }
        }
        goto TR_0005;
    TR_0026:
        while (true)
        {
            if (!service.SupportChannelConcurrentQueue.IsEmpty)
            {
                break;
            }
            goto TR_0005;
        }
        goto TR_0024;
    TR_0028:
        awaiter3.GetResult();
        goto TR_0002;
    }
    catch (Exception exception)
    {
        this.<> 1__state = -2;
        this.<> t__builder.SetException(exception);
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
private struct <SendTribeLogsAsync>d__33: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public CrossArkChatService<> 4__this;
public CancellationToken token;
private CrossArkChatService.<> c__DisplayClass33_0 <> 8__1;
private string < chatTribeID > 5__2;
private SocketTextChannel<channelName> 5__3;
private string < tempchat > 5__4;
private string < tribeName > 5__5;
private string < serverName > 5__6;
private string < tribeLog > 5__7;
private TaskAwaiter<RestUserMessage> <> u__1;
private Dictionary<string, EmbedTribeLogsItem>.Enumerator<> 7__wrap7;
private TribeItem<tribeItem> 5__9;
private SocketTextChannel<tribeIDChannel> 5__10;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    CrossArkChatService service = this.<> 4__this;
    try
    {
        TaskAwaiter awaiter2;
        switch (num)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 0x10:
            case 0x11:
            case 0x12:
            case 0x13:
            case 20:
            case 0x15:
            case 0x16:
            case 0x17:
                goto TR_010C;

            case 0x18:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0004;

            case 0x19:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0110;

            default:
                if (!service._settings.ShowTribelogs)
                {
                    awaiter2 = Task.Delay(1, this.token).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_0110;
                    }
                    else
                    {
                        this.<> 1__state = num = 0x19;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter2, ref this);
                    }
                }
                else
                {
                    goto TR_010E;
                }
                break;
        }
        return;
    TR_0004:
        awaiter2.GetResult();
        goto TR_010E;
    TR_0005:
        awaiter2 = Task.Delay(0x7d0, this.token).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_0004;
        }
        else
        {
            this.<> 1__state = num = 0x18;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter2, ref this);
        }
        return;
    TR_010C:
        try
        {
            TaskAwaiter<RestUserMessage> awaiter;
            bool flag;
            bool flag2;
            switch (num)
            {
                case 0:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0082;

                case 1:
                case 2:
                    goto TR_00C7;

                case 3:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0089;

                case 4:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00CA;

                case 5:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00CE;

                case 6:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00D3;

                case 7:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00D7;

                case 8:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00DC;

                case 9:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00E0;

                case 10:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00E5;

                case 11:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_00E9;

                case 12:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0010;

                case 13:
                case 14:
                    goto TR_0055;

                case 15:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0017;

                case 0x10:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0058;

                case 0x11:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_005C;

                case 0x12:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0061;

                case 0x13:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0065;

                case 20:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_006A;

                case 0x15:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_006E;

                case 0x16:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0073;

                case 0x17:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0077;

                default:
                    break;
            }
            goto TR_00F6;
        TR_000E:
            if (service._settings.LogTribeLogs)
            {
                Task.Run(new Func<Task>(this.<> 8__1.< SendTribeLogsAsync > b__0));
            }
            this.token.ThrowIfCancellationRequested();
            this.< chatTribeID > 5__2 = null;
            this.< channelName > 5__3 = null;
            this.< tempchat > 5__4 = null;
            this.< tribeName > 5__5 = null;
            this.< serverName > 5__6 = null;
            this.< tribeLog > 5__7 = null;
            goto TR_00F6;
        TR_000F:
            this.< tribeItem > 5__9 = null;
            this.< tribeIDChannel > 5__10 = null;
            goto TR_000E;
        TR_0010:
            awaiter.GetResult();
            goto TR_000F;
        TR_0017:
            awaiter.GetResult();
            goto TR_000F;
        TR_002D:
            this.<> 7__wrap7 = new Dictionary<string, EmbedTribeLogsItem>.Enumerator();
            if (flag2)
            {
                goto TR_000F;
            }
            else
            {
                EmbedBuilder builder4 = new EmbedBuilder();
                if (this.< tribeItem > 5__9.ShowServerName && !this.< tribeItem > 5__9.ShowTribeName)
                {
                    if (this.< tribeItem > 5__9.ShowTribeId)
                    {
                        builder4.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
                    }
                    else
                    {
                        builder4.WithTitle(this.< serverName > 5__6);
                    }
                    builder4.WithDescription(this.< tribeLog > 5__7);
                }
                else if (!this.< tribeItem > 5__9.ShowServerName && this.< tribeItem > 5__9.ShowTribeName)
                {
                    if (this.< tribeItem > 5__9.ShowTribeId)
                    {
                        builder4.WithTitle(this.< tribeName > 5__5 + " TribeID:" + this.< chatTribeID > 5__2);
                    }
                    else
                    {
                        builder4.WithTitle(this.< tribeName > 5__5);
                    }
                    builder4.WithDescription(this.< tribeLog > 5__7);
                }
                else if (!this.< tribeItem > 5__9.ShowServerName || !this.< tribeItem > 5__9.ShowTribeName)
                {
                    if (this.< tribeItem > 5__9.ShowTribeId)
                    {
                        builder4.WithTitle("TribeID:" + this.< chatTribeID > 5__2);
                    }
                    builder4.WithDescription(this.< tribeLog > 5__7);
                }
                else
                {
                    if (this.< tribeItem > 5__9.ShowTribeId)
                    {
                        builder4.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
                    }
                    else
                    {
                        builder4.WithTitle(this.< serverName > 5__6);
                    }
                    builder4.AddField(this.< tribeName > 5__5, this.< tribeLog > 5__7, false);
                }
                builder4.WithFooter(DateTime.get_Now().ToString(), null);
                awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Empty, false, builder4.Build(), null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0017;
                }
                else
                {
                    this.<> 1__state = num = 15;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                }
            }
            return;
        TR_0055:
            try
            {
                if (num == 13)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0031;
                }
                else
                {
                    if (num == 14)
                    {
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                        this.<> 1__state = num = -1;
                    }
                    else
                    {
                        while (true)
                        {
                            if (!this.<> 7__wrap7.MoveNext())
                                        {
    break;
}
KeyValuePair<string, EmbedTribeLogsItem> embedSettings = this.<> 7__wrap7.get_Current();
if (this.< tribeLog > 5__7.Contains(embedSettings.Key, (StringComparison)StringComparison.OrdinalIgnoreCase))
{
    EmbedBuilder builder3 = new EmbedBuilder();
    builder3.WithColor(new Color(Convert.ToUInt32("0x" + embedSettings.Value.LogColor, 0x10)));
    if (this.< tribeItem > 5__9.ShowServerName && !this.< tribeItem > 5__9.ShowTribeName)
    {
        if (this.< tribeItem > 5__9.ShowTribeId)
        {
            builder3.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder3.WithTitle(this.< serverName > 5__6);
        }
        builder3.WithDescription(this.< tribeLog > 5__7);
    }
    else if (!this.< tribeItem > 5__9.ShowServerName && this.< tribeItem > 5__9.ShowTribeName)
    {
        if (this.< tribeItem > 5__9.ShowTribeId)
        {
            builder3.WithTitle(this.< tribeName > 5__5 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder3.WithTitle(this.< tribeName > 5__5);
        }
        builder3.WithDescription(this.< tribeLog > 5__7);
    }
    else if (!this.< tribeItem > 5__9.ShowServerName || !this.< tribeItem > 5__9.ShowTribeName)
    {
        if (this.< tribeItem > 5__9.ShowTribeId)
        {
            builder3.WithTitle("TribeID:" + this.< chatTribeID > 5__2);
        }
        builder3.WithDescription(this.< tribeLog > 5__7);
    }
    else
    {
        if (this.< tribeItem > 5__9.ShowTribeId)
        {
            builder3.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder3.WithTitle(this.< serverName > 5__6);
        }
        builder3.AddField(this.< tribeName > 5__5, this.< tribeLog > 5__7, false);
    }
    builder3.WithFooter(DateTime.get_Now().ToString(), null);
    if (embedSettings.Value.RoleToPing != "none")
    {
        CrossArkChatService.<> c__DisplayClass33_2 class_2;
        ulong id = Enumerable.FirstOrDefault<SocketRole>((IEnumerable<SocketRole>)this.< tribeIDChannel > 5__10.Guild.get_Roles(), new Func<SocketRole, bool>(class_2.< SendTribeLogsAsync > b__2)).Id;
        awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(MentionUtils.MentionRole(id), false, builder3.Build(), null).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_0035;
        }
        else
        {
            this.<> 1__state = num = 14;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
        }
    }
    else
    {
        awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Empty, false, builder3.Build(), null).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_0031;
        }
        else
        {
            this.<> 1__state = num = 13;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
        }
    }
    return;
}
                                    }
                                    goto TR_002D;
                                }
                                goto TR_0035;
                            }
                            return;
TR_0030:
flag2 = true;
goto TR_002D;
TR_0031:
awaiter.GetResult();
goto TR_0030;
TR_0035:
awaiter.GetResult();
goto TR_0030;
                        }
                        finally
{
    if (num < 0)
    {
        this.<> 7__wrap7.Dispose();
    }
}
goto TR_002D;
TR_0058:
awaiter.GetResult();
goto TR_000F;
TR_005C:
awaiter.GetResult();
goto TR_000F;
TR_0061:
awaiter.GetResult();
goto TR_000F;
TR_0065:
awaiter.GetResult();
goto TR_000F;
TR_006A:
awaiter.GetResult();
goto TR_000F;
TR_006E:
awaiter.GetResult();
goto TR_000F;
TR_0073:
awaiter.GetResult();
goto TR_000F;
TR_0077:
awaiter.GetResult();
goto TR_000F;
TR_0081:
if (!service._settings.SendTribeLogsToOwnChannel)
{
    goto TR_000E;
}
else
{
    service._settings.TribeDictionary.TryGetValue(this.< chatTribeID > 5__2, out this.< tribeItem > 5__9);
    this.< tribeIDChannel > 5__10 = service._discord.GetChannel(this.< tribeItem > 5__9.DiscordChannelId) as SocketTextChannel;
    if (!this.< tribeItem > 5__9.ShowFullTribeLog)
    {
        if (!this.< tribeItem > 5__9.EmbedTribeLog)
        {
            if (!this.< tribeItem > 5__9.ShowServerName || this.< tribeItem > 5__9.ShowTribeName)
            {
                if (this.< tribeItem > 5__9.ShowServerName || !this.< tribeItem > 5__9.ShowTribeName)
                {
                    if (!this.< tribeItem > 5__9.ShowServerName || !this.< tribeItem > 5__9.ShowTribeName)
                    {
                        if (!this.< tribeItem > 5__9.ShowTribeId)
                        {
                            awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0077;
                            }
                            else
                            {
                                this.<> 1__state = num = 0x17;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                            }
                        }
                        else
                        {
                            awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync("TribeID:" + this.< chatTribeID > 5__2 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0073;
                            }
                            else
                            {
                                this.<> 1__state = num = 0x16;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                            }
                        }
                    }
                    else if (!this.< tribeItem > 5__9.ShowTribeId)
                    {
                        string[] textArray9 = new string[] { (string)this.< serverName > 5__6, " ", (string)this.< tribeName > 5__5, " ", (string)this.< tribeLog > 5__7 };
                        awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Concat((string[])textArray9), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_006E;
                        }
                        else
                        {
                            this.<> 1__state = num = 0x15;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                    else
                    {
                        string[] textArray8 = new string[] { (string)this.< serverName > 5__6, " ", (string)this.< tribeName > 5__5, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                        awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Concat((string[])textArray8), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_006A;
                        }
                        else
                        {
                            this.<> 1__state = num = 20;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                }
                else if (!this.< tribeItem > 5__9.ShowTribeId)
                {
                    awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(this.< tribeName > 5__5 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0065;
                    }
                    else
                    {
                        this.<> 1__state = num = 0x13;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                    }
                }
                else
                {
                    string[] textArray7 = new string[] { (string)this.< tribeName > 5__5, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                    awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Concat((string[])textArray7), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0061;
                    }
                    else
                    {
                        this.<> 1__state = num = 0x12;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                    }
                }
            }
            else if (!this.< tribeItem > 5__9.ShowTribeId)
            {
                awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(this.< serverName > 5__6 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_005C;
                }
                else
                {
                    this.<> 1__state = num = 0x11;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                }
            }
            else
            {
                string[] textArray6 = new string[] { (string)this.< serverName > 5__6, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(string.Concat((string[])textArray6), false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0058;
                }
                else
                {
                    this.<> 1__state = num = 0x10;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                }
            }
            return;
        }
        else
        {
            flag2 = false;
            this.<> 7__wrap7 = service._settings.EmbedTribeLogDictionary.GetEnumerator();
        }
    }
    else
    {
        awaiter = this.< tribeIDChannel > 5__10.SendMessageAsync(this.< tempchat > 5__4, false, null, null).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_0010;
        }
        else
        {
            this.<> 1__state = num = 12;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
        }
        return;
    }
}
goto TR_0055;
TR_0082:
awaiter.GetResult();
goto TR_0081;
TR_0089:
awaiter.GetResult();
goto TR_0081;
TR_009F:
this.<> 7__wrap7 = new Dictionary<string, EmbedTribeLogsItem>.Enumerator();
if (flag)
{
    goto TR_0081;
}
else
{
    EmbedBuilder builder2 = new EmbedBuilder();
    if (service._settings.ShowServerName && !service._settings.ShowTribeName)
    {
        if (service._settings.ShowTribeId)
        {
            builder2.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder2.WithTitle(this.< serverName > 5__6);
        }
        builder2.WithDescription(this.< tribeLog > 5__7);
    }
    else if (!service._settings.ShowServerName && service._settings.ShowTribeName)
    {
        if (service._settings.ShowTribeId)
        {
            builder2.WithTitle(this.< tribeName > 5__5 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder2.WithTitle(this.< tribeName > 5__5);
        }
        builder2.WithDescription(this.< tribeLog > 5__7);
    }
    else if (!service._settings.ShowServerName || !service._settings.ShowTribeName)
    {
        if (service._settings.ShowTribeId)
        {
            builder2.WithTitle("TribeID:" + this.< chatTribeID > 5__2);
        }
        builder2.WithDescription(this.< tribeLog > 5__7);
    }
    else
    {
        if (service._settings.ShowTribeId)
        {
            builder2.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
        }
        else
        {
            builder2.WithTitle(this.< serverName > 5__6);
        }
        builder2.AddField(this.< tribeName > 5__5, this.< tribeLog > 5__7, false);
    }
    builder2.WithFooter(DateTime.get_Now().ToString(), null);
    awaiter = this.< channelName > 5__3.SendMessageAsync(string.Empty, false, builder2.Build(), null).GetAwaiter();
    if (awaiter.IsCompleted)
    {
        goto TR_0089;
    }
    else
    {
        this.<> 1__state = num = 3;
        this.<> u__1 = awaiter;
        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
    }
}
return;
TR_00C7:
try
{
    if (num == 1)
    {
        awaiter = this.<> u__1;
        this.<> u__1 = new TaskAwaiter<RestUserMessage>();
        this.<> 1__state = num = -1;
        goto TR_00A3;
    }
    else
    {
        if (num == 2)
        {
            awaiter = this.<> u__1;
            this.<> u__1 = new TaskAwaiter<RestUserMessage>();
            this.<> 1__state = num = -1;
        }
        else
        {
            while (true)
            {
                if (!this.<> 7__wrap7.MoveNext())
                                        {
                    break;
                }
                KeyValuePair<string, EmbedTribeLogsItem> pair1 = this.<> 7__wrap7.get_Current();
                if (this.< tribeLog > 5__7.Contains(pair1.Key, (StringComparison)StringComparison.OrdinalIgnoreCase))
                {
                    EmbedBuilder builder = new EmbedBuilder();
                    builder.WithColor(new Color(Convert.ToUInt32("0x" + pair1.Value.LogColor, 0x10)));
                    if (service._settings.ShowServerName && !service._settings.ShowTribeName)
                    {
                        if (service._settings.ShowTribeId)
                        {
                            builder.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
                        }
                        else
                        {
                            builder.WithTitle(this.< serverName > 5__6);
                        }
                        builder.WithDescription(this.< tribeLog > 5__7);
                    }
                    else if (!service._settings.ShowServerName && service._settings.ShowTribeName)
                    {
                        if (service._settings.ShowTribeId)
                        {
                            builder.WithTitle(this.< tribeName > 5__5 + " TribeID:" + this.< chatTribeID > 5__2);
                        }
                        else
                        {
                            builder.WithTitle(this.< tribeName > 5__5);
                        }
                        builder.WithDescription(this.< tribeLog > 5__7);
                    }
                    else if (!service._settings.ShowServerName || !service._settings.ShowTribeName)
                    {
                        if (service._settings.ShowTribeId)
                        {
                            builder.WithTitle("TribeID:" + this.< chatTribeID > 5__2);
                        }
                        builder.WithDescription(this.< tribeLog > 5__7);
                    }
                    else
                    {
                        if (service._settings.ShowTribeId)
                        {
                            builder.WithTitle(this.< serverName > 5__6 + " TribeID:" + this.< chatTribeID > 5__2);
                        }
                        else
                        {
                            builder.WithTitle(this.< serverName > 5__6);
                        }
                        builder.AddField(this.< tribeName > 5__5, this.< tribeLog > 5__7, false);
                    }
                    builder.WithFooter(DateTime.get_Now().ToString(), null);
                    if (pair1.Value.RoleToPing != "none")
                    {
                        CrossArkChatService.<> c__DisplayClass33_1 class_;
                        ulong id = Enumerable.FirstOrDefault<SocketRole>((IEnumerable<SocketRole>)this.< channelName > 5__3.Guild.get_Roles(), new Func<SocketRole, bool>(class_.< SendTribeLogsAsync > b__1)).Id;
                        awaiter = this.< channelName > 5__3.SendMessageAsync(MentionUtils.MentionRole(id), false, builder.Build(), null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_00A7;
                        }
                        else
                        {
                            this.<> 1__state = num = 2;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                    else
                    {
                        awaiter = this.< channelName > 5__3.SendMessageAsync(string.Empty, false, builder.Build(), null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_00A3;
                        }
                        else
                        {
                            this.<> 1__state = num = 1;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                    return;
                }
            }
            goto TR_009F;
        }
        goto TR_00A7;
    }
    return;
TR_00A2:
    flag = true;
    goto TR_009F;
TR_00A3:
    awaiter.GetResult();
    goto TR_00A2;
TR_00A7:
    awaiter.GetResult();
    goto TR_00A2;
}
finally
{
    if (num < 0)
    {
        this.<> 7__wrap7.Dispose();
    }
}
goto TR_009F;
TR_00CA:
awaiter.GetResult();
goto TR_0081;
TR_00CE:
awaiter.GetResult();
goto TR_0081;
TR_00D3:
awaiter.GetResult();
goto TR_0081;
TR_00D7:
awaiter.GetResult();
goto TR_0081;
TR_00DC:
awaiter.GetResult();
goto TR_0081;
TR_00E0:
awaiter.GetResult();
goto TR_0081;
TR_00E5:
awaiter.GetResult();
goto TR_0081;
TR_00E9:
awaiter.GetResult();
goto TR_0081;
TR_00F6:
while (true)
{
    this.<> 8__1 = new CrossArkChatService.<> c__DisplayClass33_0();
    this.<> 8__1.<> 4__this = service;
    if (!service.TribeLogsConcurrentQueue.TryDequeue(out this.<> 8__1.chat))
    {
        this.token.ThrowIfCancellationRequested();
    }
    else
    {
        this.token.ThrowIfCancellationRequested();
        this.< chatTribeID > 5__2 = Regex.Match(this.<> 8__1.chat.Trim(), @"ID\s(\d*):", 1).Groups[1].Value;
        this.< channelName > 5__3 = service._discord.GetChannel(service._settings.TribeLogsDiscordChannelID) as SocketTextChannel;
        this.< tempchat > 5__4 = this.<> 8__1.chat.Trim();
        this.< tribeName > 5__5 = this.<> 8__1.chat.Substring(0, this.<> 8__1.chat.IndexOf(','));
        this.< serverName > 5__6 = this.< tribeName > 5__5.Substring(0, this.< tribeName > 5__5.IndexOf(" "));
        this.< tribeName > 5__5 = this.< tribeName > 5__5.Substring(this.< tribeName > 5__5.IndexOf(" ") + 1);
        this.< tribeLog > 5__7 = this.<> 8__1.chat.Substring(this.<> 8__1.chat.IndexOf('>') + 1);
        this.< tribeLog > 5__7 = this.< tribeLog > 5__7.Replace("</>)", "");
        string[] textArray1 = new string[] { "Servers: ", (string)this.< serverName > 5__6, " ", (string)this.< tribeName > 5__5, " ", (string)this.< tribeLog > 5__7 };
        Console.WriteLine(string.Concat((string[])textArray1));
        if (!service._settings.ShowFullTribeLog)
        {
            if (!service._settings.EmbedTribeLog)
            {
                if (!service._settings.ShowServerName || service._settings.ShowTribeName)
                {
                    if (service._settings.ShowServerName || !service._settings.ShowTribeName)
                    {
                        if (!service._settings.ShowServerName || !service._settings.ShowTribeName)
                        {
                            if (!service._settings.ShowTribeId)
                            {
                                awaiter = this.< channelName > 5__3.SendMessageAsync(this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto TR_00E9;
                                }
                                else
                                {
                                    this.<> 1__state = num = 11;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                                }
                            }
                            else
                            {
                                awaiter = this.< channelName > 5__3.SendMessageAsync("TribeID:" + this.< chatTribeID > 5__2 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto TR_00E5;
                                }
                                else
                                {
                                    this.<> 1__state = num = 10;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                                }
                            }
                        }
                        else if (!service._settings.ShowTribeId)
                        {
                            string[] textArray5 = new string[] { (string)this.< serverName > 5__6, " ", (string)this.< tribeName > 5__5, " ", (string)this.< tribeLog > 5__7 };
                            awaiter = this.< channelName > 5__3.SendMessageAsync(string.Concat((string[])textArray5), false, null, null).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_00E0;
                            }
                            else
                            {
                                this.<> 1__state = num = 9;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                            }
                        }
                        else
                        {
                            string[] textArray4 = new string[] { (string)this.< serverName > 5__6, " ", (string)this.< tribeName > 5__5, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                            awaiter = this.< channelName > 5__3.SendMessageAsync(string.Concat((string[])textArray4), false, null, null).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_00DC;
                            }
                            else
                            {
                                this.<> 1__state = num = 8;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                            }
                        }
                    }
                    else if (!service._settings.ShowTribeId)
                    {
                        awaiter = this.< channelName > 5__3.SendMessageAsync(this.< tribeName > 5__5 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_00D7;
                        }
                        else
                        {
                            this.<> 1__state = num = 7;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                    else
                    {
                        string[] textArray3 = new string[] { (string)this.< tribeName > 5__5, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                        awaiter = this.< channelName > 5__3.SendMessageAsync(string.Concat((string[])textArray3), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_00D3;
                        }
                        else
                        {
                            this.<> 1__state = num = 6;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                        }
                    }
                }
                else if (!service._settings.ShowTribeId)
                {
                    awaiter = this.< channelName > 5__3.SendMessageAsync(this.< serverName > 5__6 + " " + this.< tribeLog > 5__7, false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_00CE;
                    }
                    else
                    {
                        this.<> 1__state = num = 5;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                    }
                }
                else
                {
                    string[] textArray2 = new string[] { (string)this.< serverName > 5__6, " TribeID:", (string)this.< chatTribeID > 5__2, " ", (string)this.< tribeLog > 5__7 };
                    awaiter = this.< channelName > 5__3.SendMessageAsync(string.Concat((string[])textArray2), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_00CA;
                    }
                    else
                    {
                        this.<> 1__state = num = 4;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
                    }
                }
                return;
            }
            else
            {
                flag = false;
                this.<> 7__wrap7 = service._settings.EmbedTribeLogDictionary.GetEnumerator();
            }
        }
        else
        {
            awaiter = this.< channelName > 5__3.SendMessageAsync(this.< tempchat > 5__4, false, null, null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0082;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatService.< SendTribeLogsAsync > d__33 > (ref awaiter, ref this);
            }
            return;
        }
        goto TR_00C7;
    }
    break;
}
                    }
                    catch (OperationCanceledException)
{
    goto TR_0002;
}
catch (Exception)
{
    CrossArkChatService <> 4__this = service;
    if (service._settings.LogErrors)
    {
        CrossArkChatService.<> c__DisplayClass33_3 class_3;
        Task.Run(new Func<Task>(class_3.< SendTribeLogsAsync > b__3));
    }
}
goto TR_0005;
TR_010E:
while (true)
{
    if (!service.TribeLogsConcurrentQueue.IsEmpty)
    {
        break;
    }
    goto TR_0005;
}
goto TR_010C;
TR_0110:
awaiter2.GetResult();
goto TR_0002;
                }
                catch (Exception exception)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetException(exception);
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
    }
}

