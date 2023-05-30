namespace CrossArkChat
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class ListPlayersService
    {
        private readonly DiscordSocketClient _discord;
        private readonly LoggingService _log;
        private readonly GeneralSettings _settings;

        public ListPlayersService(DiscordSocketClient discord, LoggingService log, GeneralSettings settings)
        {
            this._discord = discord;
            this._log = log;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< ListPlayersAsync > d__12))]
        public Task ListPlayersAsync()
        {
            < ListPlayersAsync > d__12 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ListPlayersAsync > d__12 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendJoinLeaveNotificationsAsync > d__13))]
        public Task SendJoinLeaveNotificationsAsync()
        {
            < SendJoinLeaveNotificationsAsync > d__13 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendJoinLeaveNotificationsAsync > d__13 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< StartListPlayersAsync > d__14))]
        public Task StartListPlayersAsync()
        {
            < StartListPlayersAsync > d__14 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartListPlayersAsync > d__14 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private ConcurrentDictionary<string, ListPlayersItem> OnlinePlayerDictionary { get; set; }

        private ConcurrentQueue<string> JoinLeaveNotifcationsConcurrentQueue { get; set; }

        [CompilerGenerated]
        private struct <ListPlayersAsync>d__12 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public ListPlayersService<>4__this;
            private ListPlayersService.<>c__DisplayClass12_0<>8__1;
            private string <noResponce>5__2;
            private string <noPlayer>5__3;
            private IEnumerator<KeyValuePair<string, ServerItem>> <>7__wrap3;
            private KeyValuePair<string, ServerItem> <serverItem>5__5;
            private TaskAwaiter<string> <>u__1;
            private TaskAwaiter<> u__2;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            ListPlayersService service = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                switch (num)
                {
                    case 0:
                        goto TR_0041;

                    case 1:
                        awaiter = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0003;

                    case 2:
                        awaiter = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0044;

                    default:
                        if (!service._settings.UseJoinLeaveNotifications)
                        {
                            awaiter = Task.Delay(1).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0044;
                            }
                            else
                            {
                                this.<> 1__state = num = 2;
                                this.<> u__2 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ListPlayersService.< ListPlayersAsync > d__12 > (ref awaiter, ref this);
                            }
                        }
                        else
                        {
                            goto TR_0041;
                        }
                        break;
                }
                return;
            TR_0003:
                awaiter.GetResult();
                goto TR_0041;
            TR_0004:
                awaiter = Task.Delay(service._settings.ListPlayerCheckTimeInMs).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0003;
                }
                else
                {
                    this.<> 1__state = num = 1;
                    this.<> u__2 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ListPlayersService.< ListPlayersAsync > d__12 > (ref awaiter, ref this);
                }
                return;
            TR_0041:
                while (true)
                {
                    try
                    {
                        if (num != 0)
                        {
                            this.<> 8__1 = new ListPlayersService.<> c__DisplayClass12_0();
                            this.<> 8__1.<> 4__this = service;
                            this.< noResponce > 5__2 = service._settings.NoResponceTag;
                            this.< noPlayer > 5__3 = service._settings.NoPlayerTag;
                            this.<> 8__1.onlinePlayers = new List<ListPlayersItem>();
                            this.<> 7__wrap3 = service._settings.ServerDictionary.GetEnumerator();
                        }
                        try
                        {
                            if (num != 0)
                            {
                                goto TR_003B;
                            }
                            goto TR_0038;
                        TR_001B:
                            this.< serverItem > 5__5 = new KeyValuePair<string, ServerItem>();
                            goto TR_003B;
                        TR_0038:
                            try
                            {
                                string str;
                                TaskAwaiter<string> awaiter;
                                if (num == 0)
                                {
                                    awaiter = this.<> u__1;
                                    this.<> u__1 = new TaskAwaiter<string>();
                                    this.<> 1__state = num = -1;
                                    goto TR_0032;
                                }
                                else
                                {
                                    awaiter = this.< serverItem > 5__5.Value.Server.Rcon.SendCommandAsync(service._settings.ListPlayersCmd).GetAwaiter();
                                    if (awaiter.IsCompleted)
                                    {
                                        goto TR_0032;
                                    }
                                    else
                                    {
                                        this.<> 1__state = num = 0;
                                        this.<> u__1 = awaiter;
                                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, ListPlayersService.< ListPlayersAsync > d__12 > (ref awaiter, ref this);
                                    }
                                }
                                return;
                            TR_0032:
                                str = awaiter.GetResult();
                                if (str != null)
                                {
                                    if (str.StartsWith(this.< noResponce > 5__2.Trim()))
                                    {
                                        goto TR_003B;
                                    }
                                    else if (!str.StartsWith(this.< noPlayer > 5__3.Trim()))
                                    {
                                        StringReader reader = new StringReader(str);
                                        try
                                        {
                                            string str2;
                                            while ((str2 = reader.ReadLine()) != null)
                                            {
                                                string steamName;
                                                if ((str2.Length >= 1) && !string.IsNullOrWhiteSpace(str2))
                                                {
                                                    ListPlayersService.<> c__DisplayClass12_1 class_;
                                                    steamName = str2.Substring(0, str2.IndexOf(","));
                                                    steamName = steamName.Substring(steamName.IndexOf(" ") + 1);
                                                    if (service._settings.UseWordReplacementList)
                                                    {
                                                        Dictionary<string, string>.Enumerator enumerator = service._settings.WorldReplacementDictionary.GetEnumerator();
                                                        try
                                                        {
                                                            while (enumerator.MoveNext())
                                                            {
                                                                KeyValuePair<string, string> pair = enumerator.get_Current();
                                                                steamName = steamName.Replace(pair.Key, pair.Value);
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
                                                    string str3 = this.< serverItem > 5__5.Key.Replace(":", "");
                                                    if (Enumerable.FirstOrDefault<ListPlayersItem>((IEnumerable<ListPlayersItem>)this.<> 8__1.onlinePlayers, new Func<ListPlayersItem, bool>(class_.< ListPlayersAsync > b__1)) == null)
                                                    {
                                                        ListPlayersItem item1 = new ListPlayersItem();
                                                        item1.SteamName = steamName;
                                                        item1.ServerName = str3;
                                                        item1.IsOnline = true;
                                                        ListPlayersItem newPlayer = item1;
                                                        this.<> 8__1.onlinePlayers.Add(newPlayer);
                                                        bool playerJoined = false;
                                                        service.OnlinePlayerDictionary.AddOrUpdate(newPlayer.SteamName, new Func<string, ListPlayersItem>(class_.< ListPlayersAsync > b__2), new Func<string, ListPlayersItem, ListPlayersItem>(class_.< ListPlayersAsync > b__3));
                                                        if (playerJoined)
                                                        {
                                                            string[] textArray1 = new string[11];
                                                            textArray1[0] = (string)newPlayer.ServerName;
                                                            textArray1[1] = " :";
                                                            textArray1[2] = (string)service._settings.PlayerJoinStart;
                                                            textArray1[3] = " ";
                                                            textArray1[4] = (string)newPlayer.SteamName;
                                                            textArray1[5] = " ";
                                                            textArray1[6] = (string)service._settings.PlayerJoinMiddle;
                                                            textArray1[7] = " ";
                                                            textArray1[8] = (string)newPlayer.ServerName;
                                                            textArray1[9] = " ";
                                                            textArray1[10] = (string)service._settings.PlayerJoinEnd;
                                                            service.JoinLeaveNotifcationsConcurrentQueue.Enqueue(string.Concat((string[])textArray1));
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
                                        goto TR_003B;
                                    }
                                }
                                else
                                {
                                    goto TR_003B;
                                }
                                goto TR_001B;
                            }
                            catch (Exception)
                            {
                                ListPlayersService.<> c__DisplayClass12_0 CS$<> 8__locals1 = this.<> 8__1;
                                if (service._settings.LogErrors)
                                {
                                    ListPlayersService.<> c__DisplayClass12_2 class_2;
                                    Task.Run(new Func<Task>(class_2.< ListPlayersAsync > b__4));
                                }
                            }
                        TR_003B:
                            while (true)
                            {
                                if (this.<> 7__wrap3.MoveNext())
                                    {
                                    this.< serverItem > 5__5 = this.<> 7__wrap3.Current;
                                }
                                    else
                                {
                                    goto TR_0013;
                                }
                                break;
                            }
                            goto TR_0038;
                        }
                        finally
                        {
                            if ((num < 0) && (this.<> 7__wrap3 != null))
                                {
                                this.<> 7__wrap3.Dispose();
                            }
                        }
                        break;
                    TR_0013:
                        this.<> 7__wrap3 = null;
                        ListPlayersItem[] itemArray = Enumerable.ToArray<ListPlayersItem>(Enumerable.Where<ListPlayersItem>((IEnumerable<ListPlayersItem>)service.OnlinePlayerDictionary.get_Values(), new Func<ListPlayersItem, bool>(this.<> 8__1.< ListPlayersAsync > b__0)));
                        int index = 0;
                        while (true)
                        {
                            if (index >= itemArray.Length)
                            {
                                this.<> 8__1 = null;
                                this.< noResponce > 5__2 = null;
                                this.< noPlayer > 5__3 = null;
                                break;
                            }
                            ListPlayersItem item = itemArray[index];
                            if (item.IsOnline)
                            {
                                item.IsOnline = false;
                                string[] textArray2 = new string[11];
                                textArray2[0] = (string)item.ServerName;
                                textArray2[1] = " :";
                                textArray2[2] = (string)service._settings.PlayerLeftStart;
                                textArray2[3] = " ";
                                textArray2[4] = (string)item.SteamName;
                                textArray2[5] = " ";
                                textArray2[6] = (string)service._settings.PlayerLeftMiddle;
                                textArray2[7] = " ";
                                textArray2[8] = (string)item.ServerName;
                                textArray2[9] = " ";
                                textArray2[10] = (string)service._settings.PlayerLeftEnd;
                                service.JoinLeaveNotifcationsConcurrentQueue.Enqueue(string.Concat((string[])textArray2));
                            }
                            index++;
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        ListPlayersService <> 4__this = service;
                        if (service._settings.LogErrors)
                        {
                            ListPlayersService.<> c__DisplayClass12_4 class_3;
                            Task.Run(new Func<Task>(class_3.< ListPlayersAsync > b__6));
                        }
                    }
                    break;
                }
                goto TR_0004;
            TR_0044:
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
    private struct <SendJoinLeaveNotificationsAsync>d__13 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public ListPlayersService<>4__this;
            private ListPlayersService.<>c__DisplayClass13_0<>8__1;
            private ServerItem<serverItem>5__2;
            private TaskAwaiter<RestUserMessage> <>u__1;
            private TaskAwaiter<> u__2;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        ListPlayersService service = this.<> 4__this;
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
                    goto TR_0024;
                }
            }
            else
            {
                goto TR_0022;
            }
        TR_0003:
            awaiter2.GetResult();
            goto TR_0024;
        TR_0004:
            awaiter2 = Task.Delay(0x7d0).GetAwaiter();
            if (awaiter2.IsCompleted)
            {
                goto TR_0003;
            }
            else
            {
                this.<> 1__state = num = 2;
                this.<> u__2 = awaiter2;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ListPlayersService.< SendJoinLeaveNotificationsAsync > d__13 > (ref awaiter2, ref this);
            }
            return;
        TR_0022:
            try
            {
                TaskAwaiter<RestUserMessage> awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0011;
                }
                else if (num == 1)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000E;
                }
                goto TR_001D;
            TR_000D:
                if (service._settings.LogChat)
                {
                    Task.Run(new Func<Task>(this.<> 8__1.< SendJoinLeaveNotificationsAsync > b__0));
                }
                this.< serverItem > 5__2 = null;
                goto TR_001D;
            TR_000E:
                awaiter.GetResult();
                goto TR_000D;
            TR_0011:
                awaiter.GetResult();
                if (!service._settings.SendJoinLeaveNotificationsToServerOwnChannel)
                {
                    goto TR_000D;
                }
                else
                {
                    awaiter = (service._discord.GetChannel(this.< serverItem > 5__2.DiscordChannelId) as SocketTextChannel).SendMessageAsync(this.<> 8__1.notification.Trim(), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_000E;
                    }
                    else
                    {
                        this.<> 1__state = num = 1;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, ListPlayersService.< SendJoinLeaveNotificationsAsync > d__13 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_001D:
                while (true)
                {
                    this.<> 8__1 = new ListPlayersService.<> c__DisplayClass13_0();
                    this.<> 8__1.<> 4__this = service;
                    if (!service.JoinLeaveNotifcationsConcurrentQueue.TryDequeue(out this.<> 8__1.notification))
                    {
                        break;
                    }
                    string key = this.<> 8__1.notification.Split(' ', (StringSplitOptions)StringSplitOptions.None)[0];
                    this.<> 8__1.notification = this.<> 8__1.notification.Substring(this.<> 8__1.notification.IndexOf(":") + 1);
                    string text1 = this.<> 8__1.notification.Trim();
                    string text2 = text1;
                    if (text1 == null)
                    {
                        string local1 = text1;
                        text2 = "";
                    }
                    Console.WriteLine(text2);
                    service._settings.ServerDictionary.TryGetValue(key, out this.< serverItem > 5__2);
                    if (this.< serverItem > 5__2.HideNameTag)
                    {
                        this.<> 8__1.notification = this.<> 8__1.notification.Replace(key, "");
                    }
                    awaiter = (service._discord.GetChannel(service._settings.JoinLeaveNotificationsDiscordChannelID) as SocketTextChannel).SendMessageAsync(this.<> 8__1.notification.Trim(), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0011;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, ListPlayersService.< SendJoinLeaveNotificationsAsync > d__13 > (ref awaiter, ref this);
                    }
                    return;
                }
            }
            catch (Exception)
            {
                ListPlayersService <> 4__this = service;
                if (service._settings.LogErrors)
                {
                    ListPlayersService.<> c__DisplayClass13_1 class_;
                    Task.Run(new Func<Task>(class_.< SendJoinLeaveNotificationsAsync > b__1));
                }
            }
            goto TR_0004;
        TR_0024:
            while (true)
            {
                if (service.JoinLeaveNotifcationsConcurrentQueue.IsEmpty)
                {
                    break;
                }
                goto TR_0022;
            }
            goto TR_0004;
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
private struct <StartListPlayersAsync>d__14: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public ListPlayersService<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    ListPlayersService service = this.<> 4__this;
    try
    {
        if ((num == 0) || service._settings.UseJoinLeaveNotifications)
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
                    list1.Add(Task.Run(new Action(service.< StartListPlayersAsync > b__14_0)));
                    list1.Add(Task.Run(new Action(service.< StartListPlayersAsync > b__14_1)));
                    awaiter = Task.WhenAll(list1.ToArray()).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0007;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ListPlayersService.< StartListPlayersAsync > d__14 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0007:
                awaiter.GetResult();
            }
            catch (Exception)
            {
                ListPlayersService <> 4__this = service;
                if (service._settings.LogErrors)
                {
                    ListPlayersService.<> c__DisplayClass14_0 class_;
                    Task.Run(new Func<Task>(class_.< StartListPlayersAsync > b__2));
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

