namespace CrossArkChat
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoggingService
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _service;
        private string _logDirectory = Path.Combine(AppContext.get_BaseDirectory(), "logs");
        private string _logFile;
        private string _configErrorLogFile;
        private string _rconErrorLogFile;
        private string _rconChatLogFile;
        private string _rconTribeLogFile;
        private string _rconAdminCommandLogFile;

        public LoggingService(DiscordSocketClient discord, CommandService service)
        {
            this._logFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_DiscordLogs.txt");
            this._configErrorLogFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_ConfigErrors.txt");
            this._rconErrorLogFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_RconErrors.txt");
            this._rconChatLogFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_RconChat.txt");
            this._rconTribeLogFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_RconTribeLogs.txt");
            this._rconAdminCommandLogFile = Path.Combine(this._logDirectory, DateTime.get_UtcNow().ToString("yyyy-MM-dd") + "_RconAdminCommands.txt");
            this._discord = discord;
            this._service = service;
            this._discord.add_Log(new Func<LogMessage, Task>(this.OnLogAsync));
            this._service.add_Log(new Func<LogMessage, Task>(this.OnLogAsync));
        }

        [AsyncStateMachine((Type)typeof(< CrossArkConfigErrorLogging > d__11))]
        public Task CrossArkConfigErrorLogging(string errorMessage, bool logToConsole)
        {
            < CrossArkConfigErrorLogging > d__11 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.errorMessage = errorMessage;
            d__.logToConsole = logToConsole;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkConfigErrorLogging > d__11 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< CrossArkRconAdminCommandLogging > d__15))]
        public Task CrossArkRconAdminCommandLogging(string adminCommand)
        {
            < CrossArkRconAdminCommandLogging > d__15 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.adminCommand = adminCommand;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkRconAdminCommandLogging > d__15 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< CrossArkRconChatLogging > d__13))]
        public Task CrossArkRconChatLogging(string chatMessage)
        {
            < CrossArkRconChatLogging > d__13 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.chatMessage = chatMessage;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkRconChatLogging > d__13 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< CrossArkRconErrorLogging > d__12))]
        public Task CrossArkRconErrorLogging(string errorMessage)
        {
            < CrossArkRconErrorLogging > d__12 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.errorMessage = errorMessage;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkRconErrorLogging > d__12 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< CrossArkRconTribeLogging > d__14))]
        public Task CrossArkRconTribeLogging(string tribeLog)
        {
            < CrossArkRconTribeLogging > d__14 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.tribeLog = tribeLog;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << CrossArkRconTribeLogging > d__14 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        private Task OnLogAsync(LogMessage message)
        {
            string text1;
            if (!Directory.Exists(this._logDirectory))
            {
                Directory.CreateDirectory(this._logDirectory);
            }
            if (!File.Exists(this._logFile))
            {
                File.Create(this._logFile).Dispose();
            }
            object[] objArray1 = new object[4];
            objArray1[0] = DateTime.get_UtcNow().ToString("hh:mm:ss");
            objArray1[1] = message.Severity;
            objArray1[2] = message.Source;
            Exception exception1 = message.get_Exception();
            object[] objArray2 = objArray1;
            if (exception1 != null)
            {
                text1 = exception1.ToString();
            }
            else
            {
                Exception local1 = exception1;
                text1 = null;
            }
            string local2 = text1;
            string text2 = local2;
            if (local2 == null)
            {
                string local3 = local2;
                text2 = message.Message;
            }
            objArray1[3] = text2;
            string str = string.Format("{0} [{1}] {2}: {3}", (object[])objArray1);
            File.AppendAllText(this._logFile, str + "\n");
            return Console.Out.WriteLineAsync(str);
        }

        [CompilerGenerated]
        private struct <CrossArkConfigErrorLogging>d__11 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public LoggingService<>4__this;
            public string errorMessage;
        public bool logToConsole;
        private string <logText>5__2;
            private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            LoggingService service = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                    goto TR_0005;
                }
                else
                {
                    if (!Directory.Exists(service._logDirectory))
                    {
                        Directory.CreateDirectory(service._logDirectory);
                    }
                    if (!File.Exists(service._configErrorLogFile))
                    {
                        File.Create(service._configErrorLogFile).Dispose();
                    }
                    this.< logText > 5__2 = DateTime.get_UtcNow().ToString("hh:mm:ss") + " " + this.errorMessage.Trim();
                    CancellationToken cancellationToken = new CancellationToken();
                    awaiter = File.AppendAllTextAsync(service._configErrorLogFile, this.< logText > 5__2 + "\n", cancellationToken).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0005;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, LoggingService.< CrossArkConfigErrorLogging > d__11 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0005:
                awaiter.GetResult();
                if (this.logToConsole)
                {
                    Console.WriteLine(this.< logText > 5__2);
                }
                this.<> 1__state = -2;
                this.< logText > 5__2 = null;
                this.<> t__builder.SetResult();
            }
            catch (Exception exception)
            {
                this.<> 1__state = -2;
                this.< logText > 5__2 = null;
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
    private struct <CrossArkRconAdminCommandLogging>d__15 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public LoggingService<>4__this;
            public string adminCommand;
    private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        LoggingService service = this.<> 4__this;
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
                if (!Directory.Exists(service._logDirectory))
                {
                    Directory.CreateDirectory(service._logDirectory);
                }
                if (!File.Exists(service._rconAdminCommandLogFile))
                {
                    File.Create(service._rconAdminCommandLogFile).Dispose();
                }
                string str = DateTime.get_UtcNow().ToString("hh:mm:ss") + " " + this.adminCommand.Trim();
                CancellationToken cancellationToken = new CancellationToken();
                awaiter = File.AppendAllTextAsync(service._rconAdminCommandLogFile, str + "\n", cancellationToken).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0004;
                }
                else
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, LoggingService.< CrossArkRconAdminCommandLogging > d__15 > (ref awaiter, ref this);
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
private struct <CrossArkRconChatLogging>d__13: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public LoggingService<> 4__this;
public string chatMessage;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    LoggingService service = this.<> 4__this;
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
            if (!Directory.Exists(service._logDirectory))
            {
                Directory.CreateDirectory(service._logDirectory);
            }
            if (!File.Exists(service._rconChatLogFile))
            {
                File.Create(service._rconChatLogFile).Dispose();
            }
            string str = DateTime.get_UtcNow().ToString("hh:mm:ss") + " " + this.chatMessage.Trim();
            CancellationToken cancellationToken = new CancellationToken();
            awaiter = File.AppendAllTextAsync(service._rconChatLogFile, str + "\n", cancellationToken).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, LoggingService.< CrossArkRconChatLogging > d__13 > (ref awaiter, ref this);
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
private struct <CrossArkRconErrorLogging>d__12: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public LoggingService<> 4__this;
public string errorMessage;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    LoggingService service = this.<> 4__this;
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
            if (!Directory.Exists(service._logDirectory))
            {
                Directory.CreateDirectory(service._logDirectory);
            }
            if (!File.Exists(service._rconErrorLogFile))
            {
                File.Create(service._rconErrorLogFile).Dispose();
            }
            string str = DateTime.get_UtcNow().ToString("hh:mm:ss") + " " + this.errorMessage.Trim();
            CancellationToken cancellationToken = new CancellationToken();
            awaiter = File.AppendAllTextAsync(service._rconErrorLogFile, str + "\n", cancellationToken).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, LoggingService.< CrossArkRconErrorLogging > d__12 > (ref awaiter, ref this);
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
private struct <CrossArkRconTribeLogging>d__14: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public LoggingService<> 4__this;
public string tribeLog;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    LoggingService service = this.<> 4__this;
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
            if (!Directory.Exists(service._logDirectory))
            {
                Directory.CreateDirectory(service._logDirectory);
            }
            if (!File.Exists(service._rconTribeLogFile))
            {
                File.Create(service._rconTribeLogFile).Dispose();
            }
            string str = DateTime.get_UtcNow().ToString("hh:mm:ss") + " " + this.tribeLog.Trim();
            CancellationToken cancellationToken = new CancellationToken();
            awaiter = File.AppendAllTextAsync(service._rconTribeLogFile, str + "\n", cancellationToken).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, LoggingService.< CrossArkRconTribeLogging > d__14 > (ref awaiter, ref this);
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

