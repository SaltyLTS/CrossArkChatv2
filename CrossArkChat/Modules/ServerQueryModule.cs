namespace CrossArkChat.Modules
{
    using CrossArkChat;
    using CrossArkChat.Enums;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    [Name("ServerQuery")]
    public class ServerQueryModule : InteractiveBase
    {
        private readonly IConfigurationRoot _config;
        private readonly GeneralSettings _settings;

        public ServerQueryModule(IConfigurationRoot config, GeneralSettings settings)
        {
            this._config = config;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< ServerInfoAsync > d__5)), Command("serverinfo", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerInfo), Summary("Poll your server for information using mapName."), Remarks("serverinfo serverName")]
        public Task ServerInfoAsync(string serverName)
        {
            < ServerInfoAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerInfoAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerInfoAsync > d__4)), Command("serverinfo", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerInfo), Summary("Poll server for information"), Remarks("serverinfo serverIp queryPort")]
        public Task ServerInfoAsync(string serverIp, int queryPort)
        {
            < ServerInfoAsync > d__4 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverIp = serverIp;
            d__.queryPort = queryPort;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerInfoAsync > d__4 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerListAsync > d__3)), Command("serverlist", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerList), Summary("List information for all active servers."), Remarks("serverlist")]
        public Task ServerListAsync()
        {
            < ServerListAsync > d__3 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerListAsync > d__3 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <ServerInfoAsync>d__4 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public string serverIp;
        public int queryPort;
        public ServerQueryModule<>4__this;
            private object <>7__wrap1;
            private int <>7__wrap2;
            private Server<gameServer>5__4;
            private TaskAwaiter<IUserMessage> <>u__1;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            ServerQueryModule module = this.<> 4__this;
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
                    if (num > 1)
                    {
                        this.< gameServer > 5__4 = ServerQuery.GetServerInstance(EngineType.Source, new IPEndPoint(IPAddress.Parse(this.serverIp), this.queryPort), false, 0xbb8, 0xbb8, 1, true);
                    }
                    try
                    {
                        if (num == 0)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_000F;
                        }
                        else if (num == 1)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_0013;
                        }
                        else
                        {
                            ServerInfo info1;
                            if (this.< gameServer > 5__4 != null)
                            {
                                info1 = this.< gameServer > 5__4.GetInfo(null);
                            }
                            else
                            {
                                Server local1 = this.< gameServer > 5__4;
                                info1 = null;
                            }
                            ServerInfo info = info1;
                            if (info != null)
                            {
                                object[] objArray1 = new object[11];
                                objArray1[0] = info.Name;
                                objArray1[1] = module._settings.ServerInfoMap;
                                objArray1[2] = info.Map;
                                objArray1[3] = module._settings.ServerInfoPlayerOnline;
                                objArray1[4] = (int)info.Players;
                                objArray1[5] = module._settings.ServerInfoMaxPlayer;
                                objArray1[6] = (byte)info.MaxPlayers;
                                objArray1[7] = module._settings.ServerInfoPing;
                                objArray1[8] = (long)info.Ping;
                                objArray1[9] = module._settings.ServerInfoConnect;
                                objArray1[10] = info.Address;
                                awaiter = module.ReplyAsync(string.Format("**{0}**\n{1} {2}\n{3} {4}\n{5} {6}\n{7} {8}\n{9} <steam://connect/{10}>", (object[])objArray1), false, null, null).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto TR_0013;
                                }
                                else
                                {
                                    this.<> 1__state = num = 1;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__4 > (ref awaiter, ref this);
                                }
                            }
                            else
                            {
                                string[] textArray1 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerInfoAsync", (string)module._settings.NoInfoFoundMiddle, " ", (string)module._settings.NoCommandFoundEnd };
                                awaiter = module.ReplyAsync(string.Concat((string[])textArray1), false, null, null).GetAwaiter();
                                if (awaiter.IsCompleted)
                                {
                                    goto TR_000F;
                                }
                                else
                                {
                                    this.<> 1__state = num = 0;
                                    this.<> u__1 = awaiter;
                                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__4 > (ref awaiter, ref this);
                                }
                            }
                        }
                        return;
                    TR_000F:
                        awaiter.GetResult();
                        goto TR_000E;
                    TR_0013:
                        awaiter.GetResult();
                        goto TR_000E;
                    }
                    finally
                    {
                        if ((num < 0) && (this.< gameServer > 5__4 != null))
                        {
                            this.< gameServer > 5__4.Dispose();
                        }
                    }
                    return;
                TR_000E:
                    this.< gameServer > 5__4 = null;
                }
                catch (Exception exception)
                {
                    this.<> 7__wrap1 = exception;
                    this.<> 7__wrap2 = 1;
                }
                goto TR_0008;
            TR_0004:
                this.<> 7__wrap1 = null;
                this.<> 1__state = -2;
                this.<> t__builder.SetResult();
                return;
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
                    Exception exception1 = (Exception)this.<> 7__wrap1;
                    string[] textArray2 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerInfoAsync", (string)module._settings.NoInfoFoundMiddle, " ", (string)module._settings.NoInfoFoundEnd };
                    awaiter = module.ReplyAsync(string.Concat((string[])textArray2), false, null, null).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0005;
                    }
                    else
                    {
                        this.<> 1__state = num = 2;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__4 > (ref awaiter, ref this);
                    }
                }
            }
            catch (Exception exception2)
            {
                this.<> 1__state = -2;
                this.<> t__builder.SetException(exception2);
            }
        }

        [DebuggerHidden]
        private void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            this.<> t__builder.SetStateMachine(stateMachine);
        }
    }

    [CompilerGenerated]
    private struct <ServerInfoAsync>d__5 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public ServerQueryModule<>4__this;
            public string serverName;
    private object <>7__wrap1;
            private int <>7__wrap2;
            private TaskAwaiter<IUserMessage> <>u__1;

            private void MoveNext()
    {
        int num = this.<> 1__state;
        ServerQueryModule module = this.<> 4__this;
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
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000B;
                }
                else if (num == 1)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000F;
                }
                else
                {
                    Server server;
                    module._settings.ServerQueryDictionary.TryGetValue(this.serverName, out server);
                    ServerInfo info = server?.GetInfo(null);
                    if (info != null)
                    {
                        object[] objArray1 = new object[11];
                        objArray1[0] = info.Name;
                        objArray1[1] = module._settings.ServerInfoMap;
                        objArray1[2] = info.Map;
                        objArray1[3] = module._settings.ServerInfoPlayerOnline;
                        objArray1[4] = (int)info.Players;
                        objArray1[5] = module._settings.ServerInfoMaxPlayer;
                        objArray1[6] = (byte)info.MaxPlayers;
                        objArray1[7] = module._settings.ServerInfoPing;
                        objArray1[8] = (long)info.Ping;
                        objArray1[9] = module._settings.ServerInfoConnect;
                        objArray1[10] = info.Address;
                        awaiter = module.ReplyAsync(string.Format("**{0}**\n{1} {2}\n{3} {4}\n{5} {6}\n{7} {8}\n{9} <steam://connect/{10}>", (object[])objArray1), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_000F;
                        }
                        else
                        {
                            this.<> 1__state = num = 1;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__5 > (ref awaiter, ref this);
                        }
                    }
                    else
                    {
                        string[] textArray1 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerInfoAsync", (string)module._settings.NoInfoFoundMiddle, " ", (string)module._settings.NoInfoFoundEnd };
                        awaiter = module.ReplyAsync(string.Concat((string[])textArray1), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_000B;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__5 > (ref awaiter, ref this);
                        }
                    }
                }
                return;
            TR_000B:
                awaiter.GetResult();
                goto TR_0008;
            TR_000F:
                awaiter.GetResult();
            }
            catch (Exception exception)
            {
                this.<> 7__wrap1 = exception;
                this.<> 7__wrap2 = 1;
            }
            goto TR_0008;
        TR_0004:
            this.<> 7__wrap1 = null;
            this.<> 1__state = -2;
            this.<> t__builder.SetResult();
            return;
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
                Exception exception1 = (Exception)this.<> 7__wrap1;
                string[] textArray2 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerInfoAsync", (string)module._settings.NoInfoFoundMiddle, " ", (string)module._settings.NoInfoFoundEnd };
                awaiter = module.ReplyAsync(string.Concat((string[])textArray2), false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0005;
                }
                else
                {
                    this.<> 1__state = num = 2;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerInfoAsync > d__5 > (ref awaiter, ref this);
                }
            }
        }
        catch (Exception exception2)
        {
            this.<> 1__state = -2;
            this.<> t__builder.SetException(exception2);
        }
    }

    [DebuggerHidden]
    private void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        this.<> t__builder.SetStateMachine(stateMachine);
    }
}

[CompilerGenerated]
private struct <ServerListAsync>d__3: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public ServerQueryModule<> 4__this;
private Dictionary<string, Server>.Enumerator<> 7__wrap1;
private KeyValuePair<string, Server> < server > 5__3;
private int <> 7__wrap3;
private TaskAwaiter<IUserMessage> <> u__1;
private TaskAwaiter<> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    ServerQueryModule module = this.<> 4__this;
    try
    {
        int num3 = num;
        try
        {
            if (num > 3)
            {
                this.<> 7__wrap1 = module._settings.ServerQueryDictionary.GetEnumerator();
            }
            try
            {
                TaskAwaiter<IUserMessage> awaiter;
                TaskAwaiter awaiter2;
                switch (num)
                {
                    case 0:
                    case 1:
                        goto TR_0023;

                    case 2:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<IUserMessage>();
                        this.<> 1__state = num = -1;
                        goto TR_000C;

                    case 3:
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0009;

                    default:
                        break;
                }
                goto TR_0026;
            TR_0009:
                awaiter2.GetResult();
                this.< server > 5__3 = new KeyValuePair<string, Server>();
                goto TR_0026;
            TR_000A:
                awaiter2 = Task.Delay(0x3e8).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                    goto TR_0009;
                }
                else
                {
                    this.<> 1__state = num = 3;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ServerQueryModule.< ServerListAsync > d__3 > (ref awaiter2, ref this);
                }
                return;
            TR_000C:
                awaiter.GetResult();
                goto TR_000A;
            TR_000F:
                if (this.<> 7__wrap3 != 1)
                            {
    goto TR_000A;
}
                            else
{
    string[] textArray2 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerListAsync", (string)module._settings.NoInfoFoundMiddle, " ", this.< server > 5__3.Key, " ", (string)module._settings.NoInfoFoundEnd };
    awaiter = module.ReplyAsync(string.Concat((string[])textArray2), false, null, null).GetAwaiter();
    if (awaiter.IsCompleted)
    {
        goto TR_000C;
    }
    else
    {
        this.<> 1__state = num = 2;
        this.<> u__1 = awaiter;
        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerListAsync > d__3 > (ref awaiter, ref this);
    }
}
return;
TR_0023:
try
{
    if (num == 0)
    {
        awaiter = this.<> u__1;
        this.<> u__1 = new TaskAwaiter<IUserMessage>();
        this.<> 1__state = num = -1;
        goto TR_0012;
    }
    else if (num == 1)
    {
        awaiter = this.<> u__1;
        this.<> u__1 = new TaskAwaiter<IUserMessage>();
        this.<> 1__state = num = -1;
        goto TR_0016;
    }
    else
    {
        ServerInfo info1;
        Server local1 = this.< server > 5__3.Value;
        if (local1 != null)
        {
            info1 = local1.GetInfo(null);
        }
        else
        {
            Server local2 = local1;
            info1 = null;
        }
        ServerInfo info = info1;
        if (info != null)
        {
            object[] objArray1 = new object[11];
            objArray1[0] = info.Name;
            objArray1[1] = module._settings.ServerInfoMap;
            objArray1[2] = info.Map;
            objArray1[3] = module._settings.ServerInfoPlayerOnline;
            objArray1[4] = (int)info.Players;
            objArray1[5] = module._settings.ServerInfoMaxPlayer;
            objArray1[6] = (byte)info.MaxPlayers;
            objArray1[7] = module._settings.ServerInfoPing;
            objArray1[8] = (long)info.Ping;
            objArray1[9] = module._settings.ServerInfoConnect;
            objArray1[10] = info.Address;
            awaiter = module.ReplyAsync(string.Format("**{0}**\n{1} {2}\n{3} {4}\n{5} {6}\n{7} {8}\n{9} <steam://connect/{10}>", (object[])objArray1), false, null, null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0016;
            }
            else
            {
                this.<> 1__state = num = 1;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerListAsync > d__3 > (ref awaiter, ref this);
            }
        }
        else
        {
            string[] textArray1 = new string[] { (string)module._settings.NoInfoFoundStart, "ServerListAsync", (string)module._settings.NoInfoFoundMiddle, " ", this.< server > 5__3.Key, " ", (string)module._settings.NoInfoFoundEnd };
            awaiter = module.ReplyAsync(string.Concat((string[])textArray1), false, null, null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0012;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, ServerQueryModule.< ServerListAsync > d__3 > (ref awaiter, ref this);
            }
        }
    }
    return;
TR_0012:
    awaiter.GetResult();
    goto TR_000F;
TR_0016:
    awaiter.GetResult();
}
catch (Exception)
{
    this.<> 7__wrap3 = 1;
}
goto TR_000F;
TR_0026:
while (true)
{
    if (this.<> 7__wrap1.MoveNext())
                                {
        this.< server > 5__3 = this.<> 7__wrap1.get_Current();
        this.<> 7__wrap3 = 0;
    }
                                else
    {
        goto TR_0006;
    }
    break;
}
goto TR_0023;
                        }
                        finally
{
    if (num < 0)
    {
        this.<> 7__wrap1.Dispose();
    }
}
goto TR_0002;
TR_0006:
this.<> 7__wrap1 = new Dictionary<string, Server>.Enumerator();
                    }
                    catch (Exception)
{
}
                }
                catch (Exception exception)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetException(exception);
    return;
}
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

