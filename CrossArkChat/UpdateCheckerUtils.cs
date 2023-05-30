namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public static class UpdateCheckerUtils
    {
        [AsyncStateMachine((Type)typeof(< CheckForUpdatesAsync > d__0))]
        public static Task<Version> CheckForUpdatesAsync(HttpClient httpClient, IConfigurationRoot config)
        {
            < CheckForUpdatesAsync > d__0 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder<Version>.Create();
            d__.httpClient = httpClient;
            d__.config = config;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CheckForUpdatesAsync > d__0 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <CheckForUpdatesAsync>d__0 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<Version> <>t__builder;
            public IConfigurationRoot config;
        public HttpClient httpClient;
        private TaskAwaiter<Version> <>u__1;

            private void MoveNext()
        {
            int num = this.<> 1__state;
            try
            {
                Version version;
                Version version2;
                TaskAwaiter<Version> awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<Version>();
                    this.<> 1__state = num = -1;
                    goto TR_0007;
                }
                else
                {
                    string url = this.config["ApplicationSettings:VersionCheckUrl"];
                    awaiter = VersionUtils.GetLatestVersionAsync(this.httpClient, url).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0007;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<Version>, UpdateCheckerUtils.< CheckForUpdatesAsync > d__0 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0007:
                version2 = awaiter.GetResult();
                try
                {
                    Version version3;
                    version = Version.TryParse(AssemblyUtils.GetFileVersion(), ref version3) ? ((version3 < version2) ? version2 : null) : null;
                }
                catch (Exception)
                {
                    version = null;
                }
                this.<> 1__state = -2;
                this.<> t__builder.SetResult(version);
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

