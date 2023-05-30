namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class Startup
    {
        private static HttpClient _httpClient = new HttpClient();

        public Startup(string[] args)
        {
            string basePath = Path.Combine(AppContext.get_BaseDirectory(), "Config");
            this._config = new ConfigurationBuilder().SetBasePath(basePath).AddJsonFile("_configuration.json").AddJsonFile("_discordroles.json").AddJsonFile("_timedcommands.json").AddJsonFile("_translation.json").AddJsonFile("_wordfilter.json").Build();
        }

        [AsyncStateMachine((Type)typeof(< ConfigureServicesAsync > d__8))]
        public Task<IServiceCollection> ConfigureServicesAsync(IConfigurationRoot config, IServiceCollection services)
        {
            < ConfigureServicesAsync > d__8 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder<IServiceCollection>.Create();
            d__.<> 4__this = this;
            d__.config = config;
            d__.services = services;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ConfigureServicesAsync > d__8 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RunAsync > d__7))]
        public Task RunAsync()
        {
            < RunAsync > d__7 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RunAsync > d__7 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RunAsync > d__6))]
        public static Task RunAsync(string[] args)
        {
            < RunAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.args = args;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RunAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private IConfigurationRoot _config { get; set; }

        [CompilerGenerated]
        private struct <ConfigureServicesAsync>d__8 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<IServiceCollection> <>t__builder;
            public IConfigurationRoot config;
        public IServiceCollection services;
        public Startup<>4__this;
            private TaskAwaiter<LogSeverity> <>u__1;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            Startup startup = this.<> 4__this;
            try
            {
                LogSeverity severity;
                TaskAwaiter<LogSeverity> awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<LogSeverity>();
                    this.<> 1__state = num = -1;
                    goto TR_0004;
                }
                else
                {
                    awaiter = DiscordLogServerityUtils.GetDiscordLogSeverityAsync(this.config).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0004;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<LogSeverity>, Startup.< ConfigureServicesAsync > d__8 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0004:
                severity = awaiter.GetResult();
                DiscordSocketConfig config = new DiscordSocketConfig();
                config.LogLevel = severity;
                config.MessageCacheSize = 0x3e8;
                CommandServiceConfig config2 = new CommandServiceConfig();
                config2.DefaultRunMode = RunMode.Async;
                config2.CaseSensitiveCommands = false;
                config2.LogLevel = severity;
                this.services.AddSingleton<DiscordSocketClient>(new DiscordSocketClient(config)).AddSingleton<CommandService>(new CommandService(config2)).AddSingleton<CommandHandler>().AddSingleton<CrossArkChatService>().AddSingleton<CrossArkChatUpdaterService>().AddSingleton<CrossDiscordChatHandler>().AddSingleton<DiscordRoleSettings>().AddSingleton<DiscordStartupService>().AddSingleton<GeneralSettings>().AddSingleton<InteractiveService>().AddSingleton<ListPlayersService>().AddSingleton<LoggingService>().AddSingleton<PlayerCountService>().AddSingleton<Random>().AddSingleton<SendTimeCommandService>().AddSingleton<TimedCommandService>().AddSingleton<TimedCommandSettings>().AddSingleton<HttpClient>(Startup._httpClient).AddSingleton<IConfigurationRoot>(startup._config);
                IServiceCollection result = this.services;
                this.<> 1__state = -2;
                this.<> t__builder.SetResult(result);
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
    private struct <RunAsync>d__6 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public string[] args;
    private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
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
                awaiter = new Startup(this.args).RunAsync().GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0004;
                }
                else
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__6 > (ref awaiter, ref this);
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
private struct <RunAsync>d__7: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public Startup<> 4__this;
private ServiceCollection<services> 5__2;
private ServiceProvider<provider> 5__3;
private bool < useDiscord > 5__4;
private TaskAwaiter<Version> <> u__1;
private TaskAwaiter<IServiceCollection> <> u__2;
private TaskAwaiter<> u__3;

private void MoveNext()
{
    int num = this.<> 1__state;
    Startup startup = this.<> 4__this;
    try
    {
        TaskAwaiter<Version> awaiter;
        TaskAwaiter<IServiceCollection> awaiter2;
        TaskAwaiter awaiter3;
        switch (num)
        {
            case 0:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<Version>();
                this.<> 1__state = num = -1;
                break;

            case 1:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter<IServiceCollection>();
                this.<> 1__state = num = -1;
                goto TR_0025;

            case 2:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0023;

            case 3:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_001F;

            case 4:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_001D;

            case 5:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_001B;

            case 6:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0019;

            case 7:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0018;

            case 8:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0014;

            case 9:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0012;

            case 10:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_0010;

            case 11:
                awaiter3 = this.<> u__3;
                this.<> u__3 = new TaskAwaiter();
                this.<> 1__state = num = -1;
                goto TR_000F;

            default:
                {
                    string fileVersion = AssemblyUtils.GetFileVersion();
                    string description = AssemblyUtils.GetDescription();
                    string str3 = startup._config["DiscordSettings:DiscordBotSettings:CommandPrefix"];
                    if (string.IsNullOrWhiteSpace(str3))
                    {
                        str3 = "d!";
                    }
                    Console.OutputEncoding = Encoding.get_UTF8();
                    string title = AssemblyUtils.GetTitle();
                    Console.Title = title + " - " + fileVersion;
                    Console.WriteLine(title);
                    Console.WriteLine("Version " + fileVersion);
                    if (!string.IsNullOrWhiteSpace(description))
                    {
                        Console.WriteLine((string)(description ?? ""));
                    }
                    Console.WriteLine("Use the command " + str3 + "serverblend for more info.");
                    Console.WriteLine();
                    awaiter = UpdateCheckerUtils.CheckForUpdatesAsync(Startup._httpClient, startup._config).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        break;
                    }
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<Version>, Startup.< RunAsync > d__7 > (ref awaiter, ref this);
                    return;
                }
        }
        Version result = awaiter.GetResult();
        if (result != null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"*** New version is available - {result} ***");
            Console.ResetColor();
            Console.WriteLine();
        }
        this.< services > 5__2 = new ServiceCollection();
        awaiter2 = startup.ConfigureServicesAsync(startup._config, this.< services > 5__2).GetAwaiter();
        if (!awaiter2.IsCompleted)
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IServiceCollection>, Startup.< RunAsync > d__7 > (ref awaiter2, ref this);
            return;
        }
        goto TR_0025;
    TR_000F:
        awaiter3.GetResult();
        this.<> 1__state = -2;
        this.< services > 5__2 = null;
        this.< provider > 5__3 = null;
        this.<> t__builder.SetResult();
        return;
    TR_0010:
        awaiter3.GetResult();
        awaiter3 = Task.Delay(-1).GetAwaiter();
        if (awaiter3.IsCompleted)
        {
            goto TR_000F;
        }
        else
        {
            this.<> 1__state = num = 11;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
        }
        return;
    TR_0012:
        awaiter3.GetResult();
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<CrossArkChatService>((IServiceProvider)this.< provider > 5__3).CrossArkChatAsync(CrossArkChatModule.cts.get_Token()).GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 10;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_0010;
    TR_0014:
        awaiter3.GetResult();
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<TimedCommandService>((IServiceProvider)this.< provider > 5__3).StartAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 9;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_0012;
    TR_0016:
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<TimedCommandSettings>((IServiceProvider)this.< provider > 5__3).LoadAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 8;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_0014;
    TR_0018:
        awaiter3.GetResult();
        goto TR_0016;
    TR_0019:
        awaiter3.GetResult();
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<CrossArkChatUpdaterService>((IServiceProvider)this.< provider > 5__3).StartCrossArkChatUpdaterAsync().GetAwaiter();
        if (awaiter3.IsCompleted)
        {
            goto TR_0018;
        }
        else
        {
            this.<> 1__state = num = 7;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
        }
        return;
    TR_001B:
        awaiter3.GetResult();
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<PlayerCountService>((IServiceProvider)this.< provider > 5__3).StartPlayCountAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 6;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_0019;
    TR_001D:
        awaiter3.GetResult();
        ServiceProviderServiceExtensions.GetRequiredService<CrossDiscordChatHandler>((IServiceProvider)this.< provider > 5__3);
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<ListPlayersService>((IServiceProvider)this.< provider > 5__3).StartListPlayersAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 5;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_001B;
    TR_001F:
        awaiter3.GetResult();
        ServiceProviderServiceExtensions.GetRequiredService<CommandHandler>((IServiceProvider)this.< provider > 5__3);
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<DiscordRoleSettings>((IServiceProvider)this.< provider > 5__3).LoadAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 4;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
            return;
        }
        goto TR_001D;
    TR_0023:
        awaiter3.GetResult();
        if (!this.< useDiscord > 5__4)
        {
            goto TR_0016;
        }
        else
        {
            awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<DiscordStartupService>((IServiceProvider)this.< provider > 5__3).StartAsync().GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
                this.<> 1__state = num = 3;
                this.<> u__3 = awaiter3;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
                return;
            }
        }
        goto TR_001F;
    TR_0025:
        awaiter2.GetResult();
        this.< provider > 5__3 = this.< services > 5__2.BuildServiceProvider();
        this.< useDiscord > 5__4 = bool.Parse(startup._config["ApplicationSettings:UseDiscord"]);
        ServiceProviderServiceExtensions.GetRequiredService<LoggingService>((IServiceProvider)this.< provider > 5__3);
        awaiter3 = ServiceProviderServiceExtensions.GetRequiredService<GeneralSettings>((IServiceProvider)this.< provider > 5__3).LoadAsync().GetAwaiter();
        if (!awaiter3.IsCompleted)
        {
            this.<> 1__state = num = 2;
            this.<> u__3 = awaiter3;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, Startup.< RunAsync > d__7 > (ref awaiter3, ref this);
        }
        else
        {
            goto TR_0023;
        }
    }
    catch (Exception exception)
    {
        this.<> 1__state = -2;
        this.< services > 5__2 = null;
        this.< provider > 5__3 = null;
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

