namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class DiscordStartupService
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _commands;
        private readonly LoggingService _log;
        private readonly IConfigurationRoot _config;
        private readonly IServiceProvider _services;

        public DiscordStartupService(DiscordSocketClient discord, CommandService commands, LoggingService log, IConfigurationRoot config, IServiceProvider services)
        {
            this._config = config;
            this._discord = discord;
            this._commands = commands;
            this._log = log;
            this._services = services;
        }

        [AsyncStateMachine((Type)typeof(< StartAsync > d__6))]
        public Task StartAsync()
        {
            < StartAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << StartAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <StartAsync>d__6 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public DiscordStartupService<>4__this;
            private string <discordToken>5__2;
            private TaskAwaiter<> u__1;
        private object <>7__wrap2;
            private int <>7__wrap3;
            private HttpException<ex>5__5;
            private TaskAwaiter<IEnumerable<ModuleInfo>> <>u__2;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            DiscordStartupService service = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                TaskAwaiter<IEnumerable<ModuleInfo>> awaiter2;
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
                        goto TR_0023;

                    case 2:
                        goto TR_001F;

                    case 3:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0013;

                    case 4:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0011;

                    case 5:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0010;

                    case 6:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_000C;

                    case 7:
                        awaiter2 = this.<> u__2;
                        this.<> u__2 = new TaskAwaiter<IEnumerable<ModuleInfo>>();
                        this.<> 1__state = num = -1;
                        goto TR_000A;

                    case 8:
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_0009;

                    default:
                        this.< discordToken > 5__2 = service._config["DiscordSettings:DiscordBotSettings:DiscordBotToken"];
                        if (string.IsNullOrWhiteSpace(this.< discordToken > 5__2) || (this.< discordToken > 5__2 == "BotToken"))
                        {
                            awaiter = service._log.CrossArkConfigErrorLogging("Please close CrossArkChat and enter your bot's token into the `_configuration.json` file found in the CrossArkChat root directory in the Config folder. Otherwise set UseDiscord to false.", true).GetAwaiter();
                            if (!awaiter.IsCompleted)
                            {
                                this.<> 1__state = num = 0;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                                return;
                            }
                        }
                        else
                        {
                            goto TR_0020;
                        }
                        break;
                }
                awaiter.GetResult();
                awaiter = Task.Delay(-1).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0023;
                }
                else
                {
                    this.<> 1__state = num = 1;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                }
                return;
            TR_0009:
                awaiter.GetResult();
                this.<> 1__state = -2;
                this.< discordToken > 5__2 = null;
                this.<> t__builder.SetResult();
                return;
            TR_000A:
                awaiter2.GetResult();
                awaiter = service._discord.SetGameAsync("ARK: Survival Evolved | Bot by Salty.", null, ActivityType.Playing).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0009;
                }
                else
                {
                    this.<> 1__state = num = 8;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                }
                return;
            TR_000C:
                awaiter.GetResult();
                awaiter2 = service._commands.AddModulesAsync(Assembly.GetEntryAssembly(), service._services).GetAwaiter();
                if (!awaiter2.IsCompleted)
                {
                    this.<> 1__state = num = 7;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IEnumerable<ModuleInfo>>, DiscordStartupService.< StartAsync > d__6 > (ref awaiter2, ref this);
                    return;
                }
                goto TR_000A;
            TR_000E:
                this.<> 7__wrap2 = null;
                awaiter = service._discord.StartAsync().GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 6;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                    return;
                }
                goto TR_000C;
            TR_0010:
                awaiter.GetResult();
                this.< ex > 5__5 = null;
                goto TR_000E;
            TR_0011:
                awaiter.GetResult();
                awaiter = Task.Delay(-1).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0010;
                }
                else
                {
                    this.<> 1__state = num = 5;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                }
                return;
            TR_0013:
                awaiter.GetResult();
                awaiter = service._log.CrossArkConfigErrorLogging(this.< ex > 5__5.ToString(), false).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    this.<> 1__state = num = 4;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                    return;
                }
                goto TR_0011;
            TR_0017:
                if (this.<> 7__wrap3 != 1)
                    {
                    goto TR_000E;
                }
                    else
                {
                    this.< ex > 5__5 = (HttpException)this.<> 7__wrap2;
                    awaiter = service._log.CrossArkConfigErrorLogging("Please close CrossArkChat and check to make sure your DiscordBotToken is correct in the '_configuration.json' file found in the CrossArkChats root directory in the Config folder.", true).GetAwaiter();
                    if (!awaiter.IsCompleted)
                    {
                        this.<> 1__state = num = 3;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                        return;
                    }
                }
                goto TR_0013;
            TR_001F:
                try
                {
                    if (num == 2)
                    {
                        awaiter = this.<> u__1;
                        this.<> u__1 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                        goto TR_001A;
                    }
                    else
                    {
                        awaiter = service._discord.LoginAsync(TokenType.Bot, this.< discordToken > 5__2, true).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_001A;
                        }
                        else
                        {
                            this.<> 1__state = num = 2;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordStartupService.< StartAsync > d__6 > (ref awaiter, ref this);
                        }
                    }
                    return;
                TR_001A:
                    awaiter.GetResult();
                }
                catch (HttpException exception)
                {
                    this.<> 7__wrap2 = exception;
                    this.<> 7__wrap3 = 1;
                }
                goto TR_0017;
            TR_0020:
                this.<> 7__wrap3 = 0;
                goto TR_001F;
            TR_0023:
                awaiter.GetResult();
                goto TR_0020;
            }
            catch (Exception exception2)
            {
                this.<> 1__state = -2;
                this.< discordToken > 5__2 = null;
                this.<> t__builder.SetException(exception2);
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

