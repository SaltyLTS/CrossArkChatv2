namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class CrossDiscordChatHandler
    {
        private readonly DiscordSocketClient _discord;
        private readonly IConfigurationRoot _config;
        private readonly LoggingService _log;
        private readonly GeneralSettings _settings;
        private bool IgnoreOtherBots;
        private string DiscordCommandPrefix;
        private string DiscordChatPrefix;
        private bool ShowDiscordNickName;

        public CrossDiscordChatHandler(DiscordSocketClient discord, IConfigurationRoot config, LoggingService log, GeneralSettings settings)
        {
            this._discord = discord;
            this._config = config;
            this._log = log;
            this._settings = settings;
            this.IgnoreOtherBots = bool.Parse(this._config["DiscordSettings:DiscordBotSettings:IgnoreOtherBots"]);
            this.DiscordCommandPrefix = this._config["DiscordSettings:DiscordBotSettings:CommandPrefix"];
            this.DiscordChatPrefix = this._config["DiscordSettings:DiscordChatSettings:DiscordChatPrefix"];
            this.ShowDiscordNickName = bool.Parse(this._config["DiscordSettings:DiscordBotSettings:ShowDiscordNickName"]);
            this._discord.add_MessageReceived(new Func<SocketMessage, Task>(this.OnMessageReceivedAsync));
        }

        [AsyncStateMachine((Type)typeof(< OnMessageReceivedAsync > d__9))]
        private Task OnMessageReceivedAsync(SocketMessage message)
        {
            < OnMessageReceivedAsync > d__9 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << OnMessageReceivedAsync > d__9 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SendChatMessageAsync > d__10))]
        private Task SendChatMessageAsync(SocketUserMessage msg)
        {
            < SendChatMessageAsync > d__10 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.msg = msg;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SendChatMessageAsync > d__10 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <OnMessageReceivedAsync>d__9 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public SocketMessage message;
        public CrossDiscordChatHandler<>4__this;

            private void MoveNext()
        {
            CrossDiscordChatHandler handler = this.<> 4__this;
            try
            {
                SocketUserMessage msg = this.message as SocketUserMessage;
                if (((msg != null) && (!handler.IgnoreOtherBots || !msg.Author.IsBot)) && (msg.Author.Username != handler._discord.CurrentUser.Username))
                {
                    int num = 0;
                    if (!MessageExtensions.HasStringPrefix(msg, handler.DiscordCommandPrefix, ref num, (StringComparison)StringComparison.Ordinal))
                    {
                        handler.SendChatMessageAsync(msg);
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

    [CompilerGenerated]
    private struct <SendChatMessageAsync>d__10 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public SocketUserMessage msg;
    public CrossDiscordChatHandler<>4__this;
            private CrossDiscordChatHandler.<>c__DisplayClass10_1<>8__1;
            private CrossDiscordChatHandler.<>c__DisplayClass10_0<>8__2;
            private TaskAwaiter<string> <>u__1;
            private IEnumerator<ServerItem> <>7__wrap1;

            private void MoveNext()
    {
        int num = this.<> 1__state;
        CrossDiscordChatHandler handler = this.<> 4__this;
        try
        {
            if (num <= 2)
            {
                goto TR_0041;
            }
            else
            {
                this.<> 8__2 = new CrossDiscordChatHandler.<> c__DisplayClass10_0();
                this.<> 8__2.msg = this.msg;
                this.<> 8__2.<> 4__this = this.<> 4__this;
                if (!handler._settings.SendServerChatToOwnChannel)
                {
                    if (this.<> 8__2.msg.Channel.Id == handler._settings.ChatDiscordChannelID)
                    {
                        goto TR_0044;
                    }
                }
                else if ((Enumerable.FirstOrDefault<ServerItem>((IEnumerable<ServerItem>)handler._settings.ServerDictionary.get_Values(), new Func<ServerItem, bool>(this.<> 8__2.< SendChatMessageAsync > b__0)) != null) || (this.<> 8__2.msg.Channel.Id == handler._settings.ChatDiscordChannelID))
                {
                    goto TR_0044;
                }
            }
            goto TR_0002;
        TR_0041:
            try
            {
                TaskAwaiter<string> awaiter;
                switch (num)
                {
                    case 0:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<string>();
                        this.<> 1__state = num = -1;
                        goto TR_000B;

                    case 1:
                        goto TR_001A;

                    case 2:
                        goto TR_002B;

                    default:
                        {
                            this.<> 8__1 = new CrossDiscordChatHandler.<> c__DisplayClass10_1();
                            this.<> 8__1.CS$<> 8__locals1 = this.<> 8__2;
                            string input = this.<> 8__1.CS$<> 8__locals1.msg.ToString();
                            if (handler._settings.UseWordReplacementList)
                            {
                                Dictionary<string, string>.Enumerator enumerator = handler._settings.WorldReplacementDictionary.GetEnumerator();
                                try
                                {
                                    while (enumerator.MoveNext())
                                    {
                                        KeyValuePair<string, string> pair = enumerator.get_Current();
                                        input = input.Replace(pair.Key, pair.Value);
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
                            this.<> 8__1.cleaned = Regex.Replace(input, @"\b" + string.Join(@"\b|\b", handler._settings.WordFilterList.ToArray()) + @"\b", "");
                            string key = this.<> 8__1.cleaned.Split(' ', (StringSplitOptions)StringSplitOptions.None)[0];
                            if (handler._settings.ServerDictionary.ContainsKey(key.Trim()))
                            {
                                string oldValue = key;
                                if (key == null)
                                {
                                    string local1 = key;
                                    oldValue = "";
                                }
                                this.<> 8__1.cleaned = this.<> 8__1.cleaned.Replace(oldValue, "");
                            }
                            string[] textArray1 = new string[] { (string)handler.DiscordChatPrefix, ": (", (string)this.<> 8__1.CS$<> 8__locals1.chatd, "): ", (string)this.<> 8__1.cleaned };
                            Console.WriteLine(string.Concat((string[])textArray1));
                            if (handler._settings.LogChat)
                            {
                                Task.Run(new Func<Task>(this.<> 8__1.< SendChatMessageAsync > b__1));
                            }
                            if (!handler._settings.ServerDictionary.ContainsKey(key.Trim()))
                            {
                                if ((Enumerable.FirstOrDefault<ServerItem>((IEnumerable<ServerItem>)handler._settings.ServerDictionary.get_Values(), new Func<ServerItem, bool>(this.<> 8__1.CS$<> 8__locals1.< SendChatMessageAsync > b__2)) == null) || (this.<> 8__1.CS$<> 8__locals1.msg.Channel.Id == handler._settings.ChatDiscordChannelID))
                                    {
                                    this.<> 7__wrap1 = handler._settings.ServerDictionary.get_Values().GetEnumerator();
                                }
                                    else
                                {
                                    this.<> 7__wrap1 = Enumerable.Where<ServerItem>((IEnumerable<ServerItem>)handler._settings.ServerDictionary.get_Values(), new Func<ServerItem, bool>(this.<> 8__1.CS$<> 8__locals1.< SendChatMessageAsync > b__3)).GetEnumerator();
                                    goto TR_001A;
                                }
                                goto TR_002B;
                            }
                            else
                            {
                                ServerItem item;
                                handler._settings.ServerDictionary.TryGetValue(key, out item);
                                string[] textArray2 = new string[] { "serverchat ", (string)handler.DiscordChatPrefix, ": (", (string)this.<> 8__1.CS$<> 8__locals1.chatd, "): ", (string)this.<> 8__1.cleaned };
                                awaiter = item.Server.Rcon.SendCommandAsync(string.Concat((string[])textArray2)).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto TR_000B;
                                }
                                else
                                {
                                    this.<> 1__state = num = 0;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossDiscordChatHandler.< SendChatMessageAsync > d__10 > (ref awaiter, ref this);
                                }
                            }
                            break;
                        }
                }
                return;
            TR_000A:
                this.<> 8__1 = null;
                goto TR_0002;
            TR_000B:
                awaiter.GetResult();
                goto TR_000A;
            TR_0011:
                this.<> 7__wrap1 = null;
                goto TR_000A;
            TR_001A:
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
                        goto TR_0017;
                    }
                TR_0013:
                    awaiter.GetResult();
                TR_0017:
                    while (true)
                    {
                        if (this.<> 7__wrap1.MoveNext())
                                {
                            string[] textArray3 = new string[] { "serverchat ", (string)handler.DiscordChatPrefix, ": (", (string)this.<> 8__1.CS$<> 8__locals1.chatd, "): ", (string)this.<> 8__1.cleaned };
                            awaiter = this.<> 7__wrap1.Current.Server.Rcon.SendCommandAsync(string.Concat((string[])textArray3)).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0013;
                            }
                            else
                            {
                                this.<> 1__state = num = 1;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossDiscordChatHandler.< SendChatMessageAsync > d__10 > (ref awaiter, ref this);
                            }
                        }
                                else
                        {
                            goto TR_0011;
                        }
                        break;
                    }
                    return;
                }
                finally
                {
                    if ((num < 0) && (this.<> 7__wrap1 != null))
                            {
                        this.<> 7__wrap1.Dispose();
                    }
                }
            TR_001F:
                this.<> 7__wrap1 = null;
                goto TR_000A;
            TR_002B:
                try
                {
                    ServerItem current;
                    if (num != 2)
                    {
                        goto TR_0029;
                    }
                TR_0026:
                    try
                    {
                        if (num == 2)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            goto TR_0021;
                        }
                        else
                        {
                            string[] textArray4 = new string[] { "serverchat ", (string)handler.DiscordChatPrefix, ": (", (string)this.<> 8__1.CS$<> 8__locals1.chatd, "): ", (string)this.<> 8__1.cleaned };
                            awaiter = current.Server.Rcon.SendCommandAsync(string.Concat((string[])textArray4)).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0021;
                            }
                            else
                            {
                                this.<> 1__state = num = 2;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, CrossDiscordChatHandler.< SendChatMessageAsync > d__10 > (ref awaiter, ref this);
                            }
                        }
                        return;
                    TR_0021:
                        awaiter.GetResult();
                    }
                    catch (Exception)
                    {
                    }
                TR_0029:
                    while (true)
                    {
                        if (this.<> 7__wrap1.MoveNext())
                                {
                            current = this.<> 7__wrap1.Current;
                        }
                                else
                        {
                            goto TR_001F;
                        }
                        break;
                    }
                    goto TR_0026;
                }
                finally
                {
                    if ((num < 0) && (this.<> 7__wrap1 != null))
                            {
                        this.<> 7__wrap1.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                CrossDiscordChatHandler.<> c__DisplayClass10_0 CS$<> 8__locals2 = this.<> 8__2;
                if (handler._settings.LogErrors)
                {
                    CrossDiscordChatHandler.<> c__DisplayClass10_2 class_;
                    Task.Run(new Func<Task>(class_.< SendChatMessageAsync > b__4));
                }
            }
            goto TR_0002;
        TR_0044:
            this.<> 8__2.chatd = string.Empty;
            if (!handler.ShowDiscordNickName)
            {
                this.<> 8__2.chatd = this.<> 8__2.msg.Author.Username;
            }
            else
            {
                SocketGuildUser author = this.<> 8__2.msg.Author as SocketGuildUser;
                this.<> 8__2.chatd = !string.IsNullOrWhiteSpace(author.Nickname) ? author.Nickname : author.Username;
            }
            goto TR_0041;
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.<> 8__2 = null;
            this.<> t__builder.SetException(exception);
            return;
        }
    TR_0002:
        this.<> 1__state = -2;
        this.<> 8__2 = null;
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

