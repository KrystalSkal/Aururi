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
    public class FirstBladeRange : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Power and Deffend of Fire!");
        }


        public override void SetDefaults()
        {
            item.damage = 12;
            item.magic = true;
            item.accessory = true;
            item.defense = 8;
            item.width = 134;
            item.height = 57;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 12;
            item.value = 10000;
            item.rare = -12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = 34;
            item.shootSpeed = 12f;
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

            recipe.AddIngredient(null, "FirstBlade", 1);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}