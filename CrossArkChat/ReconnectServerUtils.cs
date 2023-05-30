namespace CrossArkChat
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class ReconnectServerUtils
    {
        [AsyncStateMachine((Type)typeof(< ReconnectServer > d__0))]
        public Task ReconnectServer(LoggingService _log, IConfigurationRoot _config, ConcurrentDictionary<string, ServerItem> _serverDictionary, string serverName, ServerItem serverItem)
        {
            < ReconnectServer > d__0 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__._config = _config;
            d__._serverDictionary = _serverDictionary;
            d__.serverName = serverName;
            d__.serverItem = serverItem;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ReconnectServer > d__0 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <ReconnectServer>d__0 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public IConfigurationRoot _config;
        public string serverName;
        public ServerItem serverItem;
        public ConcurrentDictionary<string, ServerItem> _serverDictionary;
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
                }
                else
                {
                    goto TR_0014;
                }
            TR_0007:
                awaiter.GetResult();
            TR_0014:
                while (true)
                {
                    if (this.serverItem.Server.Rcon != null)
                    {
                        break;
                    }
                    IEnumerator<IConfigurationSection> enumerator = this._config.GetSection("Servers").GetChildren().GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            IConfigurationSection current = enumerator.Current;
                            if (current.GetValue<bool>("Active") && (current.GetValue<string>("NameTag") == this.serverName))
                            {
                                string pass = current.GetValue<string>("Password");
                                this.serverItem.Server.GetControl(pass);
                                if (this.serverItem.Server.Rcon != null)
                                {
                                    Console.WriteLine("Connect to server " + this.serverName + " again adding back to main que.");
                                    this._serverDictionary.GetOrAdd(this.serverName, this.serverItem);
                                }
                                break;
                            }
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
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, ReconnectServerUtils.< ReconnectServer > d__0 > (ref awaiter, ref this);
                    }
                    return;
                }
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

