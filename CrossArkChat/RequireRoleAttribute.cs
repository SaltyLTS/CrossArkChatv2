namespace CrossArkChat
{
    using CrossArkChat.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    public class RequireRoleAttribute : RequireContextAttribute
    {
        private readonly SpecialRole _role;

        public RequireRoleAttribute(SpecialRole role) : base(ContextType.Guild)
        {
            this._role = role;
        }

        public override Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            string rolenameFromSpecialRole = (services.GetService(typeof(DiscordRoleSettings)) as DiscordRoleSettings)?.GetRolenameFromSpecialRole(this._role);
            string text1 = rolenameFromSpecialRole;
            if (rolenameFromSpecialRole == null)
            {
                string local2 = rolenameFromSpecialRole;
                text1 = "";
            }
            string rolename = text1;
            Func<IRole, ulong> func1 = <> c.<> 9__2_1;
            if (<> c.<> 9__2_1 == null)
            {
                Func<IRole, ulong> local3 = <> c.<> 9__2_1;
                func1 = <> c.<> 9__2_1 = delegate (IRole role)
                {
                    return role.Id;
                };
            }
            IEnumerable<ulong> enumerable = Enumerable.Select<IRole, ulong>(from role in (IEnumerable<IRole>)context.Guild.get_Roles() select role, func1);
            return (Enumerable.Any<ulong>(Enumerable.Intersect<ulong>((IEnumerable<ulong>)(context.User as IGuildUser).get_RoleIds(), enumerable)) ? Task.FromResult<PreconditionResult>(PreconditionResult.FromSuccess()) : Task.FromResult<PreconditionResult>(PreconditionResult.FromError("You do not have a role required to execute this command.")));
        }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly RequireRoleAttribute.<>c<>9 = new RequireRoleAttribute.<>c();
        public static Func<IRole, ulong> <>9__2_1;

            internal ulong <CheckPermissionsAsync>b__2_1(IRole role) =>
                role.Id;
    }
}
}

