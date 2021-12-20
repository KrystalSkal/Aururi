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
    public class Failyre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You love a good fight, not not your comrades..");
        }


        public override void SetDefaults()
        {
            item.damage = 120;
            item.melee = true;
            item.pick = 70;
            item.axe = 55;
            item.width = 75;
            item.height = 75;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 26;
            item.value = 10000;
            item.rare = -13;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.buffType = 114;
            item.buffTime = 60000;
            item.crit = 50;

        }


        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Confused, 5 * 100);
        }







        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.BeamSword, 1);
            recipe.AddIngredient(ItemID.ArmoredSkeletonBanner, 5);

            recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}