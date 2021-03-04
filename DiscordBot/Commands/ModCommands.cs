using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace DiscordBotTutorial.Bots.Commands
{
    public class ModCommands : BaseCommandModule
    {
        [Command("kick")]
        [Description("Warns")]
        public async Task Kick(CommandContext ctx)
        {
            //await ctx.Channel
        }

    }
}
