namespace CrossArkChat
{
    public class ServerItem
    {
        public QueryMaster.GameServer.Server Server { get; set; }

        public string ServerTag { get; set; }

        public string ServerPlayerTag { get; set; }

        public string PlayerChatTag { get; set; }

        public string ChatTag { get; set; }

        public bool HideNameTag { get; set; }

        public ulong DiscordChannelId { get; set; }
    }
}

