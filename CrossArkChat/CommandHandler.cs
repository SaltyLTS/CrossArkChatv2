namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class CommandHandler
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _commands;
        private readonly IConfigurationRoot _config;
        private readonly IServiceProvider _services;

        public CommandHandler(DiscordSocketClient discord, CommandService commands, IConfigurationRoot config, IServiceProvider services)
        {
            this._discord = discord;
            this._commands = commands;
            this._config = config;
            this._services = services;
            this._discord.add_MessageReceived(new Func<SocketMessage, Task>(this.OnMessageReceivedAsync));
        }

        [AsyncStateMachine((Type)typeof(< OnMessageReceivedAsync > d__5))]
        private Task OnMessageReceivedAsync(SocketMessage message)
        {
            < OnMessageReceivedAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << OnMessageReceivedAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <OnMessageReceivedAsync>d__5 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public SocketMessage message;
        public CommandHandler<>4__this;
            private SocketCommandContext<context>5__2;
            private TaskAwaiter<IResult> <>u__1;
            private TaskAwaiter<RestUserMessage> <>u__2;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            CommandHandler handler = this.<> 4__this;
            try
            {
                TaskAwaiter<IResult> awaiter;
                TaskAwaiter<RestUserMessage> awaiter2;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IResult>();
                    this.<> 1__state = num = -1;
                }
                else if (num == 1)
                {
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<RestUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0005;
                }
                else
                {
                    SocketUserMessage msg = this.message as SocketUserMessage;
                    if (msg != null)
                    {
                        if (!bool.Parse(handler._config["DiscordSettings:DiscordBotSettings:IgnoreOtherBots"]) || !msg.Author.IsBot)
                        {
                            if (msg.Author.Username != handler._discord.CurrentUser.Username)
                            {
                                this.< context > 5__2 = new SocketCommandContext(handler._discord, msg);
                                int argPos = 0;
                                if (MessageExtensions.HasStringPrefix(msg, handler._config["DiscordSettings:DiscordBotSettings:CommandPrefix"], ref argPos, (StringComparison)StringComparison.Ordinal) || msg.HasMentionPrefix(handler._discord.CurrentUser, ref argPos))
                                {
                                    awaiter = handler._commands.ExecuteAsync(this.< context > 5__2, argPos, handler._services, MultiMatchHandling.Exception).GetAwaiter();
                                    if (!awaiter.IsCompleted)
                                    {
                                        this.<> 1__state = num = 0;
                                        this.<> u__1 = awaiter;
                                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IResult>, CommandHandler.< OnMessageReceivedAsync > d__5 > (ref awaiter, ref this);
                                        return;
                                    }
                                }
                                else
                                {
                                    goto TR_0002;
                                }
                            }
                            else
                            {
                                goto TR_0002;
                            }
                        }
                        else
                        {
                            goto TR_0002;
                        }
                    }
                    else
                    {
                        goto TR_0002;
                    }
                }
                IResult result = awaiter.GetResult();
                if (result.IsSuccess)
                {
                    goto TR_0002;
                }
                else
                {
                    awaiter2 = this.< context > 5__2.Channel.SendMessageAsync(result.ToString(), false, null, null).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto TR_0005;
                    }
                    else
                    {
                        this.<> 1__state = num = 1;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<RestUserMessage>, CommandHandler.< OnMessageReceivedAsync > d__5 > (ref awaiter2, ref this);
                    }
                }
                return;
            TR_0005:
                awaiter2.GetResult();
            }
            catch (Exception exception)
            {
                this.<> 1__state = -2;
                this.< context > 5__2 = null;
                this.<> t__builder.SetException(exception);
                return;
            }
        TR_0002:
            this.<> 1__state = -2;
            this.< context > 5__2 = null;
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

