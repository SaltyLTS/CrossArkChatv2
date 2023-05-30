namespace CrossArkChat.Modules
{
    using CrossArkChat;
    using CrossArkChat.Enums;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    [Name("Rcon")]
    public class RconCommandModule : InteractiveBase
    {
        private readonly IConfigurationRoot _config;
        private readonly GeneralSettings _settings;

        public RconCommandModule(IConfigurationRoot config, GeneralSettings settings)
        {
            this._config = config;
            this._settings = settings;
        }

        [AsyncStateMachine((Type)typeof(< AllowPlayerToJoinNoCheckAsync > d__5)), Command("AllowPlayerToJoinNoCheck", RunMode = RunMode.Async), RequireRole(SpecialRole.AllowPlayerToJoinNoCheck), Summary("Adds the specified player to the server's whitelist."), Remarks("AllowPlayerToJoinNoCheck steamId")]
        public Task AllowPlayerToJoinNoCheckAsync(ulong steamId)
        {
            < AllowPlayerToJoinNoCheckAsync > d__5 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << AllowPlayerToJoinNoCheckAsync > d__5 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< AllowPlayerToJoinNoCheckAsync > d__6)), Command("AllowPlayerToJoinNoCheck", RunMode = RunMode.Async), RequireRole(SpecialRole.AllowPlayerToJoinNoCheck), Summary("Adds the specified player to the server's whitelist."), Remarks("AllowPlayerToJoinNoCheck MapName steamId")]
        public Task AllowPlayerToJoinNoCheckAsync(string serverName, ulong steamId)
        {
            < AllowPlayerToJoinNoCheckAsync > d__6 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << AllowPlayerToJoinNoCheckAsync > d__6 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BanPlayerAsync > d__7)), Command("BanPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.BanPlayer), Summary("Add the specified player to the server's banned list."), Remarks("BanPlayer steamId")]
        public Task BanPlayerAsync(ulong steamId)
        {
            < BanPlayerAsync > d__7 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BanPlayerAsync > d__7 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BanPlayerAsync > d__8)), Command("BanPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.BanPlayer), Summary("Add the specified player to the server's banned list."), Remarks("BanPlayer MapName steamId")]
        public Task BanPlayerAsync(string serverName, ulong steamId)
        {
            < BanPlayerAsync > d__8 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BanPlayerAsync > d__8 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BlankRconAsync > d__3)), Command("rcon", RunMode = RunMode.Async), RequireRole(SpecialRole.Rconcommand), Summary("Allows you to run any RCON command."), Remarks("rcon rconcommand")]
        public Task BlankRconAsync([Remainder] string command)
        {
            < BlankRconAsync > d__3 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.command = command;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BlankRconAsync > d__3 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BlankRconAsync > d__4)), Command("rcon", RunMode = RunMode.Async), RequireRole(SpecialRole.Rconcommand), Summary("Allows you to run any RCON command."), Remarks("rcon MapName rconcommand")]
        public Task BlankRconAsync(string serverName, [Remainder] string command)
        {
            < BlankRconAsync > d__4 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.command = command;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BlankRconAsync > d__4 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BroadcastAsync > d__9)), Command("Broadcast", RunMode = RunMode.Async), RequireRole(SpecialRole.Broadcast), Summary("Broadcast a message to all players on the server."), Remarks("Broadcast message")]
        public Task BroadcastAsync([Remainder] string message)
        {
            < BroadcastAsync > d__9 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BroadcastAsync > d__9 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< BroadcastAsync > d__10)), Command("Broadcast", RunMode = RunMode.Async), RequireRole(SpecialRole.Broadcast), Summary("Broadcast a message to all players on the server."), Remarks("Broadcast MapName message")]
        public Task BroadcastAsync(string serverName, [Remainder] string message)
        {
            < BroadcastAsync > d__10 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << BroadcastAsync > d__10 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyAllAsync > d__11)), Command("DestroyAll", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyAll), Summary("Destroys ALL creatures of the specified class."), Remarks("DestroyAll className")]
        public Task DestroyAllAsync(string className)
        {
            < DestroyAllAsync > d__11 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.className = className;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyAllAsync > d__11 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyAllAsync > d__12)), Command("DestroyAll", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyAll), Summary("Destroys ALL creatures of the specified class."), Remarks("DestroyAll MapName className")]
        public Task DestroyAllAsync(string serverName, string className)
        {
            < DestroyAllAsync > d__12 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.className = className;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyAllAsync > d__12 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyAllEnemiesAsync > d__13)), Command("DestroyAllEnemies", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyAllEnemies), Summary("Destroys all non-player creatures on the map, including tamed creatures. This does not prevent new ones from spawning as usual."), Remarks("DestroyAllEnemies")]
        public Task DestroyAllEnemiesAsync()
        {
            < DestroyAllEnemiesAsync > d__13 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyAllEnemiesAsync > d__13 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyAllEnemiesAsync > d__14)), Command("DestroyAllEnemies", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyAllEnemies), Summary("Destroys all non-player creatures on the map, including tamed creatures. This does not prevent new ones from spawning as usual."), Remarks("DestroyAllEnemies MapName")]
        public Task DestroyAllEnemiesAsync(string serverName)
        {
            < DestroyAllEnemiesAsync > d__14 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyAllEnemiesAsync > d__14 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyStructuresAsync > d__15)), Command("DestroyStructures", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyStructures), Summary("Destroys all structures owned by all players on the map."), Remarks("DestroyStructures")]
        public Task DestroyStructuresAsync()
        {
            < DestroyStructuresAsync > d__15 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyStructuresAsync > d__15 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyStructuresAsync > d__16)), Command("DestroyStructures", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyStructures), Summary("Destroys all structures owned by all players on the map."), Remarks("DestroyStructures MapName")]
        public Task DestroyStructuresAsync(string serverName)
        {
            < DestroyStructuresAsync > d__16 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyStructuresAsync > d__16 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyWildDinosAsync > d__17)), Command("DestroyWildDinos", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyWildDinos), Summary("Destroys all untamed creatures on the map. Useful for helping newly-released creatures to spawn."), Remarks("DestroyWildDinos")]
        public Task DestroyWildDinosAsync()
        {
            < DestroyWildDinosAsync > d__17 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyWildDinosAsync > d__17 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DestroyWildDinosAsync > d__18)), Command("DestroyWildDinos", RunMode = RunMode.Async), RequireRole(SpecialRole.DestroyWildDinos), Summary("Destroys all untamed creatures on the map. Useful for helping newly-released creatures to spawn."), Remarks("DestroyWildDinos MapName")]
        public Task DestroyWildDinosAsync(string serverName)
        {
            < DestroyWildDinosAsync > d__18 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DestroyWildDinosAsync > d__18 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DisallowPlayerToJoinNoCheckAsync > d__19)), Command("DisallowPlayerToJoinNoCheck", RunMode = RunMode.Async), RequireRole(SpecialRole.DisallowPlayerToJoinNoCheck), Summary("Removes the specified player from the server's whitelist."), Remarks("DisallowPlayerToJoinNoCheck steamId")]
        public Task DisallowPlayerToJoinNoCheckAsync(ulong steamId)
        {
            < DisallowPlayerToJoinNoCheckAsync > d__19 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DisallowPlayerToJoinNoCheckAsync > d__19 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DisallowPlayerToJoinNoCheckAsync > d__20)), Command("DisallowPlayerToJoinNoCheck", RunMode = RunMode.Async), RequireRole(SpecialRole.DisallowPlayerToJoinNoCheck), Summary("Removes the specified player from the server's whitelist."), Remarks("DisallowPlayerToJoinNoCheck MapName steamId")]
        public Task DisallowPlayerToJoinNoCheckAsync(string serverName, ulong steamId)
        {
            < DisallowPlayerToJoinNoCheckAsync > d__20 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DisallowPlayerToJoinNoCheckAsync > d__20 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DoExitAsync > d__21)), Command("DoExit", RunMode = RunMode.Async), RequireRole(SpecialRole.DoExit), Summary("Shuts the server down without saving."), Remarks("DoExit")]
        public Task DoExitAsync()
        {
            < DoExitAsync > d__21 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DoExitAsync > d__21 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< DoExitAsync > d__22)), Command("DoExit", RunMode = RunMode.Async), RequireRole(SpecialRole.DoExit), Summary("Shuts the server down without saving."), Remarks("DoExit MapName")]
        public Task DoExitAsync(string serverName)
        {
            < DoExitAsync > d__22 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << DoExitAsync > d__22 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GenericCommandAsync > d__59))]
        private Task GenericCommandAsync(string command)
        {
            < GenericCommandAsync > d__59 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.command = command;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GenericCommandAsync > d__59 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GenericCommandAsync > d__60))]
        private Task GenericCommandAsync(string serverName, string command)
        {
            < GenericCommandAsync > d__60 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.command = command;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GenericCommandAsync > d__60 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GetChatAsync > d__23)), Command("GetChat", RunMode = RunMode.Async), RequireRole(SpecialRole.GetChat), Summary("Returns the latest chat buffer (the same amount that the clients see). Note since the bot already does constanly it may not do anything."), Remarks("GetChat")]
        public Task GetChatAsync()
        {
            < GetChatAsync > d__23 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GetChatAsync > d__23 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GetChatAsync > d__24)), Command("GetChat", RunMode = RunMode.Async), RequireRole(SpecialRole.GetChat), Summary("Returns the latest chat buffer (the same amount that the clients see). Note since the bot already does constanly it may not do anything."), Remarks("GetChat MapName")]
        public Task GetChatAsync(string serverName)
        {
            < GetChatAsync > d__24 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GetChatAsync > d__24 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GiveExpToPlayerAsync > d__27)), Command("GiveExpToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.GiveExpToPlayer), Summary("Gives the specified player the specified amount of experience points."), Remarks("GiveExpToPlayer playerId howMuchXp fromTribeShare preventSharingWithTribe")]
        public Task GiveExpToPlayerAsync(int playerId, float howMuchXp, bool fromTribeShare, bool preventSharingWithTribe)
        {
            < GiveExpToPlayerAsync > d__27 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.playerId = playerId;
            d__.howMuchXp = howMuchXp;
            d__.fromTribeShare = fromTribeShare;
            d__.preventSharingWithTribe = preventSharingWithTribe;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GiveExpToPlayerAsync > d__27 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GiveExpToPlayerAsync > d__28)), Command("GiveExpToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.GiveExpToPlayer), Summary("Gives the specified player the specified amount of experience points."), Remarks("GiveExpToPlayer MapName playerId howMuchXp fromTribeShare preventSharingWithTribe")]
        public Task GiveExpToPlayerAsync(string serverName, int playerId, float howMuchXp, bool fromTribeShare, bool preventSharingWithTribe)
        {
            < GiveExpToPlayerAsync > d__28 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.playerId = playerId;
            d__.howMuchXp = howMuchXp;
            d__.fromTribeShare = fromTribeShare;
            d__.preventSharingWithTribe = preventSharingWithTribe;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GiveExpToPlayerAsync > d__28 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GiveItemNumToPlayerAsync > d__25)), Command("GiveItemNumToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.GiveItemNumToPlayer), Summary("Adds the specified item to the player's inventory (or its blueprint) in the specified quantity and with the specified quality."), Remarks("GiveItemNumToPlayer playerId itemId quantity quality blueprint")]
        public Task GiveItemNumToPlayerAsync(int playerId, int itemId, int quantity, float quality, bool blueprint)
        {
            < GiveItemNumToPlayerAsync > d__25 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.playerId = playerId;
            d__.itemId = itemId;
            d__.quantity = quantity;
            d__.quality = quality;
            d__.blueprint = blueprint;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GiveItemNumToPlayerAsync > d__25 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< GiveItemNumToPlayerAsync > d__26)), Command("GiveItemNumToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.GiveItemNumToPlayer), Summary("Adds the specified item to the player's inventory (or its blueprint) in the specified quantity and with the specified quality."), Remarks("GiveItemNumToPlayer MapName playerId itemId quantity quality blueprint")]
        public Task GiveItemNumToPlayerAsync(string serverName, int playerId, int itemId, int quantity, float quality, bool blueprint)
        {
            < GiveItemNumToPlayerAsync > d__26 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.playerId = playerId;
            d__.itemId = itemId;
            d__.quantity = quantity;
            d__.quality = quality;
            d__.blueprint = blueprint;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << GiveItemNumToPlayerAsync > d__26 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< KickPlayerAsync > d__29)), Command("KickPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.KickPlayer), Summary("Forcibly disconnect the specified player from the server."), Remarks("KickPlayer steamId")]
        public Task KickPlayerAsync(ulong steamId)
        {
            < KickPlayerAsync > d__29 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << KickPlayerAsync > d__29 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< KickPlayerAsync > d__30)), Command("KickPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.KickPlayer), Summary("Forcibly disconnect the specified player from the server."), Remarks("KickPlayer MapName steamId")]
        public Task KickPlayerAsync(string serverName, ulong steamId)
        {
            < KickPlayerAsync > d__30 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << KickPlayerAsync > d__30 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< KillPlayerAsync > d__31)), Command("KillPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.KillPlayer), Summary("Kills the specified player."), Remarks("KillPlayer playerid")]
        public Task KillPlayerAsync(int playerId)
        {
            < KillPlayerAsync > d__31 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.playerId = playerId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << KillPlayerAsync > d__31 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< KillPlayerAsync > d__32)), Command("KillPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.KillPlayer), Summary("Kills the specified player."), Remarks("KillPlayer MapName playerid")]
        public Task KillPlayerAsync(string serverName, int playerId)
        {
            < KillPlayerAsync > d__32 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.playerId = playerId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << KillPlayerAsync > d__32 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ListPlayersAsync > d__33)), Command("ListPlayers", RunMode = RunMode.Async), RequireRole(SpecialRole.ListPlayers), Summary("List all connected players and their Steam IDs."), Remarks("ListPlayers")]
        public Task ListPlayersAsync()
        {
            < ListPlayersAsync > d__33 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ListPlayersAsync > d__33 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ListPlayersAsync > d__34)), Command("ListPlayers", RunMode = RunMode.Async), RequireRole(SpecialRole.ListPlayers), Summary("List all connected players and their Steam IDs."), Remarks("ListPlayers MapName")]
        public Task ListPlayersAsync(string serverName)
        {
            < ListPlayersAsync > d__34 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ListPlayersAsync > d__34 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< PlayersOnlyAsync > d__35)), Command("PlayersOnly", RunMode = RunMode.Async), RequireRole(SpecialRole.PlayersOnly), Summary("Stops all creature movement in the game world and halts crafting. Players can still move normally. Repeat the command to disable its effects."), Remarks("PlayersOnly")]
        public Task PlayersOnlyAsync()
        {
            < PlayersOnlyAsync > d__35 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << PlayersOnlyAsync > d__35 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< PlayersOnlyAsync > d__36)), Command("PlayersOnly", RunMode = RunMode.Async), RequireRole(SpecialRole.PlayersOnly), Summary("Stops all creature movement in the game world and halts crafting. Players can still move normally. Repeat the command to disable its effects."), Remarks("PlayersOnly MapName")]
        public Task PlayersOnlyAsync(string serverName)
        {
            < PlayersOnlyAsync > d__36 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << PlayersOnlyAsync > d__36 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RenamePlayerAsync > d__37)), Command("RenamePlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.RenamePlayer), Summary("Renames the player specified by their in-game string name."), Remarks("RenamePlayer playerName newPlayerName")]
        public Task RenamePlayerAsync(string playerName, string newPlayerName)
        {
            < RenamePlayerAsync > d__37 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.playerName = playerName;
            d__.newPlayerName = newPlayerName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RenamePlayerAsync > d__37 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RenamePlayerAsync > d__38)), Command("RenamePlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.RenamePlayer), Summary("Renames the player specified by their in-game string name."), Remarks("RenamePlayer MapName playerName newPlayerName")]
        public Task RenamePlayerAsync(string serverName, string playerName, string newPlayerName)
        {
            < RenamePlayerAsync > d__38 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.playerName = playerName;
            d__.newPlayerName = newPlayerName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RenamePlayerAsync > d__38 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RenameTribeAsync > d__39)), Command("RenameTribe", RunMode = RunMode.Async), RequireRole(SpecialRole.RenameTribe), Summary("Renames the tribe specified by it's string name."), Remarks("RenameTribe tribeName newTribeName")]
        public Task RenameTribeAsync(string tribeName, string newTribeName)
        {
            < RenameTribeAsync > d__39 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.tribeName = tribeName;
            d__.newTribeName = newTribeName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RenameTribeAsync > d__39 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< RenameTribeAsync > d__40)), Command("RenameTribe", RunMode = RunMode.Async), RequireRole(SpecialRole.RenameTribe), Summary("Renames the tribe specified by it's string name."), Remarks("RenameTribe MapName tribeName newTribeName")]
        public Task RenameTribeAsync(string serverName, string tribeName, string newTribeName)
        {
            < RenameTribeAsync > d__40 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.tribeName = tribeName;
            d__.newTribeName = newTribeName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << RenameTribeAsync > d__40 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SaveWorldAsync > d__41)), Command("SaveWorld", RunMode = RunMode.Async), RequireRole(SpecialRole.SaveWorld), Summary("Forces the server to save the game world to disk in its current state."), Remarks("SaveWorld")]
        public Task SaveWorldAsync()
        {
            < SaveWorldAsync > d__41 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SaveWorldAsync > d__41 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SaveWorldAsync > d__42)), Command("SaveWorld", RunMode = RunMode.Async), RequireRole(SpecialRole.SaveWorld), Summary("Forces the server to save the game world to disk in its current state."), Remarks("SaveWorld MapName")]
        public Task SaveWorldAsync(string serverName)
        {
            < SaveWorldAsync > d__42 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SaveWorldAsync > d__42 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatAsync > d__43)), Command("ServerChat", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChat), Summary("Sends a chat message to all currently connected players."), Remarks("ServerChat message")]
        public Task ServerChatAsync([Remainder] string message)
        {
            < ServerChatAsync > d__43 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatAsync > d__43 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatAsync > d__44)), Command("ServerChat", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChat), Summary("Sends a chat message to all currently connected players."), Remarks("ServerChat MapName message")]
        public Task ServerChatAsync(string serverName, [Remainder] string message)
        {
            < ServerChatAsync > d__44 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatAsync > d__44 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatAsync > d__45)), Command("ServerChatTo", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChatTo), Summary("Sends a direct chat message to the player specified by their int64 encoded steam id."), Remarks("ServerChatTo steamId message")]
        public Task ServerChatAsync(ulong steamId, [Remainder] string message)
        {
            < ServerChatAsync > d__45 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatAsync > d__45 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatAsync > d__46)), Command("ServerChatTo", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChatTo), Summary("Sends a direct chat message to the player specified by their int64 encoded steam id."), Remarks("ServerChatTo MapName steamId message")]
        public Task ServerChatAsync(string serverName, ulong steamId, [Remainder] string message)
        {
            < ServerChatAsync > d__46 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatAsync > d__46 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatToPlayerAsync > d__47)), Command("ServerChatToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChatToPlayer), Summary("Sends a direct chat message to the player specified by their in-game player name."), Remarks("ServerChatToPlayer playerName message")]
        public Task ServerChatToPlayerAsync(string playerName, [Remainder] string message)
        {
            < ServerChatToPlayerAsync > d__47 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.playerName = playerName;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatToPlayerAsync > d__47 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ServerChatToPlayerAsync > d__48)), Command("ServerChatToPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.ServerChatToPlayer), Summary("Sends a direct chat message to the player specified by their in-game player name."), Remarks("ServerChatToPlayer MapName playerName message")]
        public Task ServerChatToPlayerAsync(string serverName, string playerName, [Remainder] string message)
        {
            < ServerChatToPlayerAsync > d__48 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.playerName = playerName;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ServerChatToPlayerAsync > d__48 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SetMessageOfTheDayAsync > d__49)), Command("SetMessageOfTheDay", RunMode = RunMode.Async), RequireRole(SpecialRole.SetMessageOfTheDay), Summary("Sets the server's 'message of the day', displayed to players when they connect to it."), Remarks("SetMessageOfTheDay message")]
        public Task SetMessageOfTheDayAsync([Remainder] string message)
        {
            < SetMessageOfTheDayAsync > d__49 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SetMessageOfTheDayAsync > d__49 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SetMessageOfTheDayAsync > d__50)), Command("SetMessageOfTheDay", RunMode = RunMode.Async), RequireRole(SpecialRole.SetMessageOfTheDay), Summary("Sets the server's 'message of the day', displayed to players when they connect to it."), Remarks("SetMessageOfTheDay MapName message")]
        public Task SetMessageOfTheDayAsync(string serverName, [Remainder] string message)
        {
            < SetMessageOfTheDayAsync > d__50 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.message = message;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SetMessageOfTheDayAsync > d__50 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SetTimeOfDayAsync > d__51)), Command("SetTimeOfDay", RunMode = RunMode.Async), RequireRole(SpecialRole.SetTimeOfDay), Summary("Sets the game world's time of day to the specified time."), Remarks("SetTimeOfDay hour:minute:second")]
        public Task SetTimeOfDayAsync(string time)
        {
            < SetTimeOfDayAsync > d__51 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.time = time;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SetTimeOfDayAsync > d__51 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SetTimeOfDayAsync > d__52)), Command("SetTimeOfDay", RunMode = RunMode.Async), RequireRole(SpecialRole.SetTimeOfDay), Summary("Sets the game world's time of day to the specified time."), Remarks("SetTimeOfDay MapName hour:minute:second")]
        public Task SetTimeOfDayAsync(string serverName, string time)
        {
            < SetTimeOfDayAsync > d__52 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.time = time;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SetTimeOfDayAsync > d__52 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ShowMessageOfTheDayAsync > d__53)), Command("ShowMessageOfTheDay", RunMode = RunMode.Async), RequireRole(SpecialRole.ShowMessageOfTheDay), Summary("Displays the message of the day."), Remarks("ShowMessageOfTheDay")]
        public Task ShowMessageOfTheDayAsync()
        {
            < ShowMessageOfTheDayAsync > d__53 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ShowMessageOfTheDayAsync > d__53 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< ShowMessageOfTheDayAsync > d__54)), Command("ShowMessageOfTheDay", RunMode = RunMode.Async), RequireRole(SpecialRole.ShowMessageOfTheDay), Summary("Displays the message of the day."), Remarks("ShowMessageOfTheDay MapName")]
        public Task ShowMessageOfTheDayAsync(string serverName)
        {
            < ShowMessageOfTheDayAsync > d__54 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << ShowMessageOfTheDayAsync > d__54 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SlomoAsync > d__55)), Command("Slomo", RunMode = RunMode.Async), RequireRole(SpecialRole.Slomo), Summary("Sets the game speed multiplier. Lower values slow time, change back to 1 to set back to normal."), Remarks("Slomo speed")]
        public Task SlomoAsync(float speed)
        {
            < SlomoAsync > d__55 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.speed = speed;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SlomoAsync > d__55 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< SlomoAsync > d__56)), Command("Slomo", RunMode = RunMode.Async), RequireRole(SpecialRole.Slomo), Summary("Sets the game speed multiplier. Lower values slow time, change back to 1 to set back to normal."), Remarks("Slomo speed MapName")]
        public Task SlomoAsync(string serverName, float speed)
        {
            < SlomoAsync > d__56 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.speed = speed;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << SlomoAsync > d__56 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< UnBanPlayerAsync > d__57)), Command("UnBanPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.UnBanPlayer), Summary("Remove the specified player from the server's banned list."), Remarks("UnBanPlayer steamId")]
        public Task UnBanPlayerAsync(ulong steamId)
        {
            < UnBanPlayerAsync > d__57 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << UnBanPlayerAsync > d__57 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [AsyncStateMachine((Type)typeof(< UnBanPlayerAsync > d__58)), Command("UnBanPlayer", RunMode = RunMode.Async), RequireRole(SpecialRole.UnBanPlayer), Summary("Remove the specified player from the server's banned list."), Remarks("UnBanPlayer MapName steamId")]
        public Task UnBanPlayerAsync(string serverName, ulong steamId)
        {
            < UnBanPlayerAsync > d__58 d__;
            d__.<> t__builder = AsyncTaskMethodBuilder.Create();
            d__.<> 4__this = this;
            d__.serverName = serverName;
            d__.steamId = steamId;
            d__.<> 1__state = -1;
            d__.<> t__builder.Start << UnBanPlayerAsync > d__58 > (ref d__);
            return d__.<> t__builder.get_Task();
        }

        [CompilerGenerated]
        private struct <AllowPlayerToJoinNoCheckAsync>d__5 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
        public RconCommandModule<>4__this;
            public ulong steamId;
        private TaskAwaiter<> u__1;

        private void MoveNext()
        {
            int num = this.<> 1__state;
            RconCommandModule module = this.<> 4__this;
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
                    awaiter = module.GenericCommandAsync($"AllowPlayerToJoinNoCheck {(ulong)this.steamId}").GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        goto TR_0004;
                    }
                    else
                    {
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< AllowPlayerToJoinNoCheckAsync > d__5 > (ref awaiter, ref this);
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
    private struct <AllowPlayerToJoinNoCheckAsync>d__6 : IAsyncStateMachine
        {
            public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
    public RconCommandModule<>4__this;
            public string serverName;
    public ulong steamId;
    private TaskAwaiter<> u__1;

    private void MoveNext()
    {
        int num = this.<> 1__state;
        RconCommandModule module = this.<> 4__this;
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
                awaiter = module.GenericCommandAsync(this.serverName, $"AllowPlayerToJoinNoCheck {(ulong)this.steamId}").GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_0004;
                }
                else
                {
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< AllowPlayerToJoinNoCheckAsync > d__6 > (ref awaiter, ref this);
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
private struct <BanPlayerAsync>d__7: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"BanPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BanPlayerAsync > d__7 > (ref awaiter, ref this);
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
private struct <BanPlayerAsync>d__8: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"BanPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BanPlayerAsync > d__8 > (ref awaiter, ref this);
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
private struct <BlankRconAsync>d__3: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string command;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            string command = this.command;
            if (this.command == null)
            {
                string local1 = this.command;
                command = "";
            }
            awaiter = module.GenericCommandAsync(command).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BlankRconAsync > d__3 > (ref awaiter, ref this);
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
private struct <BlankRconAsync>d__4: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string command;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            string command = this.command;
            if (this.command == null)
            {
                string local1 = this.command;
                command = "";
            }
            awaiter = module.GenericCommandAsync(this.serverName, command).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BlankRconAsync > d__4 > (ref awaiter, ref this);
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
private struct <BroadcastAsync>d__10: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "Broadcast " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BroadcastAsync > d__10 > (ref awaiter, ref this);
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
private struct <BroadcastAsync>d__9: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("Broadcast " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< BroadcastAsync > d__9 > (ref awaiter, ref this);
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
private struct <DestroyAllAsync>d__11: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string className;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("DestroyAll " + this.className).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyAllAsync > d__11 > (ref awaiter, ref this);
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
private struct <DestroyAllAsync>d__12: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string className;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "DestroyAll " + this.className).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyAllAsync > d__12 > (ref awaiter, ref this);
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
private struct <DestroyAllEnemiesAsync>d__13: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("DestroyAllEnemies").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyAllEnemiesAsync > d__13 > (ref awaiter, ref this);
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
private struct <DestroyAllEnemiesAsync>d__14: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "DestroyAllEnemies").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyAllEnemiesAsync > d__14 > (ref awaiter, ref this);
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
private struct <DestroyStructuresAsync>d__15: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("DestroyStructures").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyStructuresAsync > d__15 > (ref awaiter, ref this);
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
private struct <DestroyStructuresAsync>d__16: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "DestroyStructures").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyStructuresAsync > d__16 > (ref awaiter, ref this);
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
private struct <DestroyWildDinosAsync>d__17: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("DestroyWildDinos").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyWildDinosAsync > d__17 > (ref awaiter, ref this);
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
private struct <DestroyWildDinosAsync>d__18: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "DestroyWildDinos").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DestroyWildDinosAsync > d__18 > (ref awaiter, ref this);
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
private struct <DisallowPlayerToJoinNoCheckAsync>d__19: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"DisallowPlayerToJoinNoCheck {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DisallowPlayerToJoinNoCheckAsync > d__19 > (ref awaiter, ref this);
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
private struct <DisallowPlayerToJoinNoCheckAsync>d__20: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"DisallowPlayerToJoinNoCheck {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DisallowPlayerToJoinNoCheckAsync > d__20 > (ref awaiter, ref this);
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
private struct <DoExitAsync>d__21: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("DoExit").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DoExitAsync > d__21 > (ref awaiter, ref this);
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
private struct <DoExitAsync>d__22: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "DoExit").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< DoExitAsync > d__22 > (ref awaiter, ref this);
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
private struct <GenericCommandAsync>d__59: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string command;
private int < number > 5__2;
private TaskAwaiter<IUserMessage> <> u__1;
private TaskAwaiter<SocketMessage> <> u__2;
private string < reply > 5__3;
private TaskAwaiter<string> <> u__3;
private IEnumerator<KeyValuePair<string, ServerItem>> <> 7__wrap3;
private KeyValuePair<string, ServerItem> < server > 5__5;
private TaskAwaiter<> u__4;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
    try
    {
        SocketMessage message2;
        int num3;
        TaskAwaiter<IUserMessage> awaiter;
        TaskAwaiter<SocketMessage> awaiter2;
        string result;
        TaskAwaiter<string> awaiter3;
        switch (num)
        {
            case 0:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                break;

            case 1:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter<SocketMessage>();
                this.<> 1__state = num = -1;
                goto TR_0055;

            case 2:
            case 3:
            case 4:
            case 5:
                goto TR_001C;

            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                goto TR_004A;

            case 11:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_001E;

            case 12:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_004C;

            case 13:
                awaiter = this.<> u__1;
                this.<> u__1 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_0050;

            default:
                {
                    this.< number > 5__2 = 0;
                    int num2 = 10;
                    List<string> list = new List<string>();
                    int num4 = 0;
                    while (true)
                    {
                        if (num4 < module._settings.ServerDictionary.Count)
                        {
                            string item = string.Empty;
                            IEnumerator<string> enumerator = Enumerable.Take<string>(Enumerable.Skip<string>((IEnumerable<string>)module._settings.ServerDictionary.get_Keys(), num4), num2).GetEnumerator();
                            try
                            {
                                while (enumerator.MoveNext())
                                {
                                    string current = enumerator.Current;
                                    object[] objArray1 = new object[] { module._settings.ReplyWithNumberStart, (int)this.< number > 5__2, module._settings.ReplyWithNumberEnd, current };
                                    item = item + string.Format("{0} {1} {2} {3} \n", (object[])objArray1);
                                    int num5 = this.< number > 5__2;
                                    this.< number > 5__2 = num5 + 1;
                                }
                            }
                            finally
                            {
                                if ((num < 0) && (enumerator != null))
                                {
                                    enumerator.Dispose();
                                }
                            }
                            list.Add(item);
                            num4 += num2;
                            continue;
                        }
                        PaginatedMessage message1 = new PaginatedMessage();
                        message1.Color = new Color(0x72, 0x89, 0xda);
                        message1.Title = module._settings.PickAServer;
                        message1.set_Pages((IEnumerable<object>)list);
                        awaiter = module.PagedReplyAsync(message1, true).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            break;
                        }
                        this.<> 1__state = num = 0;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                        return;
                    }
                    break;
                }
        }
        awaiter.GetResult();
        TimeSpan? nullable = null;
        CancellationToken token = new CancellationToken();
        awaiter2 = module.NextMessageAsync(true, true, nullable, token).GetAwaiter();
        if (!awaiter2.IsCompleted)
        {
            this.<> 1__state = num = 1;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<SocketMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter2, ref this);
            return;
        }
        goto TR_0055;
    TR_001C:
        try
        {
            switch (num)
            {
                case 2:
                    awaiter3 = this.<> u__3;
                    this.<> u__3 = new TaskAwaiter<string>();
                    this.<> 1__state = num = -1;
                    break;

                case 3:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0011;

                case 4:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000E;

                case 5:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000A;

                default:
                    awaiter3 = Enumerable.ElementAt<ServerItem>((IEnumerable<ServerItem>)module._settings.ServerDictionary.get_Values(), num3).Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                    if (awaiter3.IsCompleted)
                    {
                        break;
                    }
                    this.<> 1__state = num = 2;
                    this.<> u__3 = awaiter3;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter3, ref this);
                    return;
            }
            result = awaiter3.GetResult();
            this.< reply > 5__3 = result;
            awaiter = module.ReplyAsync(module._settings.CommandSent, false, null, null).GetAwaiter();
            if (!awaiter.IsCompleted)
            {
                this.<> 1__state = num = 3;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                return;
            }
            goto TR_0011;
        TR_0009:
            this.< reply > 5__3 = null;
            goto TR_0004;
        TR_000A:
            awaiter.GetResult();
            goto TR_0009;
        TR_000D:
            if (this.< reply > 5__3 != null)
            {
                goto TR_0009;
            }
            else
            {
                awaiter = module.ReplyAsync(module._settings.NoReplyData, false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_000A;
                }
                else
                {
                    this.<> 1__state = num = 5;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                }
            }
            return;
        TR_000E:
            awaiter.GetResult();
            goto TR_000D;
        TR_0011:
            awaiter.GetResult();
            if (this.< reply > 5__3 == null)
            {
                goto TR_000D;
            }
            else
            {
                awaiter = module.ReplyAsync(this.< reply > 5__3, false, null, null).GetAwaiter();
                if (awaiter.IsCompleted)
                {
                    goto TR_000E;
                }
                else
                {
                    this.<> 1__state = num = 4;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                }
            }
        }
        catch (Exception)
        {
        }
        return;
    TR_001E:
        awaiter.GetResult();
        goto TR_0004;
    TR_001F:
        awaiter = module.ReplyAsync(module._settings.AllCommandsSent, false, null, null).GetAwaiter();
        if (awaiter.IsCompleted)
        {
            goto TR_001E;
        }
        else
        {
            this.<> 1__state = num = 11;
            this.<> u__1 = awaiter;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
        }
        return;
    TR_004A:
        try
        {
            if ((num - 6) > 4)
            {
                this.<> 7__wrap3 = module._settings.ServerDictionary.GetEnumerator();
            }
            try
            {
                TaskAwaiter awaiter4;
                if ((num - 6) > 3)
                {
                    if (num == 10)
                    {
                        awaiter4 = this.<> u__4;
                        this.<> u__4 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                    }
                    else
                    {
                        goto TR_0043;
                    }
                }
                else
                {
                    goto TR_0040;
                }
            TR_002A:
                awaiter4.GetResult();
                this.< server > 5__5 = new KeyValuePair<string, ServerItem>();
                goto TR_0043;
            TR_002B:
                awaiter4 = Task.Delay(0x3e8).GetAwaiter();
                if (awaiter4.IsCompleted)
                {
                    goto TR_002A;
                }
                else
                {
                    this.<> 1__state = num = 10;
                    this.<> u__4 = awaiter4;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter4, ref this);
                }
                return;
            TR_0040:
                try
                {
                    switch (num)
                    {
                        case 6:
                            awaiter3 = this.<> u__3;
                            this.<> u__3 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            break;

                        case 7:
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_0035;

                        case 8:
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_0032;

                        case 9:
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_002E;

                        default:
                            awaiter3 = this.< server > 5__5.Value.Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                            if (awaiter3.IsCompleted)
                            {
                                break;
                            }
                            this.<> 1__state = num = 6;
                            this.<> u__3 = awaiter3;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter3, ref this);
                            return;
                    }
                    result = awaiter3.GetResult();
                    this.< reply > 5__3 = result;
                    awaiter = module.ReplyAsync(module._settings.CommandSentTo + " " + this.< server > 5__5.Key, false, null, null).GetAwaiter();
                    if (!awaiter.IsCompleted)
                    {
                        this.<> 1__state = num = 7;
                        this.<> u__1 = awaiter;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                        return;
                    }
                    goto TR_0035;
                TR_002D:
                    this.< reply > 5__3 = null;
                    goto TR_002B;
                TR_002E:
                    awaiter.GetResult();
                    goto TR_002D;
                TR_0031:
                    if (this.< reply > 5__3 != null)
                    {
                        goto TR_002D;
                    }
                    else
                    {
                        awaiter = module.ReplyAsync(module._settings.NoReplyData, false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_002E;
                        }
                        else
                        {
                            this.<> 1__state = num = 9;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                        }
                    }
                    return;
                TR_0032:
                    awaiter.GetResult();
                    goto TR_0031;
                TR_0035:
                    awaiter.GetResult();
                    if (this.< reply > 5__3 == null)
                    {
                        goto TR_0031;
                    }
                    else
                    {
                        awaiter = module.ReplyAsync(this.< reply > 5__3, false, null, null).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto TR_0032;
                        }
                        else
                        {
                            this.<> 1__state = num = 8;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
                        }
                    }
                }
                catch (Exception)
                {
                    goto TR_0043;
                }
                return;
            TR_0043:
                while (true)
                {
                    if (this.<> 7__wrap3.MoveNext())
                                {
    this.< server > 5__5 = this.<> 7__wrap3.Current;
}
                                else
{
    goto TR_0024;
}
break;
                            }
                            goto TR_0040;
                        }
                        finally
{
    if ((num < 0) && (this.<> 7__wrap3 != null))
                            {
        this.<> 7__wrap3.Dispose();
    }
}
goto TR_001F;
TR_0024:
this.<> 7__wrap3 = null;
                    }
                    catch (Exception)
{
}
goto TR_001F;
TR_004C:
awaiter.GetResult();
goto TR_0004;
TR_0050:
awaiter.GetResult();
goto TR_0004;
TR_0055:
message2 = awaiter2.GetResult();
if (!int.TryParse(message2?.Content, out num3) || ((num3 < 0) || (num3 > (this.< number > 5__2 - 1))))
{
    if ((message2 == null) || (message2.Content.ToLower() != module._settings.PickAllServers.ToLower()))
    {
        if (message2 == null)
        {
            awaiter = module.ReplyAsync(module._settings.NoSelectionTimeout, false, null, null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0050;
            }
            else
            {
                this.<> 1__state = num = 13;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
            }
        }
        else
        {
            awaiter = module.ReplyAsync(module._settings.NoServerSelected, false, null, null).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_004C;
            }
            else
            {
                this.<> 1__state = num = 12;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__59 > (ref awaiter, ref this);
            }
        }
    }
    else
    {
        goto TR_004A;
    }
}
else
{
    goto TR_001C;
}
                }
                catch (Exception exception)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetException(exception);
}
return;
TR_0004:
this.<> 1__state = -2;
this.<> t__builder.SetResult();
            }

            [DebuggerHidden]
private void SetStateMachine(IAsyncStateMachine stateMachine)
{
    this.<> t__builder.SetStateMachine(stateMachine);
}
        }

        [CompilerGenerated]
private struct <GenericCommandAsync>d__60: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string command;
private string < reply > 5__2;
private TaskAwaiter<string> <> u__1;
private TaskAwaiter<IUserMessage> <> u__2;
private IEnumerator<KeyValuePair<string, ServerItem>> <> 7__wrap2;
private KeyValuePair<string, ServerItem> < serverItem > 5__4;
private TaskAwaiter<> u__3;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
    try
    {
        string result;
        TaskAwaiter<string> awaiter;
        TaskAwaiter<IUserMessage> awaiter2;
        switch (num)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                goto TR_001A;

            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
                goto TR_0048;

            case 9:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_001C;

            case 10:
                awaiter2 = this.<> u__2;
                this.<> u__2 = new TaskAwaiter<IUserMessage>();
                this.<> 1__state = num = -1;
                goto TR_004A;

            default:
                if (!module._settings.ServerDictionary.ContainsKey(this.serverName.Trim()))
                {
                    if (this.serverName.ToLower() != module._settings.PickAllServers.ToLower())
                    {
                        awaiter2 = module.ReplyAsync(module._settings.WrongServerName, false, null, null).GetAwaiter();
                        if (awaiter2.IsCompleted)
                        {
                            goto TR_004A;
                        }
                        else
                        {
                            this.<> 1__state = num = 10;
                            this.<> u__2 = awaiter2;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                        }
                    }
                    else
                    {
                        goto TR_0048;
                    }
                    break;
                }
                goto TR_001A;
        }
        return;
    TR_001A:
        try
        {
            switch (num)
            {
                case 0:
                    awaiter = this.<> u__1;
                    this.<> u__1 = new TaskAwaiter<string>();
                    this.<> 1__state = num = -1;
                    break;

                case 1:
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000F;

                case 2:
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_000C;

                case 3:
                    awaiter2 = this.<> u__2;
                    this.<> u__2 = new TaskAwaiter<IUserMessage>();
                    this.<> 1__state = num = -1;
                    goto TR_0008;

                default:
                    ServerItem item;
                    module._settings.ServerDictionary.TryGetValue(this.serverName, out item);
                    awaiter = item.Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                    if (awaiter.IsCompleted)
                    {
                        break;
                    }
                    this.<> 1__state = num = 0;
                    this.<> u__1 = awaiter;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter, ref this);
                    return;
            }
            result = awaiter.GetResult();
            this.< reply > 5__2 = result;
            awaiter2 = module.ReplyAsync(module._settings.CommandSent, false, null, null).GetAwaiter();
            if (!awaiter2.IsCompleted)
            {
                this.<> 1__state = num = 1;
                this.<> u__2 = awaiter2;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                return;
            }
            goto TR_000F;
        TR_0007:
            this.< reply > 5__2 = null;
            goto TR_0002;
        TR_0008:
            awaiter2.GetResult();
            goto TR_0007;
        TR_000B:
            if (this.< reply > 5__2 != null)
            {
                goto TR_0007;
            }
            else
            {
                awaiter2 = module.ReplyAsync(module._settings.NoReplyData, false, null, null).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                    goto TR_0008;
                }
                else
                {
                    this.<> 1__state = num = 3;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                }
            }
            return;
        TR_000C:
            awaiter2.GetResult();
            goto TR_000B;
        TR_000F:
            awaiter2.GetResult();
            if (this.< reply > 5__2 == null)
            {
                goto TR_000B;
            }
            else
            {
                awaiter2 = module.ReplyAsync(this.< reply > 5__2, false, null, null).GetAwaiter();
                if (awaiter2.IsCompleted)
                {
                    goto TR_000C;
                }
                else
                {
                    this.<> 1__state = num = 2;
                    this.<> u__2 = awaiter2;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                }
            }
        }
        catch (Exception)
        {
        }
        return;
    TR_001C:
        awaiter2.GetResult();
        goto TR_0002;
    TR_001D:
        awaiter2 = module.ReplyAsync(module._settings.AllCommandsSent, false, null, null).GetAwaiter();
        if (awaiter2.IsCompleted)
        {
            goto TR_001C;
        }
        else
        {
            this.<> 1__state = num = 9;
            this.<> u__2 = awaiter2;
            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
        }
        return;
    TR_0048:
        try
        {
            if ((num - 4) > 4)
            {
                this.<> 7__wrap2 = module._settings.ServerDictionary.GetEnumerator();
            }
            try
            {
                TaskAwaiter awaiter3;
                if ((num - 4) > 3)
                {
                    if (num == 8)
                    {
                        awaiter3 = this.<> u__3;
                        this.<> u__3 = new TaskAwaiter();
                        this.<> 1__state = num = -1;
                    }
                    else
                    {
                        goto TR_0041;
                    }
                }
                else
                {
                    goto TR_003E;
                }
            TR_0028:
                awaiter3.GetResult();
                this.< serverItem > 5__4 = new KeyValuePair<string, ServerItem>();
                goto TR_0041;
            TR_0029:
                awaiter3 = Task.Delay(0x3e8).GetAwaiter();
                if (awaiter3.IsCompleted)
                {
                    goto TR_0028;
                }
                else
                {
                    this.<> 1__state = num = 8;
                    this.<> u__3 = awaiter3;
                    this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter3, ref this);
                }
                return;
            TR_003E:
                try
                {
                    switch (num)
                    {
                        case 4:
                            awaiter = this.<> u__1;
                            this.<> u__1 = new TaskAwaiter<string>();
                            this.<> 1__state = num = -1;
                            break;

                        case 5:
                            awaiter2 = this.<> u__2;
                            this.<> u__2 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_0033;

                        case 6:
                            awaiter2 = this.<> u__2;
                            this.<> u__2 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_0030;

                        case 7:
                            awaiter2 = this.<> u__2;
                            this.<> u__2 = new TaskAwaiter<IUserMessage>();
                            this.<> 1__state = num = -1;
                            goto TR_002C;

                        default:
                            awaiter = this.< serverItem > 5__4.Value.Server.Rcon.SendCommandAsync(this.command).GetAwaiter();
                            if (awaiter.IsCompleted)
                            {
                                break;
                            }
                            this.<> 1__state = num = 4;
                            this.<> u__1 = awaiter;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<string>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter, ref this);
                            return;
                    }
                    result = awaiter.GetResult();
                    this.< reply > 5__2 = result;
                    awaiter2 = module.ReplyAsync(module._settings.CommandSentTo + " " + this.< serverItem > 5__4.Key, false, null, null).GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                        this.<> 1__state = num = 5;
                        this.<> u__2 = awaiter2;
                        this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                        return;
                    }
                    goto TR_0033;
                TR_002B:
                    this.< reply > 5__2 = null;
                    goto TR_0029;
                TR_002C:
                    awaiter2.GetResult();
                    goto TR_002B;
                TR_002F:
                    if (this.< reply > 5__2 != null)
                    {
                        goto TR_002B;
                    }
                    else
                    {
                        awaiter2 = module.ReplyAsync(module._settings.NoReplyData, false, null, null).GetAwaiter();
                        if (awaiter2.IsCompleted)
                        {
                            goto TR_002C;
                        }
                        else
                        {
                            this.<> 1__state = num = 7;
                            this.<> u__2 = awaiter2;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                        }
                    }
                    return;
                TR_0030:
                    awaiter2.GetResult();
                    goto TR_002F;
                TR_0033:
                    awaiter2.GetResult();
                    if (this.< reply > 5__2 == null)
                    {
                        goto TR_002F;
                    }
                    else
                    {
                        awaiter2 = module.ReplyAsync(this.< reply > 5__2, false, null, null).GetAwaiter();
                        if (awaiter2.IsCompleted)
                        {
                            goto TR_0030;
                        }
                        else
                        {
                            this.<> 1__state = num = 6;
                            this.<> u__2 = awaiter2;
                            this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter<IUserMessage>, RconCommandModule.< GenericCommandAsync > d__60 > (ref awaiter2, ref this);
                        }
                    }
                }
                catch (Exception)
                {
                    goto TR_0041;
                }
                return;
            TR_0041:
                while (true)
                {
                    if (this.<> 7__wrap2.MoveNext())
                                {
    this.< serverItem > 5__4 = this.<> 7__wrap2.Current;
}
                                else
{
    goto TR_0022;
}
break;
                            }
                            goto TR_003E;
                        }
                        finally
{
    if ((num < 0) && (this.<> 7__wrap2 != null))
                            {
        this.<> 7__wrap2.Dispose();
    }
}
goto TR_001D;
TR_0022:
this.<> 7__wrap2 = null;
                    }
                    catch (Exception)
{
}
goto TR_001D;
TR_004A:
awaiter2.GetResult();
goto TR_0002;
                }
                catch (Exception exception)
{
    this.<> 1__state = -2;
    this.<> t__builder.SetException(exception);
}
return;
TR_0002:
this.<> 1__state = -2;
this.<> t__builder.SetResult();
            }

            [DebuggerHidden]
private void SetStateMachine(IAsyncStateMachine stateMachine)
{
    this.<> t__builder.SetStateMachine(stateMachine);
}
        }

        [CompilerGenerated]
private struct <GetChatAsync>d__23: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("GetChat").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GetChatAsync > d__23 > (ref awaiter, ref this);
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
private struct <GetChatAsync>d__24: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "GetChat").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GetChatAsync > d__24 > (ref awaiter, ref this);
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
private struct <GiveExpToPlayerAsync>d__27: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public int playerId;
public float howMuchXp;
public bool fromTribeShare;
public bool preventSharingWithTribe;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            object[] objArray1 = new object[] { (int)this.playerId, (float)this.howMuchXp, (bool)this.fromTribeShare, (bool)this.preventSharingWithTribe };
            awaiter = module.GenericCommandAsync(string.Format("GiveExpToPlayer {0} {1} {2} {3}", (object[])objArray1)).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GiveExpToPlayerAsync > d__27 > (ref awaiter, ref this);
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
private struct <GiveExpToPlayerAsync>d__28: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public int playerId;
public float howMuchXp;
public bool fromTribeShare;
public bool preventSharingWithTribe;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            object[] objArray1 = new object[] { (int)this.playerId, (float)this.howMuchXp, (bool)this.fromTribeShare, (bool)this.preventSharingWithTribe };
            awaiter = module.GenericCommandAsync(this.serverName, string.Format("GiveExpToPlayer {0} {1} {2} {3}", (object[])objArray1)).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GiveExpToPlayerAsync > d__28 > (ref awaiter, ref this);
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
private struct <GiveItemNumToPlayerAsync>d__25: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public int playerId;
public int itemId;
public int quantity;
public float quality;
public bool blueprint;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            object[] objArray1 = new object[] { (int)this.playerId, (int)this.itemId, (int)this.quantity, (float)this.quality, (bool)this.blueprint };
            awaiter = module.GenericCommandAsync(string.Format("GiveItemNumToPlayer {0} {1} {2} {3} {4}", (object[])objArray1)).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GiveItemNumToPlayerAsync > d__25 > (ref awaiter, ref this);
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
private struct <GiveItemNumToPlayerAsync>d__26: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public int playerId;
public int itemId;
public int quantity;
public float quality;
public bool blueprint;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            object[] objArray1 = new object[] { (int)this.playerId, (int)this.itemId, (int)this.quantity, (float)this.quality, (bool)this.blueprint };
            awaiter = module.GenericCommandAsync(this.serverName, string.Format("GiveItemNumToPlayer {0} {1} {2} {3} {4}", (object[])objArray1)).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< GiveItemNumToPlayerAsync > d__26 > (ref awaiter, ref this);
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
private struct <KickPlayerAsync>d__29: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"KickPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< KickPlayerAsync > d__29 > (ref awaiter, ref this);
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
private struct <KickPlayerAsync>d__30: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"KickPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< KickPlayerAsync > d__30 > (ref awaiter, ref this);
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
private struct <KillPlayerAsync>d__31: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public int playerId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"KillPlayer {(int)this.playerId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< KillPlayerAsync > d__31 > (ref awaiter, ref this);
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
private struct <KillPlayerAsync>d__32: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public int playerId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"KillPlayer {(int)this.playerId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< KillPlayerAsync > d__32 > (ref awaiter, ref this);
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
private struct <ListPlayersAsync>d__33: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("ListPlayers").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ListPlayersAsync > d__33 > (ref awaiter, ref this);
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
private struct <ListPlayersAsync>d__34: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "ListPlayers").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ListPlayersAsync > d__34 > (ref awaiter, ref this);
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
private struct <PlayersOnlyAsync>d__35: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("PlayersOnly").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< PlayersOnlyAsync > d__35 > (ref awaiter, ref this);
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
private struct <PlayersOnlyAsync>d__36: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "PlayersOnly").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< PlayersOnlyAsync > d__36 > (ref awaiter, ref this);
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
private struct <RenamePlayerAsync>d__37: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string playerName;
public string newPlayerName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("RenamePlayer " + this.playerName + " " + this.newPlayerName).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< RenamePlayerAsync > d__37 > (ref awaiter, ref this);
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
private struct <RenamePlayerAsync>d__38: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string playerName;
public string newPlayerName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "RenamePlayer " + this.playerName + " " + this.newPlayerName).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< RenamePlayerAsync > d__38 > (ref awaiter, ref this);
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
private struct <RenameTribeAsync>d__39: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string tribeName;
public string newTribeName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("RenameTribe " + this.tribeName + " " + this.newTribeName).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< RenameTribeAsync > d__39 > (ref awaiter, ref this);
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
private struct <RenameTribeAsync>d__40: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string tribeName;
public string newTribeName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "RenameTribe " + this.tribeName + " " + this.newTribeName).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< RenameTribeAsync > d__40 > (ref awaiter, ref this);
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
private struct <SaveWorldAsync>d__41: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("SaveWorld").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SaveWorldAsync > d__41 > (ref awaiter, ref this);
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
private struct <SaveWorldAsync>d__42: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "SaveWorld").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SaveWorldAsync > d__42 > (ref awaiter, ref this);
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
private struct <ServerChatAsync>d__43: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("ServerChat " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatAsync > d__43 > (ref awaiter, ref this);
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
private struct <ServerChatAsync>d__44: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "ServerChat " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatAsync > d__44 > (ref awaiter, ref this);
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
private struct <ServerChatAsync>d__45: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public ulong steamId;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"ServerChatTo {(ulong)this.steamId} {this.message.Trim()}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatAsync > d__45 > (ref awaiter, ref this);
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
private struct <ServerChatAsync>d__46: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public ulong steamId;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"ServerChatTo {(ulong)this.steamId} {this.message.Trim()}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatAsync > d__46 > (ref awaiter, ref this);
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
private struct <ServerChatToPlayerAsync>d__47: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string playerName;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("ServerChatToPlayer " + this.playerName + " " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatToPlayerAsync > d__47 > (ref awaiter, ref this);
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
private struct <ServerChatToPlayerAsync>d__48: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string playerName;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "ServerChatToPlayer " + this.playerName + " " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ServerChatToPlayerAsync > d__48 > (ref awaiter, ref this);
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
private struct <SetMessageOfTheDayAsync>d__49: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("SetMessageOfTheDay " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SetMessageOfTheDayAsync > d__49 > (ref awaiter, ref this);
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
private struct <SetMessageOfTheDayAsync>d__50: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string message;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "SetMessageOfTheDay " + this.message.Trim()).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SetMessageOfTheDayAsync > d__50 > (ref awaiter, ref this);
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
private struct <SetTimeOfDayAsync>d__51: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string time;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("SetTimeOfDay " + this.time).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SetTimeOfDayAsync > d__51 > (ref awaiter, ref this);
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
private struct <SetTimeOfDayAsync>d__52: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public string time;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "SetTimeOfDay " + this.time).GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SetTimeOfDayAsync > d__52 > (ref awaiter, ref this);
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
private struct <ShowMessageOfTheDayAsync>d__53: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync("ShowMessageOfTheDay").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ShowMessageOfTheDayAsync > d__53 > (ref awaiter, ref this);
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
private struct <ShowMessageOfTheDayAsync>d__54: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, "ShowMessageOfTheDay").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< ShowMessageOfTheDayAsync > d__54 > (ref awaiter, ref this);
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
private struct <SlomoAsync>d__55: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public float speed;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"Slomo {(float)this.speed}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SlomoAsync > d__55 > (ref awaiter, ref this);
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
private struct <SlomoAsync>d__56: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public float speed;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"Slomo {(float)this.speed}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< SlomoAsync > d__56 > (ref awaiter, ref this);
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
private struct <UnBanPlayerAsync>d__57: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync($"UnBanPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< UnBanPlayerAsync > d__57 > (ref awaiter, ref this);
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
private struct <UnBanPlayerAsync>d__58: IAsyncStateMachine
        {
    public int <>1__state;
            public AsyncTaskMethodBuilder<> t__builder;
public RconCommandModule<> 4__this;
public string serverName;
public ulong steamId;
private TaskAwaiter<> u__1;

private void MoveNext()
{
    int num = this.<> 1__state;
    RconCommandModule module = this.<> 4__this;
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
            awaiter = module.GenericCommandAsync(this.serverName, $"UnBanPlayer {(ulong)this.steamId}").GetAwaiter();
            if (awaiter.IsCompleted)
            {
                goto TR_0004;
            }
            else
            {
                this.<> 1__state = num = 0;
                this.<> u__1 = awaiter;
                this.<> t__builder.AwaitUnsafeOnCompleted < TaskAwaiter, RconCommandModule.< UnBanPlayerAsync > d__58 > (ref awaiter, ref this);
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

