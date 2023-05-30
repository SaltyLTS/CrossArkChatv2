namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class DiscordLogServerityUtils
    {
        [AsyncStateMachine((Type)typeof(< GetDiscordLogSeverityAsync > d__0))]
        public static Task<LogSeverity> GetDiscordLogSeverityAsync(IConfigurationRoot config)
        {
            < GetDiscordLogSeverityAsync > d__0 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder<LogSeverity>.Create();
            d__.config = config;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GetDiscordLogSeverityAsync > d__0 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <GetDiscordLogSeverityAsync>d__0 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<LogSeverity> <>t__builder;
            public IConfigurationRoot config;
        private string <logSeverity>5__2;
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
                    this.< logSeverity > 5__2 = this.config["ApplicationSettings:DiscordLogSeverity"];
                    awaiter = Task.Delay(1).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0004;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordLogServerityUtils.< GetDiscordLogSeverityAsync > d__0 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0004:
                awaiter.GetResult();
                string str = this.< logSeverity > 5__2.ToLower();
                LogSeverity result = (str == "critical") ? LogSeverity.Critical : ((str == "debug") ? LogSeverity.Debug : ((str == "error") ? LogSeverity.Error : ((str == "info") ? LogSeverity.Info : ((str == "verbose") ? LogSeverity.Verbose : ((str == "warning") ? LogSeverity.Warning : LogSeverity.Info)))));
                this.<> 1__state = -2;
                this.< logSeverity > 5__2 = null;
                this.<> t__builder.SetResult(result);
            }
            catch (Exception exception)
            {
                this.<> 1__state = -2;
                this.< logSeverity > 5__2 = null;
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

