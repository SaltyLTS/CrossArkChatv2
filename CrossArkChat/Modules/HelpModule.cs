namespace CrossArkChat.Modules
{
    using CrossArkChat;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    [Name("Help")]
    public class HelpModule : ModuleBase<SocketCommandContext>
    {
        private const int MAX_VALUE_LENGTH = 0x400;
        private readonly CommandService _service;
        private readonly IConfigurationRoot _config;
        private readonly GeneralSettings _settings;
        private readonly IServiceProvider _services;

        public HelpModule(CommandService service, IConfigurationRoot config, GeneralSettings settings, IServiceProvider services)
        {
            this._service = service;
            this._config = config;
            this._settings = settings;
            this._services = services;
        }

        [AsyncStateMachine((Type)typeof(< HelpAsync > d__6)), Command("help"), Summary("Provides a list of available commands")]
        public Task HelpAsync()
        {
            < HelpAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << HelpAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< HelpAsync > d__7)), Command("help"), Summary("Searches a list of available commands")]
        public Task HelpAsync(string command)
        {
            < HelpAsync > d__7 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.command = command;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << HelpAsync > d__7 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly HelpModule.<>c<>9 = new HelpModule.<>c();
        public static Func<ParameterInfo, string> <>9__7_0;

            internal string <HelpAsync>b__7_0(ParameterInfo p) =>
                p.Name;
    }

    [CompilerGenerated]
    private struct <HelpAsync>d__6 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public HelpModule<>4__this;
            private HelpModule.<>c__DisplayClass6_0<>8__1;
            private string <prefix>5__2;
            private EmbedBuilder<builder>5__3;
            private IEnumerator<ModuleInfo> <>7__wrap3;
            private ModuleInfo<module>5__5;
            private List<string> <commands>5__6;
            private IEnumerator<CommandInfo> <>7__wrap6;
            private CommandInfo<cmd>5__8;
            private TaskAwaiter<PreconditionResult> <>u__1;
            private TaskAwaiter<IUserMessage> <>u__2;

            private void MoveNext()
    {
        int num = this.<> 1__state;
        HelpModule module = this.<> 4__this;
        try
        {
            TaskAwaiter<IUserMessage> awaiter2;
            if (num != 0)
            {
                if (num == 1)
                {
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0007;
                }
                else
                {
                    this.< prefix > 5__2 = module._config["DiscordSettings:prefix"];
                    EmbedBuilder builder1 = new EmbedBuilder();
                    builder1.set_Color((Color?)new Color(0x72, 0x89, 0xda));
                    builder1.Description = module._settings.CommandList;
                    this.< builder > 5__3 = builder1;
                    this.<> 7__wrap3 = module._service.get_Modules().GetEnumerator();
                }
            }
            try
            {
                if (num == 0)
                {
                    goto TR_0029;
                }
                goto TR_002C;
            TR_001F:
                this.<> 7__wrap6 = null;
                this.< commands > 5__6 = Enumerable.ToList<string>(Enumerable.Distinct<string>((IEnumerable<string>)this.< commands > 5__6));
                this.<> 8__1.commandString = string.Empty;
                List<string>.Enumerator enumerator = this.< commands > 5__6.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        string current = enumerator.Current;
                        if (!string.IsNullOrWhiteSpace(current))
                        {
                            string str2 = current + "\n";
                            if ((this.<> 8__1.commandString.Length + str2.Length) > 0x400)
                            {
                                Action<EmbedFieldBuilder> action2 = this.<> 8__1.<> 9__1;
                                if (this.<> 8__1.<> 9__1 == null)
                                {
                                    Action<EmbedFieldBuilder> local1 = this.<> 8__1.<> 9__1;
                                    action2 = this.<> 8__1.<> 9__1 = new Action<EmbedFieldBuilder>(this.<> 8__1.< HelpAsync > b__1);
                                }
                                this.< builder > 5__3.AddField(action2);
                                this.<> 8__1.moduleName = this.< module > 5__5.Name + " cont.";
                                this.<> 8__1.commandString = string.Empty;
                            }
                            this.<> 8__1.commandString = this.<> 8__1.commandString + str2;
                        }
                    }
                }
                finally
                {
                    if (num < 0)
                    {
                        enumerator.Dispose();
                    }
                }
                if (!string.IsNullOrWhiteSpace(this.<> 8__1.commandString))
                {
                    this.< builder > 5__3.AddField(new Action<EmbedFieldBuilder>(this.<> 8__1.< HelpAsync > b__0));
                }
                this.<> 8__1 = null;
                this.< commands > 5__6 = null;
                this.< module > 5__5 = null;
                goto TR_002C;
            TR_0029:
                try
                {
                    TaskAwaiter<PreconditionResult> awaiter;
                    if (num == 0)
                    {
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter<PreconditionResult>();
                        this.<> 1__state = num = -1;
                    }
                    else
                    {
                        goto TR_0026;
                    }
                TR_0022:
                    if (awaiter.GetResult().IsSuccess)
                    {
                        this.< commands > 5__6.Add(this.< prefix > 5__2 + Enumerable.First<string>((IEnumerable<string>)this.< cmd > 5__8.get_Aliases()));
                        this.< cmd > 5__8 = null;
                    }
                TR_0026:
                    while (true)
                    {
                        if (this.<> 7__wrap6.MoveNext())
                                {
                            this.< cmd > 5__8 = this.<> 7__wrap6.Current;
                            awaiter = this.< cmd > 5__8.CheckPreconditionsAsync(module.Context, module._services).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0022;
                            }
                            else
                            {
                                this.<> 1__state = num = 0;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<PreconditionResult>, HelpModule.< HelpAsync > d__6 > (ref awaiter, ref this);
                            }
                        }
                                else
                        {
                            goto TR_001F;
                        }
                        break;
                    }
                    return;
                }
                finally
                {
                    if ((num < 0) && (this.<> 7__wrap6 != null))
                            {
                        this.<> 7__wrap6.Dispose();
                    }
                }
            TR_002C:
                while (true)
                {
                    if (this.<> 7__wrap3.MoveNext())
                            {
                        this.< module > 5__5 = this.<> 7__wrap3.Current;
                        this.<> 8__1 = new HelpModule.<> c__DisplayClass6_0();
                        this.<> 8__1.moduleName = this.< module > 5__5.Name;
                        this.< commands > 5__6 = new List<string>(this.< module > 5__5.get_Commands().Count);
                        this.<> 7__wrap6 = this.< module > 5__5.get_Commands().GetEnumerator();
                    }
                            else
                    {
                        goto TR_0008;
                    }
                    break;
                }
                goto TR_0029;
            }
            finally
            {
                if ((num < 0) && (this.<> 7__wrap3 != null))
                        {
                    this.<> 7__wrap3.Dispose();
                }
            }
            return;
        TR_0007:
            awaiter2.GetResult();
            this.<> 1__state = -2;
            this.< prefix > 5__2 = null;
            this.< builder > 5__3 = null;
            this.<> t__builder.SetResult();
            return;
        TR_0008:
            this.<> 7__wrap3 = null;
            awaiter2 = module.ReplyAsync(string.Empty, false, this.< builder > 5__3.Build(), null).GetAwaiter();
            if (awaiter2.IsCompleted)
            {
                goto TR_0007;
            }
            else
            {
                this.<> 1__state = num = 1;
                this.<> u__2 = awaiter2;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, HelpModule.< HelpAsync > d__6 > (ref awaiter2, ref this);
            }
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.< prefix > 5__2 = null;
            this.< builder > 5__3 = null;
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
private struct <HelpAsync>d__7: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public HelpModule<> 4__this;
public string command;
private HelpModule.<> c__DisplayClass7_0 <> 8__1;
private string < prefix > 5__2;
private EmbedBuilder<builder> 5__3;
private TaskAwaiter<IUserMessage> <> u__1;
private IEnumerator<CommandMatch> <> 7__wrap3;
private TaskAwaiter<PreconditionResult> <> u__2;

private void MoveNext()
{
    int num = this.<> 1__state;
    HelpModule module = this.<> 4__this;
    try
    {
        TaskAwaiter<IUserMessage> awaiter;
        switch (num)
        {
            case 0:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_0004;

            case 1:
                goto TR_001D;

            case 2:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_000B;

            default:
                {
                    SearchResult result = module._service.Search(module.Context, this.command);
                    if (result.IsSuccess)
                    {
                        this.< prefix > 5__2 = module._config["DiscordSettings:prefix"];
                        EmbedBuilder builder1 = new EmbedBuilder();
                        builder1.set_Color((Color?)new Color(0x72, 0x89, 0xda));
                        builder1.Description = module._settings.SimularCommand + " **" + this.command + "**";
                        this.< builder > 5__3 = builder1;
                        this.<> 7__wrap3 = result.get_Commands().GetEnumerator();
                        goto TR_001D;
                    }
                    else
                    {
                        string[] textArray1 = new string[] { (string)module._settings.NoCommandFoundStart, " **", (string)this.command, "**", (string)module._settings.NoCommandFoundEnd };
                        awaiter = module.ReplyAsync(string.Concat((string[])textArray1), false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0004;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, HelpModule.< HelpAsync > d__7 > (ref awaiter, ref this);
                        }
                    }
                    break;
                }
        }
        return;
    TR_0004:
        awaiter.GetResult();
        goto TR_0003;
    TR_000B:
        awaiter.GetResult();
        goto TR_0003;
    TR_000C:
        this.<> 7__wrap3 = null;
        awaiter = module.ReplyAsync(string.Empty, false, this.< builder > 5__3.Build(), null).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_000B;
        }
        else
        {
            this.<> 1__state = num = 2;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, HelpModule.< HelpAsync > d__7 > (ref awaiter, ref this);
        }
        return;
    TR_001D:
        try
        {
            TaskAwaiter<PreconditionResult> awaiter2;
            if (num == 1)
            {
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter<PreconditionResult>();
                this.<> 1__state = num = -1;
            }
            else
            {
                goto TR_001A;
            }
        TR_0016:
            if (awaiter2.GetResult().IsSuccess)
            {
                this.<> 8__1.usage = this.< prefix > 5__2 + Enumerable.First<string>((IEnumerable<string>)this.<> 8__1.cmd.get_Aliases());
                if (this.<> 8__1.cmd.get_Parameters().Count > 0)
                {
                    Func<ParameterInfo, string> func1 = HelpModule.<> c.<> 9__7_0;
                    if (HelpModule.<> c.<> 9__7_0 == null)
                    {
                        Func<ParameterInfo, string> local1 = HelpModule.<> c.<> 9__7_0;
                        func1 = HelpModule.<> c.<> 9__7_0 = new Func<ParameterInfo, string>(this.< HelpAsync > b__7_0);
                    }
                    this.<> 8__1.usage = this.<> 8__1.usage + " " + string.Join(" ", Enumerable.Select<ParameterInfo, string>((IEnumerable<ParameterInfo>)this.<> 8__1.cmd.get_Parameters(), func1));
                }
                this.<> 8__1.usage = this.<> 8__1.usage + "\n";
                this.< builder > 5__3.AddField(new Action<EmbedFieldBuilder>(this.<> 8__1.< HelpAsync > b__1));
                this.<> 8__1 = null;
            }
        TR_001A:
            while (true)
            {
                if (!this.<> 7__wrap3.MoveNext())
                            {
    break;
}
CommandMatch current = this.<> 7__wrap3.Current;
this.<> 8__1 = new HelpModule.<> c__DisplayClass7_0();
this.<> 8__1.<> 4__this = module;
this.<> 8__1.cmd = current.Command;
awaiter2 = this.<> 8__1.cmd.CheckPreconditionsAsync(module.Context, module._services).GetAwaiter();
if (awaiter2.IsCompleted)
{
    goto TR_0016;
}
else
{
    this.<> 1__state = num = 1;
    this.<> u__2 = awaiter2;
    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<PreconditionResult>, HelpModule.< HelpAsync > d__7 > (ref awaiter2, ref this);
}
return;
                        }
                        goto TR_000C;
                    }
                    finally
{
    if ((num < 0) && (this.<> 7__wrap3 != null))
                        {
        this.<> 7__wrap3.Dispose();
    }
}
                }
                catch (Exception exception)
{
    this.<> 1__state = -2;
    this.< prefix > 5__2 = null;
    this.< builder > 5__3 = null;
    this.<> t__builder.SetException(exception);
}
return;
TR_0003:
this.<> 1__state = -2;
this.< prefix > 5__2 = null;
this.< builder > 5__3 = null;
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

