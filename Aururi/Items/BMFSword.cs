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
    public class BMFSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Failyre Reforged...");
        }


        public override void SetDefaults()
        {
            item.damage = 260;
            item.melee = true;
            item.pick = 190;
            item.axe = 550;
            item.width = 75;
            item.height = 75;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 26;
            item.value = 10000;
            item.rare = -13;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.buffType = 75;
            item.buffTime = 60000;
            item.crit = 50;
        }






        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Weak, 5 * 1000);
            target.AddBuff(BuffID.Frostburn, 5 * 1000);
            target.AddBuff(BuffID.Electrified, 5 * 1000);
            target.AddBuff(BuffID.Silenced, 5 * 1000);
        }







        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Failyre", 1);
            recipe.AddIngredient(ItemID.DemonBanner, 5);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(ItemID.GoldBar, 10);


            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}