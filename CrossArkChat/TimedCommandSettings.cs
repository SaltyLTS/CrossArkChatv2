namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class TimedCommandSettings
    {
        private readonly IConfigurationRoot _config;

        public TimedCommandSettings(IConfigurationRoot config)
        {
            this._config = config;
        }

        [AsyncStateMachine((Type)typeof(< LoadAsync > d__6))]
        public Task LoadAsync()
        {
            < LoadAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << LoadAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        public List<TimedCommand> TimedCommands { get; set; }

        [CompilerGenerated]
        private struct <LoadAsync>d__6 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public TimedCommandSettings<>4__this;
            private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            TimedCommandSettings settings = this.<> 4__this;
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
                    IEnumerator<IConfigurationSection> enumerator = settings._config.GetSection("TimedCommands").GetChildren().GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            IConfigurationSection current = enumerator.Current;
                            TimedCommand command = new TimedCommand
                            {
                                Name = current.GetValue<string>("Name"),
                                Servers = current.GetSection("Servers").Get<List<string>>(),
                                Active = current.GetValue<bool>("Active"),
                                Frequency = current.GetValue<string>("Frequency"),
                                Timespan = current.GetValue<int>("Timespan"),
                                TimeOffset = current.GetValue<TimeSpan>("TimeOffset"),
                                Commands = new List<TimedCommandItem>()
                            };
                            IEnumerator<IConfigurationSection> enumerator2 = current.GetSection("Commands").GetChildren().GetEnumerator();
                            try
                            {
                                while (enumerator2.MoveNext())
                                {
                                    IConfigurationSection configuration = enumerator2.Current;
                                    TimedCommandItem item = new TimedCommandItem
                                    {
                                        Command = configuration.GetValue<string>("Command"),
                                        Type = configuration.GetValue<string>("Type")
                                    };
                                    command.Commands.Add(item);
                                }
                            }
                            finally
                            {
                                if ((num < 0) && (enumerator2 != null))
                                {
                                    enumerator2.Dispose();
                                }
                            }
                            command.UpdateNextRunTime();
                            settings.TimedCommands.Add(command);
                        }
                    }
                    finally
                    {
                        if ((num < 0) && (enumerator != null))
                        {
                            enumerator.Dispose();
                        }
                    }
                    awaiter = Task.Delay(0x3e8).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0007;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, TimedCommandSettings.< LoadAsync > d__6 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0007:
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

