using System;

using System.Threading;

namespace MCGalaxy.Commands.Misc {

	public class CmdMV : Command

{

        public override string name { get { return "MellifluousVengeance"; } }

        public override string shortcut { get { return "mvenge"; } }

        public override string type { get { return CommandTypes.Other; } }
        
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
		
		public override CommandAlias[] Aliases { get { return new[] { new CommandAlias("mellyvelly"), new CommandAlias("mv") }; } }


	public override void Use(Player p, string message)

	{
		bool messageEmpty = string.IsNullOrEmpty(message);
		Command.Find("say").Use(MCGalaxy.Player.Console, "&9THIS CALLS FOR A MELLIFLUOUS VENGEANCE!!!");
        Command.Find("say").Use(MCGalaxy.Player.Console, "&fhttps://www.youtube.com/watch?v=HUulEOotqvw");
		Command.Find("say").Use(MCGalaxy.Player.Console, "(from " + p.truename + ")");
        if (!messageEmpty) {
        	Command.Find("say").Use(MCGalaxy.Player.Console, "&7-------------------");
            Command.Find("say").Use(MCGalaxy.Player.Console, "&7" + p.truename + " says: " + message);
        }
	}

	public override void Help(Player p)

	{

		p.Message("/MellifluousVengeance (message) - &9THIS CALLS FOR A MELLIFLUOUS VENGEANCE!!!");
        p.Message("&7-- cmd made by Vivian3 --");

	}

}
}
