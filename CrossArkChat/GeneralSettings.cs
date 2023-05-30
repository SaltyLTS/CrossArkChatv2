namespace CrossArkChat
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class GeneralSettings
    {
        private readonly IConfigurationRoot _config;
        private readonly LoggingService _log;

        public GeneralSettings(IConfigurationRoot config, LoggingService log)
        {
            this._config = config;
            this._log = log;
        }

        [AsyncStateMachine((Type)typeof(< LoadAsync > d__463))]
        public Task LoadAsync()
        {
            < LoadAsync > d__463 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << LoadAsync > d__463 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        public List<string> WordFilterList { get; set; }

        public List<string> CustomTagList { get; set; }

        public Dictionary<string, List<string>> PrefixDictionary { get; set; }

        public Dictionary<string, string> WorldReplacementDictionary { get; set; }

        public Dictionary<string, Server> ServerQueryDictionary { get; set; }

        public ConcurrentDictionary<string, ServerItem> ServerDictionary { get; set; }

        public Dictionary<string, TribeItem> TribeDictionary { get; set; }

        public Dictionary<string, string> GameCommandsDictionary { get; set; }

        public Dictionary<string, EmbedTribeLogsItem> EmbedTribeLogDictionary { get; set; }

        public string VersionCheckUrl { get; set; }

        public string PatchNotesCheckUrl { get; set; }

        public bool LogErrors { get; set; }

        public bool LogChat { get; set; }

        public bool LogAdminCommands { get; set; }

        public bool LogTribeLogs { get; set; }

        public bool UseDiscord { get; set; }

        public string NoResponceTag { get; set; }

        public string NoPlayerTag { get; set; }

        public string ServerRepeatTag { get; set; }

        public string AdminCMDTag { get; set; }

        public string TribeLogTag { get; set; }

        public string GetChatCmd { get; set; }

        public string ListPlayersCmd { get; set; }

        public int ListPlayerCheckTimeInMs { get; set; }

        public int GetChatTimeInMs { get; set; }

        public int PlayerCountCheckTimeInMs { get; set; }

        public int VersionCheckTimeInMs { get; set; }

        public int RconSendTimeoutInMs { get; set; }

        public int RconReceiveTimeoutInMs { get; set; }

        public int RconConnectionRetrys { get; set; }

        public bool UseCustomTags { get; set; }

        public bool SendChatToServers { get; set; }

        public bool ShowAdminCommands { get; set; }

        public bool UseGameCommands { get; set; }

        public bool UsePrefixToSendChat { get; set; }

        public bool UseWordReplacementList { get; set; }

        public string AllServersChatPrefix { get; set; }

        public ulong ChatDiscordChannelID { get; set; }

        public bool SendServerChatToOwnChannel { get; set; }

        public string DiscordChatPrefix { get; set; }

        public bool SendChatToDiscord { get; set; }

        public bool UsePrefixToSendToDiscord { get; set; }

        public string PrefixToSendToDiscord { get; set; }

        public ulong VersionDiscordChannelId { get; set; }

        public ulong PatchNotesDiscordChannelId { get; set; }

        public ulong JoinLeaveNotificationsDiscordChannelID { get; set; }

        public bool UseVersionChecker { get; set; }

        public bool UsePatchNotesChecker { get; set; }

        public bool UseJoinLeaveNotifications { get; set; }

        public bool UsePlayerCountChannelUpdater { get; set; }

        public bool SendJoinLeaveNotificationsToServerOwnChannel { get; set; }

        public ulong AdminCommandsDiscordChannelID { get; set; }

        public bool SendAdminCommandsToOwnChannel { get; set; }

        public ulong TribeLogsDiscordChannelID { get; set; }

        public bool ShowTribelogs { get; set; }

        public bool ShowFullTribeLog { get; set; }

        public bool ShowTribeId { get; set; }

        public bool ShowTribeName { get; set; }

        public bool ShowServerName { get; set; }

        public bool EmbedTribeLog { get; set; }

        public bool SendTribeLogsToOwnChannel { get; set; }

        public ulong SupportDiscordChannelID { get; set; }

        public bool UseSupportPrefix { get; set; }

        public bool PingRoleName { get; set; }

        public bool ReplyToSupportPing { get; set; }

        public string SupportPrefix { get; set; }

        public string SupportRoleToPing { get; set; }

        public string SupportPingReply { get; set; }

        public string PickAServer { get; set; }

        public string PickAllServers { get; set; }

        public string ReplyWithNumberStart { get; set; }

        public string ReplyWithNumberEnd { get; set; }

        public string CommandSent { get; set; }

        public string CommandSentTo { get; set; }

        public string AllCommandsSent { get; set; }

        public string NoReplyData { get; set; }

        public string NoServerSelected { get; set; }

        public string NoSelectionTimeout { get; set; }

        public string WrongServerName { get; set; }

        public string ChatStart { get; set; }

        public string ChatStartFailed { get; set; }

        public string ChatStop { get; set; }

        public string ChatClear { get; set; }

        public string PlayerJoinStart { get; set; }

        public string PlayerJoinMiddle { get; set; }

        public string PlayerJoinEnd { get; set; }

        public string PlayerLeftStart { get; set; }

        public string PlayerLeftMiddle { get; set; }

        public string PlayerLeftEnd { get; set; }

        public string PlayerCountStart { get; set; }

        public string PlayerCountMiddle { get; set; }

        public string MaxPlayerCount { get; set; }

        public string PlayerCountEnd { get; set; }

        public string VersionCheckStart { get; set; }

        public string VersionCheckEnd { get; set; }

        public string PatchNotesStart { get; set; }

        public string PatchNotesEnd { get; set; }

        public string DeleteMaxStart { get; set; }

        public string DeleteMaxEnd { get; set; }

        public string DeletedOne { get; set; }

        public string DeletedMessages { get; set; }

        public string CommandList { get; set; }

        public string NoCommandFoundStart { get; set; }

        public string NoCommandFoundEnd { get; set; }

        public string SimularCommand { get; set; }

        public string CommandUsage { get; set; }

        public string CommandSummary { get; set; }

        public string NoInfoFoundStart { get; set; }

        public string NoInfoFoundMiddle { get; set; }

        public string NoInfoFoundEnd { get; set; }

        public string ServerInfoMap { get; set; }

        public string ServerInfoPlayerOnline { get; set; }

        public string ServerInfoMaxPlayer { get; set; }

        public string ServerInfoPing { get; set; }

        public string ServerInfoConnect { get; set; }

        [CompilerGenerated]
        private struct <LoadAsync>d__463 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public GeneralSettings<>4__this;
            private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            GeneralSettings settings = this.<> 4__this;
            try
            {
                TaskAwaiter awaiter;
                if (num == 0)
                {
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter();
                    this.<> 1__state = num = -1;
                    goto TR_0016;
                }
                else
                {
                    IEnumerator<IConfigurationSection> enumerator2;
                    settings.WordFilterList = settings._config.GetSection("WordFilterList").Get<List<string>>();
                    settings.CustomTagList = settings._config.GetSection("CustomTagList").Get<List<string>>();
                    IConfigurationSection configuration = settings._config.GetSection("ApplicationSettings");
                    settings.VersionCheckUrl = configuration.GetValue<string>("VersionCheckUrl");
                    settings.PatchNotesCheckUrl = configuration.GetValue<string>("PatchNotesCheckUrl");
                    settings.LogErrors = configuration.GetValue<bool>("LogErrors");
                    settings.LogChat = configuration.GetValue<bool>("LogChat");
                    settings.LogAdminCommands = configuration.GetValue<bool>("LogAdminCommands");
                    settings.LogTribeLogs = configuration.GetValue<bool>("LogTribeLogs");
                    settings.UseDiscord = configuration.GetValue<bool>("UseDiscord");
                    IConfigurationSection section = settings._config.GetSection("RconSettings");
                    settings.NoResponceTag = section.GetValue<string>("NoResponceTag");
                    settings.NoPlayerTag = section.GetValue<string>("NoPlayerTag");
                    settings.ServerRepeatTag = section.GetValue<string>("ServerRepeatTag");
                    settings.AdminCMDTag = section.GetValue<string>("AdminCMDTag");
                    settings.TribeLogTag = section.GetValue<string>("TribeLogTag");
                    settings.GetChatCmd = section.GetValue<string>("GetChatCmd");
                    settings.ListPlayersCmd = section.GetValue<string>("ListPlayersCmd");
                    settings.ListPlayerCheckTimeInMs = section.GetValue<int>("ListPlayerCheckTimeInMs");
                    settings.GetChatTimeInMs = section.GetValue<int>("GetChatTimeInMs");
                    settings.PlayerCountCheckTimeInMs = section.GetValue<int>("PlayerCountCheckTimeInMs");
                    settings.VersionCheckTimeInMs = section.GetValue<int>("VersionCheckTimeInMs");
                    settings.RconSendTimeoutInMs = section.GetValue<int>("RconSendTimeoutInMs");
                    settings.RconReceiveTimeoutInMs = section.GetValue<int>("RconReceiveTimeoutInMs");
                    settings.RconConnectionRetrys = section.GetValue<int>("RconConnectionRetrys");
                    IConfigurationSection section3 = settings._config.GetSection("ChatSettings");
                    settings.UseCustomTags = section3.GetValue<bool>("UseCustomTags");
                    settings.SendChatToServers = section3.GetValue<bool>("SendChatToServers");
                    settings.ShowAdminCommands = section3.GetValue<bool>("ShowAdminCommands");
                    settings.UseGameCommands = section3.GetValue<bool>("UseGameCommands");
                    settings.UsePrefixToSendChat = section3.GetValue<bool>("UsePrefixToSendChat");
                    settings.UseWordReplacementList = section3.GetValue<bool>("UseWordReplacementList");
                    settings.AllServersChatPrefix = section3.GetValue<string>("AllServersChatPrefix");
                    IConfigurationSection section4 = settings._config.GetSection("DiscordSettings:ServerChatSettings");
                    settings.ChatDiscordChannelID = section4.GetValue<ulong>("ChatDiscordChannelID");
                    settings.SendServerChatToOwnChannel = section4.GetValue<bool>("SendServerChatToOwnChannel");
                    IConfigurationSection section5 = settings._config.GetSection("DiscordSettings:DiscordChatSettings");
                    settings.DiscordChatPrefix = section5.GetValue<string>("DiscordChatPrefix");
                    settings.SendChatToDiscord = section5.GetValue<bool>("SendChatToDiscord");
                    settings.UsePrefixToSendToDiscord = section5.GetValue<bool>("UsePrefixToSendToDiscord");
                    settings.PrefixToSendToDiscord = section5.GetValue<string>("PrefixToSendToDiscord");
                    IConfigurationSection section6 = settings._config.GetSection("DiscordSettings:NotificationSettings");
                    settings.VersionDiscordChannelId = section6.GetValue<ulong>("VersionDiscordChannelId");
                    settings.PatchNotesDiscordChannelId = section6.GetValue<ulong>("PatchNotesDiscordChannelId");
                    settings.JoinLeaveNotificationsDiscordChannelID = section6.GetValue<ulong>("JoinLeaveNotificationsDiscordChannelID");
                    settings.UseVersionChecker = section6.GetValue<bool>("UseVersionChecker");
                    settings.UsePatchNotesChecker = section6.GetValue<bool>("UsePatchNotesChecker");
                    settings.UseJoinLeaveNotifications = section6.GetValue<bool>("UseJoinLeaveNotifications");
                    settings.UsePlayerCountChannelUpdater = section6.GetValue<bool>("UsePlayerCountChannelUpdater");
                    settings.SendJoinLeaveNotificationsToServerOwnChannel = section6.GetValue<bool>("SendJoinLeaveNotificationsToServerOwnChannel");
                    IConfigurationSection section7 = settings._config.GetSection("DiscordSettings:AdminCommandSettings");
                    settings.AdminCommandsDiscordChannelID = section7.GetValue<ulong>("AdminCommandsDiscordChannelID");
                    settings.SendAdminCommandsToOwnChannel = section7.GetValue<bool>("SendAdminCommandsToOwnChannel");
                    IConfigurationSection section8 = settings._config.GetSection("DiscordSettings:TribeLogSettings");
                    settings.TribeLogsDiscordChannelID = section8.GetValue<ulong>("TribeLogsDiscordChannelID");
                    settings.ShowTribelogs = section8.GetValue<bool>("ShowTribelogs");
                    settings.ShowFullTribeLog = section8.GetValue<bool>("ShowFullTribeLog");
                    settings.ShowTribeId = section8.GetValue<bool>("ShowTribeId");
                    settings.ShowTribeName = section8.GetValue<bool>("ShowTribeName");
                    settings.ShowServerName = section8.GetValue<bool>("ShowServerName");
                    settings.EmbedTribeLog = section8.GetValue<bool>("EmbedTribeLog");
                    settings.SendTribeLogsToOwnChannel = section8.GetValue<bool>("SendTribeLogsToOwnChannel");
                    IConfigurationSection section9 = settings._config.GetSection("DiscordSettings:SupportSettings");
                    settings.SupportDiscordChannelID = section9.GetValue<ulong>("SupportDiscordChannelID");
                    settings.UseSupportPrefix = section9.GetValue<bool>("UseSupportPrefix");
                    settings.PingRoleName = section9.GetValue<bool>("PingRoleName");
                    settings.ReplyToSupportPing = section9.GetValue<bool>("ReplyToSupportPing");
                    settings.SupportPrefix = section9.GetValue<string>("SupportPrefix");
                    settings.SupportRoleToPing = section9.GetValue<string>("SupportRoleToPing");
                    settings.SupportPingReply = section9.GetValue<string>("SupportPingReply");
                    IConfigurationSection section10 = settings._config.GetSection("RconReplys");
                    settings.PickAServer = section10.GetValue<string>("PickAServer");
                    settings.PickAllServers = section10.GetValue<string>("PickAllServers");
                    settings.ReplyWithNumberStart = section10.GetValue<string>("ReplyWithNumberStart");
                    settings.ReplyWithNumberEnd = section10.GetValue<string>("ReplyWithNumberEnd");
                    settings.CommandSent = section10.GetValue<string>("CommandSent");
                    settings.CommandSentTo = section10.GetValue<string>("CommandSentTo");
                    settings.AllCommandsSent = section10.GetValue<string>("AllCommandsSent");
                    settings.NoReplyData = section10.GetValue<string>("NoReplyData");
                    settings.NoServerSelected = section10.GetValue<string>("NoServerSelected");
                    settings.NoSelectionTimeout = section10.GetValue<string>("NoSelectionTimeout");
                    settings.WrongServerName = section10.GetValue<string>("WrongServerName");
                    IConfigurationSection section11 = settings._config.GetSection("CrossArkChatReplys");
                    settings.ChatStart = section11.GetValue<string>("ChatStart");
                    settings.ChatStartFailed = section11.GetValue<string>("ChatStartFailed");
                    settings.ChatStop = section11.GetValue<string>("ChatStop");
                    settings.ChatClear = section11.GetValue<string>("ChatClear");
                    IConfigurationSection section12 = settings._config.GetSection("NotificationReplys");
                    settings.PlayerJoinStart = section12.GetValue<string>("PlayerJoinStart");
                    settings.PlayerJoinMiddle = section12.GetValue<string>("PlayerJoinMiddle");
                    settings.PlayerJoinEnd = section12.GetValue<string>("PlayerJoinEnd");
                    settings.PlayerLeftStart = section12.GetValue<string>("PlayerLeftStart");
                    settings.PlayerLeftMiddle = section12.GetValue<string>("PlayerLeftMiddle");
                    settings.PlayerLeftEnd = section12.GetValue<string>("PlayerLeftEnd");
                    settings.PlayerCountStart = section12.GetValue<string>("PlayerCountStart");
                    settings.PlayerCountMiddle = section12.GetValue<string>("PlayerCountMiddle");
                    settings.MaxPlayerCount = section12.GetValue<string>("MaxPlayerCount");
                    settings.PlayerCountEnd = section12.GetValue<string>("PlayerCountEnd");
                    settings.VersionCheckStart = section12.GetValue<string>("VersionCheckStart");
                    settings.VersionCheckEnd = section12.GetValue<string>("VersionCheckEnd");
                    settings.PatchNotesStart = section12.GetValue<string>("PatchNotesStart");
                    settings.PatchNotesEnd = section12.GetValue<string>("PatchNotesEnd");
                    IConfigurationSection section13 = settings._config.GetSection("DiscordReplys");
                    settings.DeleteMaxStart = section13.GetValue<string>("DeleteMaxStart");
                    settings.DeleteMaxEnd = section13.GetValue<string>("DeleteMaxEnd");
                    settings.DeletedOne = section13.GetValue<string>("DeletedOne");
                    settings.DeletedMessages = section13.GetValue<string>("DeletedMessages");
                    IConfigurationSection section14 = settings._config.GetSection("CommandHelpReplys");
                    settings.CommandList = section14.GetValue<string>("CommandList");
                    settings.NoCommandFoundStart = section14.GetValue<string>("NoCommandFoundStart");
                    settings.NoCommandFoundEnd = section14.GetValue<string>("NoCommandFoundEnd");
                    settings.SimularCommand = section14.GetValue<string>("SimularCommand");
                    settings.CommandUsage = section14.GetValue<string>("CommandUsage");
                    settings.CommandSummary = section14.GetValue<string>("CommandSummary");
                    IConfigurationSection section15 = settings._config.GetSection("ServerQueryReplys");
                    settings.NoInfoFoundStart = section15.GetValue<string>("NoInfoFoundStart");
                    settings.NoInfoFoundMiddle = section15.GetValue<string>("NoInfoFoundMiddle");
                    settings.NoInfoFoundEnd = section15.GetValue<string>("NoInfoFoundEnd");
                    settings.ServerInfoMap = section15.GetValue<string>("ServerInfoMap");
                    settings.ServerInfoPlayerOnline = section15.GetValue<string>("ServerInfoPlayerOnline");
                    settings.ServerInfoMaxPlayer = section15.GetValue<string>("ServerInfoMaxPlayer");
                    settings.ServerInfoPing = section15.GetValue<string>("ServerInfoPing");
                    settings.ServerInfoConnect = section15.GetValue<string>("ServerInfoConnect");
                    IConfigurationSection section16 = settings._config.GetSection("ServerSettings");
                    IEnumerator<IConfigurationSection> enumerator = settings._config.GetSection("Servers").GetChildren().GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            IConfigurationSection current = enumerator.Current;
                            GeneralSettings <> 4__this = settings;
                            if (current.GetValue<bool>("Active"))
                            {
                                IPAddress address;
                                Server server = null;
                                int num2 = current.GetValue<int>("SettingToUse");
                                string str = null;
                                string str2 = null;
                                string str3 = null;
                                string str4 = null;
                                bool flag = true;
                                ulong num3 = 0UL;
                                enumerator2 = section16.GetChildren().GetEnumerator();
                                try
                                {
                                    while (enumerator2.MoveNext())
                                    {
                                        IConfigurationSection section18 = enumerator2.Current;
                                        if (num2 == section18.GetValue<int>("SettingNumber"))
                                        {
                                            str = section18.GetValue<string>("ServerTag");
                                            str2 = section18.GetValue<string>("ServerPlayerTag");
                                            str3 = section18.GetValue<string>("PlayerChatTag");
                                            str4 = section18.GetValue<string>("ChatTag");
                                            flag = section18.GetValue<bool>("HideNameTag");
                                            num3 = section18.GetValue<ulong>("DiscordChannelId");
                                            break;
                                        }
                                    }
                                }
                                finally
                                {
                                    if ((num < 0) && (enumerator2 != null))
                                    {
                                        enumerator2.Dispose();
                                    }
                                }
                                server = current.GetValue<Server>("Map");
                                string nameTag = current.GetValue<string>("NameTag");
                                int port = current.GetValue<int>("RconPort");
                                int num5 = current.GetValue<int>("QueryPort");
                                string pass = current.GetValue<string>("Password");
                                if (IPAddress.TryParse(current.GetValue<string>("IP"), out address) && ((port > 0) && !string.IsNullOrWhiteSpace(nameTag)))
                                {
                                    server = ServerQuery.GetServerInstance(EngineType.Source, new IPEndPoint(address, port), false, settings.RconSendTimeoutInMs, settings.RconReceiveTimeoutInMs, settings.RconConnectionRetrys, false);
                                    if (server != null)
                                    {
                                        server.GetControl(pass);
                                        ServerItem item1 = new ServerItem();
                                        item1.Server = server;
                                        item1.ServerTag = str;
                                        item1.ServerPlayerTag = str2;
                                        item1.PlayerChatTag = str3;
                                        item1.ChatTag = str4;
                                        item1.HideNameTag = flag;
                                        item1.DiscordChannelId = num3;
                                        ServerItem tempServerItem = item1;
                                        if (server.Rcon != null)
                                        {
                                            settings.ServerDictionary.GetOrAdd(nameTag, tempServerItem);
                                        }
                                        else
                                        {
                                            GeneralSettings.<> c__DisplayClass463_0 class_;
                                            Console.WriteLine("Unable to connect to " + nameTag + " adding to the auto reconnect que.");
                                            Task.Run(new Func<Task>(class_.< LoadAsync > b__0));
                                        }
                                        if (num5 != 0)
                                        {
                                            server = null;
                                            server = ServerQuery.GetServerInstance(EngineType.Source, new IPEndPoint(address, num5), false, settings.RconSendTimeoutInMs, settings.RconReceiveTimeoutInMs, settings.RconConnectionRetrys, false);
                                            if (server != null)
                                            {
                                                settings.ServerQueryDictionary.Add(nameTag, server);
                                            }
                                        }
                                    }
                                }
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
                    if (settings.UsePrefixToSendChat)
                    {
                        enumerator = settings._config.GetSection("PrefixGroups").GetChildren().GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IConfigurationSection current = enumerator.Current;
                                string key = current.GetValue<string>("ChatPrefix");
                                List<string> list = current.GetSection("ServerList").Get<List<string>>();
                                settings.PrefixDictionary.Add(key, list);
                            }
                        }
                        finally
                        {
                            if ((num < 0) && (enumerator != null))
                            {
                                enumerator.Dispose();
                            }
                        }
                    }
                    if (settings.UseWordReplacementList)
                    {
                        enumerator = settings._config.GetSection("WordReplacementList").GetChildren().GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IConfigurationSection current = enumerator.Current;
                                string key = current.GetValue<string>("OldWord");
                                string str8 = current.GetValue<string>("NewWord");
                                settings.WorldReplacementDictionary.Add(key, str8);
                            }
                        }
                        finally
                        {
                            if ((num < 0) && (enumerator != null))
                            {
                                enumerator.Dispose();
                            }
                        }
                    }
                    if (settings.SendTribeLogsToOwnChannel)
                    {
                        IConfigurationSection section19 = settings._config.GetSection("TribeSettings");
                        enumerator = settings._config.GetSection("Tribes").GetChildren().GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IConfigurationSection current = enumerator.Current;
                                if (current.GetValue<bool>("Active"))
                                {
                                    string key = current.GetValue<string>("TribeId");
                                    int num6 = current.GetValue<int>("SettingToUse");
                                    bool flag2 = false;
                                    bool flag3 = false;
                                    bool flag4 = false;
                                    bool flag5 = false;
                                    bool flag6 = true;
                                    ulong num7 = 0UL;
                                    enumerator2 = section19.GetChildren().GetEnumerator();
                                    try
                                    {
                                        while (enumerator2.MoveNext())
                                        {
                                            IConfigurationSection section21 = enumerator2.Current;
                                            if (num6 == section21.GetValue<int>("SettingNumber"))
                                            {
                                                flag2 = section21.GetValue<bool>("ShowFullTribeLog");
                                                flag3 = section21.GetValue<bool>("ShowTribeName");
                                                flag4 = section21.GetValue<bool>("ShowServerName");
                                                flag5 = section21.GetValue<bool>("ShowTribeId");
                                                flag6 = section21.GetValue<bool>("EmbedTribeLog");
                                                num7 = section21.GetValue<ulong>("DiscordChannelId");
                                            }
                                        }
                                    }
                                    finally
                                    {
                                        if ((num < 0) && (enumerator2 != null))
                                        {
                                            enumerator2.Dispose();
                                        }
                                    }
                                    TribeItem item3 = new TribeItem();
                                    item3.ShowFullTribeLog = flag2;
                                    item3.ShowTribeName = flag3;
                                    item3.ShowServerName = flag4;
                                    item3.ShowTribeId = flag5;
                                    item3.EmbedTribeLog = flag6;
                                    item3.DiscordChannelId = num7;
                                    settings.TribeDictionary.Add(key, item3);
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
                    }
                    if (settings.UseGameCommands)
                    {
                        enumerator = settings._config.GetSection("GameCommands").GetChildren().GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IConfigurationSection current = enumerator.Current;
                                if (current.GetValue<bool>("Active"))
                                {
                                    string key = current.GetValue<string>("Command");
                                    settings.GameCommandsDictionary.Add(key, current.GetValue<string>("CommandReply"));
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
                    }
                    if (settings.EmbedTribeLog)
                    {
                        enumerator = settings._config.GetSection("EmbeddedTribeLogColorSettings").GetChildren().GetEnumerator();
                        try
                        {
                            while (enumerator.MoveNext())
                            {
                                IConfigurationSection current = enumerator.Current;
                                string key = current.GetValue<string>("LogType");
                                string str13 = current.GetValue<string>("LogColor");
                                string str14 = current.GetValue<string>("RoleToPing");
                                EmbedTribeLogsItem item4 = new EmbedTribeLogsItem();
                                item4.LogColor = str13;
                                item4.RoleToPing = str14;
                                EmbedTribeLogsItem item2 = item4;
                                settings.EmbedTribeLogDictionary.Add(key, item2);
                            }
                        }
                        finally
                        {
                            if ((num < 0) && (enumerator != null))
                            {
                                enumerator.Dispose();
                            }
                        }
                    }
                    awaiter = Task.Delay(0x3e8).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0016;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, GeneralSettings.< LoadAsync > d__463 > (ref awaiter, ref this);
                    }
                }
                return;
            TR_0016:
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

