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
    public class FirstBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Power and Deffend of Fire!");
        }


        public override void SetDefaults()
        {
            item.damage = 43;
            item.melee = true;
            item.accessory = true;
            item.defense = 8;
            item.pick = 70;
            item.axe = 55;
            item.width = 84;
            item.height = 112;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            item.crit = 100;

        }


        



        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 1000);
            target.AddBuff(BuffID.Darkness, 5 * 1000);
            target.AddBuff(BuffID.Cursed, 5 * 1000);
            target.AddBuff(BuffID.Frozen, 5 * 1000);
        }







        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.MeteoriteBar, 60);
            recipe.AddIngredient(ItemID.Aglet, 1);
            recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddIngredient(ItemID.FallenStar, 250);
            recipe.AddIngredient(ItemID.LavaBucket, 1);

            recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "FirstBladeRange", 1);

            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}