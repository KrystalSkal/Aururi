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
    public class Bladerass : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The main thing is to choose the right fertilizers...");
        }


        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.buffType = 113;
            item.buffTime = 6000;

            item.shoot = 181;
            item.shootSpeed = 16f;
            item.width = 67;
            item.height = 68;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 31;
        }


        



        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Venom, 5 * 1000);
            target.AddBuff(BuffID.Poisoned, 5 * 1000);
        }







        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.BladeofGrass, 2);
            recipe.AddIngredient(ItemID.Stinger, 25);
            recipe.AddIngredient(ItemID.JungleSpores, 15);
            recipe.AddIngredient(ItemID.Vine, 50);
            recipe.AddIngredient(ItemID.Obsidian, 75);

            recipe.AddTile(TileID.WorkBenches);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}