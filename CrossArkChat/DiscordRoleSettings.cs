namespace CrossArkChat
{
    using CrossArkChat.Enums;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class DiscordRoleSettings
    {
        private readonly IConfigurationRoot _config;
        private readonly LoggingService _log;

        public DiscordRoleSettings(IConfigurationRoot config, LoggingService log)
        {
            this._config = config;
            this._log = log;
        }

        public string GetRolenameFromSpecialRole(SpecialRole role)
        {
            switch (role)
            {
                case SpecialRole.PurgeMessage:
                    return this.PurgeMessage;

                case SpecialRole.StartChat:
                    return this.StartChat;

                case SpecialRole.StopChat:
                    return this.StopChat;

                case SpecialRole.RestartChat:
                    return this.RestartChat;

                case SpecialRole.ClearChat:
                    return this.ClearChat;

                case SpecialRole.RebootProgram:
                    return this.RebootProgram;

                case SpecialRole.Rconcommand:
                    return this.RconCommand;

                case SpecialRole.AllowPlayerToJoinNoCheck:
                    return this.AllowPlayerToJoinNoCheck;

                case SpecialRole.BanPlayer:
                    return this.BanPlayer;

                case SpecialRole.Broadcast:
                    return this.Broadcast;

                case SpecialRole.DestroyAll:
                    return this.DestroyAll;

                case SpecialRole.DestroyAllEnemies:
                    return this.DestroyAllEnemies;

                case SpecialRole.DestroyStructures:
                    return this.DestroyStructures;

                case SpecialRole.DestroyWildDinos:
                    return this.DestroyWildDinos;

                case SpecialRole.DisallowPlayerToJoinNoCheck:
                    return this.DisallowPlayerToJoinNoCheck;

                case SpecialRole.DoExit:
                    return this.DoExit;

                case SpecialRole.GetChat:
                    return this.GetChat;

                case SpecialRole.GiveItemNumToPlayer:
                    return this.GiveItemNumToPlayer;

                case SpecialRole.GiveExpToPlayer:
                    return this.GiveExpToPlayer;

                case SpecialRole.KickPlayer:
                    return this.KickPlayer;

                case SpecialRole.KillPlayer:
                    return this.KillPlayer;

                case SpecialRole.ListPlayers:
                    return this.ListPlayers;

                case SpecialRole.PlayersOnly:
                    return this.PlayersOnly;

                case SpecialRole.RenamePlayer:
                    return this.RenamePlayer;

                case SpecialRole.RenameTribe:
                    return this.RenameTribe;

                case SpecialRole.SaveWorld:
                    return this.SaveWorld;

                case SpecialRole.ServerChat:
                    return this.ServerChat;

                case SpecialRole.ServerChatTo:
                    return this.ServerChatTo;

                case SpecialRole.ServerChatToPlayer:
                    return this.ServerChatToPlayer;

                case SpecialRole.SetMessageOfTheDay:
                    return this.SetMessageOfTheDay;

                case SpecialRole.SetTimeOfDay:
                    return this.SetTimeOfDay;

                case SpecialRole.ShowMessageOfTheDay:
                    return this.ShowMessageOfTheDay;

                case SpecialRole.Slomo:
                    return this.Slomo;

                case SpecialRole.UnBanPlayer:
                    return this.UnBanPlayer;

                case SpecialRole.ServerInfo:
                    return this.ServerInfo;

                case SpecialRole.ServerList:
                    return this.ServerList;

                case SpecialRole.ServerBlend:
                    return this.ServerBlend;
            }
            throw new ArgumentOutOfRangeException();
        }

        [AsyncStateMachine((Type)typeof(< LoadAsync > d__151))]
        public Task LoadAsync()
        {
            < LoadAsync > d__151 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << LoadAsync > d__151 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        public string RconCommand { get; set; }

        public string AllowPlayerToJoinNoCheck { get; set; }

        public string BanPlayer { get; set; }

        public string Broadcast { get; set; }

        public string DestroyAll { get; set; }

        public string DestroyAllEnemies { get; set; }

        public string DestroyStructures { get; set; }

        public string DestroyWildDinos { get; set; }

        public string DisallowPlayerToJoinNoCheck { get; set; }

        public string DoExit { get; set; }

        public string GetChat { get; set; }

        public string GiveItemNumToPlayer { get; set; }

        public string GiveExpToPlayer { get; set; }

        public string KickPlayer { get; set; }

        public string KillPlayer { get; set; }

        public string ListPlayers { get; set; }

        public string PlayersOnly { get; set; }

        public string RenamePlayer { get; set; }

        public string RenameTribe { get; set; }

        public string SaveWorld { get; set; }

        public string ServerChat { get; set; }

        public string ServerChatTo { get; set; }

        public string ServerChatToPlayer { get; set; }

        public string SetMessageOfTheDay { get; set; }

        public string SetTimeOfDay { get; set; }

        public string ShowMessageOfTheDay { get; set; }

        public string Slomo { get; set; }

        public string UnBanPlayer { get; set; }

        public string PurgeMessage { get; set; }

        public string StartChat { get; set; }

        public string StopChat { get; set; }

        public string RestartChat { get; set; }

        public string ClearChat { get; set; }

        public string RebootProgram { get; set; }

        public string ServerList { get; set; }

        public string ServerInfo { get; set; }

        public string ServerBlend { get; set; }

        [CompilerGenerated]
        private struct <LoadAsync>d__151 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public DiscordRoleSettings<>4__this;
            private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            DiscordRoleSettings settings = this.<> 4__this;
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
                    IConfigurationSection configuration = settings._config.GetSection("DiscordRoles");
                    settings.RconCommand = configuration.GetValue<string>("RconCommand");
                    settings.AllowPlayerToJoinNoCheck = configuration.GetValue<string>("AllowPlayerToJoinNoCheck");
                    settings.BanPlayer = configuration.GetValue<string>("BanPlayer");
                    settings.Broadcast = configuration.GetValue<string>("Broadcast");
                    settings.DestroyAll = configuration.GetValue<string>("DestroyAll");
                    settings.DestroyAllEnemies = configuration.GetValue<string>("DestroyAllEnemies");
                    settings.DestroyStructures = configuration.GetValue<string>("DestroyStructures");
                    settings.DestroyWildDinos = configuration.GetValue<string>("DestroyWildDinos");
                    settings.DisallowPlayerToJoinNoCheck = configuration.GetValue<string>("DisallowPlayerToJoinNoCheck");
                    settings.DoExit = configuration.GetValue<string>("DoExit");
                    settings.GetChat = configuration.GetValue<string>("GetChat");
                    settings.GiveItemNumToPlayer = configuration.GetValue<string>("GiveItemNumToPlayer");
                    settings.GiveExpToPlayer = configuration.GetValue<string>("GiveExpToPlayer");
                    settings.KickPlayer = configuration.GetValue<string>("KickPlayer");
                    settings.KillPlayer = configuration.GetValue<string>("KillPlayer");
                    settings.ListPlayers = configuration.GetValue<string>("ListPlayers");
                    settings.PlayersOnly = configuration.GetValue<string>("PlayersOnly");
                    settings.RenamePlayer = configuration.GetValue<string>("RenamePlayer");
                    settings.RenameTribe = configuration.GetValue<string>("RenameTribe");
                    settings.SaveWorld = configuration.GetValue<string>("SaveWorld");
                    settings.ServerChat = configuration.GetValue<string>("ServerChat");
                    settings.ServerChatTo = configuration.GetValue<string>("ServerChatTo");
                    settings.ServerChatToPlayer = configuration.GetValue<string>("ServerChatToPlayer");
                    settings.SetMessageOfTheDay = configuration.GetValue<string>("SetMessageOfTheDay");
                    settings.SetTimeOfDay = configuration.GetValue<string>("SetTimeOfDay");
                    settings.ShowMessageOfTheDay = configuration.GetValue<string>("ShowMessageOfTheDay");
                    settings.Slomo = configuration.GetValue<string>("Slomo");
                    settings.UnBanPlayer = configuration.GetValue<string>("UnBanPlayer");
                    settings.PurgeMessage = configuration.GetValue<string>("PurgeMessage");
                    settings.StartChat = configuration.GetValue<string>("StartChat");
                    settings.StopChat = configuration.GetValue<string>("StopChat");
                    settings.RestartChat = configuration.GetValue<string>("RestartChat");
                    settings.ClearChat = configuration.GetValue<string>("ClearChat");
                    settings.RebootProgram = configuration.GetValue<string>("RebootProgram");
                    settings.ServerList = configuration.GetValue<string>("ServerList");
                    settings.ServerInfo = configuration.GetValue<string>("ServerInfo");
                    settings.ServerBlend = configuration.GetValue<string>("ServerBlend");
                    awaiter = Task.Delay(0x3e8).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0004;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, DiscordRoleSettings.< LoadAsync > d__151 > (ref awaiter, ref this);
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

