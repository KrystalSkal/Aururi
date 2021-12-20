using System.Linq;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;
using Terraria;

namespace Aururi.Items
{
    public class Hope : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The power and protection of heaven is granted to you for a reason...");
        }


        public override void SetDefaults()
        {
            item.damage = 72;
            item.melee = true;

            item.buffType = 58;
            item.buffTime = 6000;

            item.accessory = true;
            item.defense = 14;
            item.pick = 70;
            item.axe = 55;
            item.width = 48;
            item.height = 48;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 30000;
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 25;        
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 5 * 1000);
            target.AddBuff(BuffID.CursedInferno, 5 * 1000);
            target.AddBuff(BuffID.Frostburn, 5 * 1000);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Bone, 600);
            recipe.AddIngredient(ItemID.AncientNecroHelmet, 1);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddIngredient(ItemID.GoldenKey, 5);            

            recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}