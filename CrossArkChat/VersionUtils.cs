namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public static class VersionUtils
    {
        [AsyncStateMachine((Type)typeof(< GetLatestVersionAsync > d__0))]
        public static Task<Version> GetLatestVersionAsync(HttpClient httpClient, string url)
        {
            < GetLatestVersionAsync > d__0 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder<Version>.Create();
            d__.httpClient = httpClient;
            d__.url = url;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GetLatestVersionAsync > d__0 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <GetLatestVersionAsync>d__0 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<Version> <>t__builder;
            public string url;
        public HttpClient httpClient;
        private TaskAwaiter<string> <>u__1;

            private void MoveNext()
        {
            Version version;
            int num = this.<> 1__state;
            try
            {
                if ((num != 0) && string.IsNullOrWhiteSpace(this.url))
                {
                    version = new Version();
                }
                else
                {
                    try
                    {
                        TaskAwaiter<string> awaiter;
                        if (num == 0)
                        {
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            goto TR_0006;
                        }
                        else
                        {
                            awaiter = this.httpClient.GetStringAsync(this.url).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                goto TR_0006;
                            }
                            else
                            {
                                this.<> 1__state = num = 0;
                                this.<> u__1 = awaiter;
                                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, VersionUtils.< GetLatestVersionAsync > d__0 > (ref awaiter, ref this);
                            }
                        }
                        return;
                    TR_0006:
                        version = Version.Parse(awaiter.GetResult());
                    }
                    catch (Exception)
                    {
                        version = new Version();
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
            this.<> t__builder.SetResult(version);
        }

        [DebuggerHidden]
        private void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            this.<> t__builder.SetStateMachine(stateMachine);
        }
    }
}
}

