namespace CrossArkChat
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class CrossArkChatUpdaterService
    {
        private readonly DiscordSocketClient _discord;
        private readonly HttpClient _httpClient;
        private readonly LoggingService _log;
        private readonly GeneralSettings _settings;

        public CrossArkChatUpdaterService(DiscordSocketClient discord, HttpClient httpClient, LoggingService log, GeneralSettings settings)
        {
            this._discord = discord;
            this._httpClient = httpClient;
            this._log = log;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< CrossArkChatVersionCheckerAsync > d__13))]
        public Task CrossArkChatVersionCheckerAsync()
        {
            < CrossArkChatVersionCheckerAsync > d__13 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkChatVersionCheckerAsync > d__13 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StartCrossArkChatUpdaterAsync > d__14))]
        public Task StartCrossArkChatUpdaterAsync()
        {
            < StartCrossArkChatUpdaterAsync > d__14 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartCrossArkChatUpdaterAsync > d__14 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private bool CrossArkChatVersionSent { get; set; }

        private ConcurrentDictionary<string, bool> ArkServerNotificationSentDictionary { get; set; }

        [CompilerGenerated]
        private struct <CrossArkChatVersionCheckerAsync>d__13 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public CrossArkChatUpdaterService<>4__this;
            private TaskAwaiter<Version> <>u__1;
            private TaskAwaiter<RestUserMessage> <>u__2;
            private TaskAwaiter<string> <>u__3;
            private TaskAwaiter<> u__4;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            CrossArkChatUpdaterService service = this.<> 4__this;
            try
            {
                Version version;
                TaskAwaiter<Version> awaiter;
                TaskAwaiter<RestUserMessage> awaiter2;
                string str;
                TaskAwaiter<string> awaiter3;
                TaskAwaiter awaiter4;
                switch (num)
                {
                    case 0:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<Version>();
                        this.<> 1__state = num = -1;
                        goto TR_001D;

                    case 1:
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter<RestUserMessage>();
                        this.<> 1__state = num = -1;
                        goto TR_0012;

                    case 2:
                        awaiter3 = this.<> u__3;
                        this.<> u__3 = new TaskAwaiter<string>();
                        this.<> 1__state = num = -1;
                        goto TR_000E;

                    case 3:
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter<RestUserMessage>();
                        this.<> 1__state = num = -1;
                        goto TR_000B;

                    case 4:
                        awaiter4 = this.<> u__4;
                        this.<> u__4 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0007;

                    default:
                        if (service._settings.UseVersionChecker)
                        {
                            break;
                        }
                        goto TR_0021;
                }
                goto TR_0020;
            TR_0007:
                awaiter4.GetResult();
                goto TR_0020;
            TR_0008:
                awaiter4 = Task.Delay(service._settings.VersionCheckTimeInMs).GetAwaiter();
                if (awaiter4.IsCompleted)
                {
                    goto TR_0007;
                }
                else
                {
                    this.<> 1__state = num = 4;
                    this.<> u__4 = awaiter4;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatUpdaterService.< CrossArkChatVersionCheckerAsync > d__13 > (ref awaiter4, ref this);
                }
                return;
            TR_000A:
                service.CrossArkChatVersionSent = true;
                goto TR_0008;
            TR_000B:
                awaiter2.GetResult();
                goto TR_000A;
            TR_000E:
                str = awaiter3.GetResult();
                if (str == service._settings.PatchNotesCheckUrl)
                {
                    goto TR_000A;
                }
                else
                {
                    string[] textArray1 = new string[] { (string)service._settings.PatchNotesStart, " ", (string)str, " ", (string)service._settings.PatchNotesEnd };
                    awaiter2 = (service._discord.GetChannel(service._settings.PatchNotesDiscordChannelId) as SocketTextChannel).SendMessageAsync(string.Concat((string[])textArray1), false, null, null).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_000B;
                    }
                    else
                    {
                        this.<> 1__state = num = 3;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatUpdaterService.< CrossArkChatVersionCheckerAsync > d__13 > (ref awaiter2, ref this);
                    }
                }
                return;
            TR_0012:
                awaiter2.GetResult();
                if (!service._settings.UsePatchNotesChecker)
                {
                    goto TR_000A;
                }
                else
                {
                    awaiter3 = LatestUtils.GetLatestAsync(service._httpClient, service._settings.PatchNotesCheckUrl).GetAwaiter();
                    if (!awaiter3.IsCompleted)
                    {
                        this.<> 1__state = num = 2;
                        this.<> u__3 = awaiter3;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossArkChatUpdaterService.< CrossArkChatVersionCheckerAsync > d__13 > (ref awaiter3, ref this);
                        return;
                    }
                }
                goto TR_000E;
            TR_001D:
                version = awaiter.GetResult();
                try
                {
                    Version version2;
                    if (!Version.TryParse(AssemblyUtils.GetFileVersion(), ref version2))
                    {
                        version = null;
                    }
                    if (version2 >= version)
                    {
                        version = null;
                        service.CrossArkChatVersionSent = false;
                    }
                }
                catch (Exception)
                {
                    version = null;
                }
                if ((version == null) || service.CrossArkChatVersionSent)
                {
                    goto TR_0008;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"*** New version is available - {version} ***");
                    Console.ResetColor();
                    Console.WriteLine();
                    awaiter2 = (service._discord.GetChannel(service._settings.VersionDiscordChannelId) as SocketTextChannel).SendMessageAsync($"{service._settings.VersionCheckStart} {version} {service._settings.VersionCheckEnd}", false, null, null).GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                        this.<> 1__state = num = 1;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CrossArkChatUpdaterService.< CrossArkChatVersionCheckerAsync > d__13 > (ref awaiter2, ref this);
                        return;
                    }
                }
                goto TR_0012;
            TR_0020:
                while (true)
                {
                    awaiter = VersionUtils.GetLatestVersionAsync(service._httpClient, service._settings.VersionCheckUrl).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        break;
                    }
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<Version>, CrossArkChatUpdaterService.< CrossArkChatVersionCheckerAsync > d__13 > (ref awaiter, ref this);
                    return;
                }
                goto TR_001D;
            }
            catch (Exception exception)
            {
                this.<> 1__state = -2;
                this.<> t__builder.SetException(exception);
                return;
            }
        TR_0021:
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
    private struct <StartCrossArkChatUpdaterAsync>d__14 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public CrossArkChatUpdaterService<>4__this;
            private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        CrossArkChatUpdaterService service = this.<> 4__this;
        try
        {
            int num1 = num;
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
                    list1.Add(Task.Run(new Action(service.< StartCrossArkChatUpdaterAsync > b__14_0)));
                    awaiter = Task.WhenAll(list1.ToArray()).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0007;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, CrossArkChatUpdaterService.< StartCrossArkChatUpdaterAsync > d__14 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0007:
                awaiter.GetResult();
            }
            catch (Exception)
            {
                CrossArkChatUpdaterService <> 4__this = service;
                if (service._settings.LogErrors)
                {
                    CrossArkChatUpdaterService.<> c__DisplayClass14_0 class_;
                    Task.Run(new Func<Task>(class_.< StartCrossArkChatUpdaterAsync > b__1));
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

