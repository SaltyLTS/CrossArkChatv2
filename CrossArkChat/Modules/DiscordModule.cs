namespace CrossArkChat.Modules
{
    using CrossArkChat;
    using CrossArkChat.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    [Name("Discord")]
    public class DiscordModule : ModuleBase<SocketCommandContext>
    {
        private const int DELETE_MESSAGE_MAX = 100;
        private readonly CrossArkChatService _service;
        private readonly GeneralSettings _settings;

        public DiscordModule(GeneralSettings settings, CrossArkChatService service)
        {
            this._settings = settings;
            this._service = service;
        }

        [AsyncStateMachine((Type)typeof(< PurgeMessagesAsync > d__4)), Command("purge", RunMode = RunMode.Async), RequireRole(SpecialRole.PurgeMessage), Summary("Deletes a given ammount of messags."), Remarks("purge number")]
        public Task PurgeMessagesAsync(int amount)
        {
            < PurgeMessagesAsync > d__4 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.amount = amount;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << PurgeMessagesAsync > d__4 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerBlend > d__5)), Command("serverblend", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerBlend), Summary("Information about the bot's official host ServerBlend."), Remarks("serverblend")]
        public Task ServerBlend()
        {
            < ServerBlend > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerBlend > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly DiscordModule.<>c<>9 = new DiscordModule.<>c();
        public static Action<EmbedAuthorBuilder> <>9__5_0;

            internal void <ServerBlend>b__5_0(EmbedAuthorBuilder author)
        {
            author.WithName("Bot's Official Host ServerBlend").WithUrl("https://serverblend.com/my/aff.php?aff=175");
        }
    }

    [CompilerGenerated]
    private struct <PurgeMessagesAsync>d__4 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public int amount;
    public DiscordModule<>4__this;
            private IUserMessage<message>5__2;
            private TaskAwaiter<IUserMessage> <>u__1;
            private TaskAwaiter<IEnumerable<IMessage>> <>u__2;
            private TaskAwaiter<> u__3;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        DiscordModule module = this.<> 4__this;
        try
        {
            IEnumerable<IMessage> enumerable;
            TaskAwaiter<IUserMessage> awaiter;
            TaskAwaiter<IEnumerable<IMessage>> awaiter2;
            TaskAwaiter awaiter3;
            IUserMessage message;
            switch (num)
            {
                case 0:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0004;

                case 1:
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<IEnumerable<IMessage>>();
                    this.<> 1__state = num = -1;
                    goto TR_001C;

                case 2:
                    awaiter3 = this.<> u__3;
                    this.<> u__3 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                    goto TR_001A;

                case 3:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0013;

                case 4:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0017;

                case 5:
                    awaiter3 = this.<> u__3;
                    this.<> u__3 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                    goto TR_000F;

                case 6:
                    awaiter3 = this.<> u__3;
                    this.<> u__3 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                    goto TR_000C;

                default:
                    if (this.amount <= 0)
                    {
                        break;
                    }
                    if (this.amount <= 100)
                    {
                        awaiter2 = AsyncEnumerableExtensions.FlattenAsync<IMessage>((IAsyncEnumerable<IEnumerable<IMessage>>)module.Context.Channel.GetMessagesAsync(this.amount + 1, CacheMode.AllowDownload, null)).GetAwaiter();
                        if (!awaiter2.IsCompleted)
                        {
                            this.<> 1__state = num = 1;
                            this.<> u__2 = awaiter2;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IEnumerable<IMessage>>, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter2, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = module.ReplyAsync($"{module._settings.DeleteMaxStart} {(int)100} {module._settings.DeleteMaxEnd}", false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0004;
                        }
                        else
                        {
                            this.<> 1__state = num = 0;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter, ref this);
                        }
                        return;
                    }
                    goto TR_001C;
            }
            goto TR_0002;
        TR_0004:
            awaiter.GetResult();
            goto TR_0002;
        TR_000C:
            awaiter3.GetResult();
            goto TR_0002;
        TR_000F:
            awaiter3.GetResult();
            if (this.< message > 5__2 == null)
            {
                goto TR_0002;
            }
            else
            {
                awaiter3 = this.< message > 5__2.DeleteAsync(null).GetAwaiter();
                if (awaiter3.IsCompleted)
                {
                    goto TR_000C;
                }
                else
                {
                    this.<> 1__state = num = 6;
                    this.<> u__3 = awaiter3;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter3, ref this);
                }
            }
            return;
        TR_0011:
            awaiter3 = Task.Delay(0xbb8).GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
                this.<> 1__state = num = 5;
                this.<> u__3 = awaiter3;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter3, ref this);
                return;
            }
            goto TR_000F;
        TR_0013:
            message = awaiter.GetResult();
            this.< message > 5__2 = message;
            goto TR_0011;
        TR_0017:
            message = awaiter.GetResult();
            this.< message > 5__2 = message;
            goto TR_0011;
        TR_001A:
            awaiter3.GetResult();
            this.< message > 5__2 = null;
            if (this.amount != 1)
            {
                awaiter = module.ReplyAsync($"{(int)this.amount} {module._settings.DeletedMessages}", false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0017;
                }
                else
                {
                    this.<> 1__state = num = 4;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter, ref this);
                }
            }
            else
            {
                awaiter = module.ReplyAsync(module._settings.DeletedOne, false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0013;
                }
                else
                {
                    this.<> 1__state = num = 3;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter, ref this);
                }
            }
            return;
        TR_001C:
            enumerable = awaiter2.GetResult();
            awaiter3 = ((ITextChannel)module.Context.Channel).DeleteMessagesAsync(enumerable, null).GetAwaiter();
            if (!awaiter3.IsCompleted)
            {
                this.<> 1__state = num = 2;
                this.<> u__3 = awaiter3;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordModule.< PurgeMessagesAsync > d__4 > (ref awaiter3, ref this);
                return;
            }
            goto TR_001A;
        }
        catch (Exception exception)
        {
            this.<> 1__state = -2;
            this.< message > 5__2 = null;
            this.<> t__builder.SetException(exception);
            return;
        }
    TR_0002:
        this.<> 1__state = -2;
        this.< message > 5__2 = null;
        this.<> t__builder.SetResult();
    }

    [DebuggerHidden]
    private void SetStateMachine(IAsyncStateMachine stateMachine)
    {
        this.<> t__builder.SetStateMachine(stateMachine);
    }
}

[CompilerGenerated]
private struct <ServerBlend>d__5: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public DiscordModule<> 4__this;
private TaskAwaiter<IUserMessage> <> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    DiscordModule module = this.<> 4__this;
    try
    {
        TaskAwaiter<IUserMessage> awaiter;
        if (num == 0)
        {
            awaiter = this.<> u__1;
            this.<> u__1 = new TaskAwaiter<IUserMessage>();
            this.<> 1__state = num = -1;
            goto TR_0004;
        }
        else
        {
            Action<EmbedAuthorBuilder> action1 = DiscordModule.<> c.<> 9__5_0;
            if (DiscordModule.<> c.<> 9__5_0 == null)
            {
                Action<EmbedAuthorBuilder> local1 = DiscordModule.<> c.<> 9__5_0;
                action1 = DiscordModule.<> c.<> 9__5_0 = new Action<EmbedAuthorBuilder>(this.< ServerBlend > b__5_0);
            }
            EmbedBuilder builder = new EmbedBuilder().WithDescription("Be sure to check out the bot's official host [ServerBlend.com](https://serverblend.com/my/aff.php?aff=175)").WithColor(new Color(0xff42)).WithImageUrl("https://raw.githubusercontent.com/spikeydragoon/Cross-Ark-Chat/master/darkgrey_retina_no_slogan200.png").WithAuthor(action1).AddField("Affiliate Disclosure:", "By using this link CrossArkChat will receive a small commission at no additional cost to you, if you sign up for the service.", false);
            awaiter = module.ReplyAsync(string.Empty, false, builder.Build(), null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, DiscordModule.< ServerBlend > d__5 > (ref awaiter, ref this);
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
    }
}

