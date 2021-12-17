using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Aururi
{
    public class Aururi : Mod
    {
        public Aururi()
            {
                Properties = new ModProperties()
                {
                    Autoload = true,
                    AutoloadGores = true,
                    AutoloadSounds = true
                };
            }

            public class globalNPC : GlobalNPC
            {
                public static float multiplier = 1f;

                public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
                {
                    spawnRate = (int)(spawnRate / multiplier);
                    maxSpawns = (int)(maxSpawns * multiplier);
                }
            }

            public class setCommand : ModCommand
            {

                public override CommandType Type
                {
                    get { return CommandType.Chat; }
                }

                public override string Command
                {
                    get { return "Rate"; }
                }

                public override string Usage
                {
                    get { return "/Rate <number>"; }
                }

                public override string Description
                {
                    get { return "Set current spawn rate multiplier"; }
                }

                public override void Action(CommandCaller caller, string input, string[] args)
                {
                    if (args != null && args[0].Length > 0)
                    {
                        float newMultiplier;
                        if (float.TryParse(args[0], out newMultiplier))
                        {
                            globalNPC.multiplier = newMultiplier;
                            caller.Reply("Current spawn rate " + newMultiplier, Color.Yellow);
                        }
                    }
                }
            }
        }
    }