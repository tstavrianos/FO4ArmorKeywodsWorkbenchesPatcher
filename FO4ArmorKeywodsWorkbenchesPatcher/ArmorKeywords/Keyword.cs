using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4
{
    public static partial class ArmorKeywords
    {
        public static class Keyword
        {
            private static FormLink<IKeywordGetter> Construct(uint id)
            {
                return new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
            }

            public static FormLink<IKeywordGetter> AEC_ck_AdvancedEngineeringCraftingKey => Construct(0x195a);
            public static FormLink<IKeywordGetter> AEC_ck_AmmunitionCraftingKey => Construct(0x95a);

            public static FormLink<IKeywordGetter> AEC_ck_ArmorsmithCraftingKey => Construct(0x851);

            //public static FormLink<IKeywordGetter> AEC_ck_DecalStationCraftingKey => Construct(0x22a3);
            //public static FormLink<IKeywordGetter> AEC_ck_ElectronicsCraftingKey => Construct(0x1764);
            public static FormLink<IKeywordGetter> AEC_ck_ExplosivesCraftingKey => Construct(0xbfd);

            //public static FormLink<IKeywordGetter> AEC_ck_PaintStationCraftingKey => Construct(0xe3d);
            //public static FormLink<IKeywordGetter> AEC_ck_PaintStationCraftingKey => Construct(0xe3d);
            public static FormLink<IKeywordGetter> AEC_ck_UtilityCraftingKey => Construct(0x1765);
            public static FormLink<IKeywordGetter> AEC_ck_WeaponsmithCraftingKey => Construct(0x85d);
        }
    }
}