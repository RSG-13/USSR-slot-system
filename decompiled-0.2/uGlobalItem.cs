using System;
using Terraria;
using Terraria.ModLoader;
using uniteSlotSystemRemaster;

namespace uniteSlotSystemRemaster
{
    
    internal class uGlobalItemBoots : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] FargoItemTypes = GetFargoTypes();

        public static int[] ThoriumItemTypes = GetThoriumTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AngelTreads", out var AngelTreads);
                CalamityMod.TryFind<ModItem>("TracersCelestial", out var CelestialTracers);
                CalamityMod.TryFind<ModItem>("TracersElysian", out var ElysianTracers);
                CalamityMod.TryFind<ModItem>("TracersSeraph", out var SeraphTracers);
                CalamityMod.TryFind<ModItem>("IronBoots", out var IronBoots);
                CalamityMod.TryFind<ModItem>("GravistarSabaton", out var GravistarSabaton);
                return new int[6] { AngelTreads.Type, CelestialTracers.Type, ElysianTracers.Type, SeraphTracers.Type, IronBoots.Type, GravistarSabaton.Type };
            }
            return new int[6];
        }

        public static int[] GetFargoTypes()
        {
            if (ModLoader.TryGetMod("FargowiltasSouls", out var FargoMod))
            {
                FargoMod.TryFind<ModItem>("EurusSock", out var EurusSock);
                FargoMod.TryFind<ModItem>("ZephyrBoots", out var ZephyrBoots);
                FargoMod.TryFind<ModItem>("AeolusBoots", out var AeolusBoots);
                return new int[3] { EurusSock.Type, ZephyrBoots.Type, AeolusBoots.Type };
            }
            return new int[3];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("CrashBoots", out var CrashBoots);
                ThoriumMod.TryFind<ModItem>("SurvivalistBoots", out var SurvivalistBoots);
                ThoriumMod.TryFind<ModItem>("BeeBooties", out var BeeBooties);
                ThoriumMod.TryFind<ModItem>("JetBoots", out var JetBoots);
                ThoriumMod.TryFind<ModItem>("WizardShoes", out var WizardShoes);
                ThoriumMod.TryFind<ModItem>("SlagStompers", out var SlagStompers);
                ThoriumMod.TryFind<ModItem>("SpringSteps", out var SpringSteps);
                ThoriumMod.TryFind<ModItem>("TurboBoots", out var TurboBoots);
                ThoriumMod.TryFind<ModItem>("TravelersBoots", out var TravelersBoots);
                ThoriumMod.TryFind<ModItem>("SteelToedBoots", out var SteelToedBoots);
                ThoriumMod.TryFind<ModItem>("MarchingBoots", out var MarchingBoots);
                ThoriumMod.TryFind<ModItem>("ArtificersRocketeers", out var ArtificersRocketeers);
                ThoriumMod.TryFind<ModItem>("SpartanSandles", out var SpartanSandles);
                ThoriumMod.TryFind<ModItem>("OgreSandal", out var OgreSandal);
                ThoriumMod.TryFind<ModItem>("HoverBoots", out var HoverBoots);
                ThoriumMod.TryFind<ModItem>("HealthyBoots", out var HealthyBoots);
                ThoriumMod.TryFind<ModItem>("DriftBoots", out var DriftBoots);
                ThoriumMod.TryFind<ModItem>("AirWalkers", out var AirWalkers);
                ThoriumMod.TryFind<ModItem>("TerrariumParticleSprinters", out var TerrariumParticleSprinters);
                return new int[19]
                {
                    CrashBoots.Type, SurvivalistBoots.Type, BeeBooties.Type, JetBoots.Type, WizardShoes.Type, SlagStompers.Type, SpringSteps.Type, TurboBoots.Type, TravelersBoots.Type, SteelToedBoots.Type,
                    MarchingBoots.Type, ArtificersRocketeers.Type, SpartanSandles.Type, OgreSandal.Type, HoverBoots.Type, HealthyBoots.Type, DriftBoots.Type, AirWalkers.Type, TerrariumParticleSprinters.Type
                };
            }
            return new int[19];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemBoots()
        {
            int[] obj = new int[46]
            {
                54, 1579, 3200, 4055, 3990, 405, 3993, 4874, 898, 1862,
                5000, 863, 907, 908, 128, 950, 3017, 4822, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0
            };
            obj[18] = CalamityItemTypes[0];
            obj[19] = CalamityItemTypes[1];
            obj[20] = CalamityItemTypes[2];
            obj[21] = CalamityItemTypes[3];
            obj[22] = CalamityItemTypes[4];
            obj[23] = CalamityItemTypes[5];
            obj[24] = FargoItemTypes[0];
            obj[25] = FargoItemTypes[1];
            obj[26] = FargoItemTypes[2];
            obj[27] = ThoriumItemTypes[0];
            obj[28] = ThoriumItemTypes[1];
            obj[29] = ThoriumItemTypes[2];
            obj[30] = ThoriumItemTypes[3];
            obj[31] = ThoriumItemTypes[4];
            obj[32] = ThoriumItemTypes[5];
            obj[33] = ThoriumItemTypes[6];
            obj[34] = ThoriumItemTypes[7];
            obj[35] = ThoriumItemTypes[8];
            obj[36] = ThoriumItemTypes[9];
            obj[37] = ThoriumItemTypes[10];
            obj[38] = ThoriumItemTypes[11];
            obj[39] = ThoriumItemTypes[12];
            obj[40] = ThoriumItemTypes[13];
            obj[41] = ThoriumItemTypes[14];
            obj[42] = ThoriumItemTypes[15];
            obj[43] = ThoriumItemTypes[16];
            obj[44] = ThoriumItemTypes[17];
            obj[45] = ThoriumItemTypes[18];
            Items = obj;
        }
    }
    internal class uGlobalItemBuilding : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AncientFossil", out var AncientFossil);
                CalamityMod.TryFind<ModItem>("OceanCrest", out var OceanCrest);
                CalamityMod.TryFind<ModItem>("SpelunkersAmulet", out var SpelunkersAmulet);
                CalamityMod.TryFind<ModItem>("ArchaicPowder", out var ArchaicPowder);
                return new int[4] { AncientFossil.Type, OceanCrest.Type, SpelunkersAmulet.Type, ArchaicPowder.Type };
            }
            return new int[4];
        }

       public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemBuilding()
        {
            int[] obj = new int[16]
            {
                3624, 1923, 407, 2216, 2215, 2217, 2214, 3061, 4056, 5126,
                5010, 4341, 0, 0, 0, 0
            };
            obj[12] = CalamityItemTypes[0];
            obj[13] = CalamityItemTypes[1];
            obj[14] = CalamityItemTypes[2];
            obj[15] = CalamityItemTypes[3];
            Items = obj;
        }
    }
    internal class uGlobalItemDefense : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] FargoItemTypes = GetFargoTypes();

        public static int[] ThoriumItemTypes = GetThoriumTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("Baroclaw", out var defacc1);
                CalamityMod.TryFind<ModItem>("GiantTortoiseShell", out var defacc2);
                CalamityMod.TryFind<ModItem>("CrawCarapace", out var defacc3);
                CalamityMod.TryFind<ModItem>("GiantShell", out var defacc4);
                CalamityMod.TryFind<ModItem>("ElysianAegis", out var defacc5);
                CalamityMod.TryFind<ModItem>("AsgardianAegis", out var defacc6);
                CalamityMod.TryFind<ModItem>("AsgardsValor", out var defacc7);
                CalamityMod.TryFind<ModItem>("ShieldoftheOcean", out var defacc8);
                CalamityMod.TryFind<ModItem>("MarniteRepulsionShield", out var defacc9);
                CalamityMod.TryFind<ModItem>("OrnateShield", out var defacc10);
                CalamityMod.TryFind<ModItem>("ShieldoftheHighRuler", out var defacc11);
                CalamityMod.TryFind<ModItem>("RampartofDeities", out var defacc12);
                CalamityMod.TryFind<ModItem>("RoverDrive", out var defacc13);
                CalamityMod.TryFind<ModItem>("TheSponge", out var defacc14);
                CalamityMod.TryFind<ModItem>("Affliction", out var defacc15);
                CalamityMod.TryFind<ModItem>("BloodflareCore", out var defacc16);
                CalamityMod.TryFind<ModItem>("TheAbsorber", out var defacc17);
                CalamityMod.TryFind<ModItem>("SlagsplitterPauldron", out var defacc18);
                CalamityMod.TryFind<ModItem>("FrostBarrier", out var defacc19);
                CalamityMod.TryFind<ModItem>("HideofAstrumDeus", out var defacc20);
                CalamityMod.TryFind<ModItem>("TheTransformer", out var defacc21);
                CalamityMod.TryFind<ModItem>("NebulousCore", out var defacc22);
                return new int[22]
                {
                    defacc1.Type, defacc2.Type, defacc3.Type, defacc4.Type, defacc5.Type, defacc6.Type, defacc7.Type, defacc8.Type, defacc9.Type, defacc10.Type,
                    defacc11.Type, defacc12.Type, defacc13.Type, defacc14.Type, defacc15.Type, defacc16.Type, defacc17.Type, defacc18.Type, defacc19.Type, defacc20.Type,
                    defacc21.Type, defacc22.Type
                };
            }
            return new int[22];
        }

        public static int[] GetFargoTypes()
        {
            return new int[3];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("MantleoftheProtector", out var defacc1);
                ThoriumMod.TryFind<ModItem>("TerrariumDefender", out var defacc2);
                ThoriumMod.TryFind<ModItem>("GoldAegis", out var defacc3);
                ThoriumMod.TryFind<ModItem>("HolyAegis", out var defacc4);
                ThoriumMod.TryFind<ModItem>("PlatinumAegis", out var defacc5);
                ThoriumMod.TryFind<ModItem>("ArtificersShield", out var defacc6);
                ThoriumMod.TryFind<ModItem>("BlastShield", out var defacc7);
                ThoriumMod.TryFind<ModItem>("BloomingShield", out var defacc8);
                ThoriumMod.TryFind<ModItem>("GoblinWarshield", out var defacc9);
                ThoriumMod.TryFind<ModItem>("ThoriumShield", out var defacc10);
                ThoriumMod.TryFind<ModItem>("IronShield", out var defacc11);
                ThoriumMod.TryFind<ModItem>("LeadShield", out var defacc12);
                ThoriumMod.TryFind<ModItem>("AstroBeetleHusk", out var defacc13);
                ThoriumMod.TryFind<ModItem>("PlasmaGenerator", out var defacc14);
                ThoriumMod.TryFind<ModItem>("CopperBuckler", out var defacc15);
                ThoriumMod.TryFind<ModItem>("TinBuckler", out var defacc16);
                ThoriumMod.TryFind<ModItem>("SilverBulwark", out var defacc17);
                ThoriumMod.TryFind<ModItem>("TungstenBulwark", out var defacc18);
                ThoriumMod.TryFind<ModItem>("SeaTurtlesBulwark", out var defacc19);
                return new int[19]
                {
                    defacc1.Type, defacc2.Type, defacc3.Type, defacc4.Type, defacc5.Type, defacc6.Type, defacc7.Type, defacc8.Type, defacc9.Type, defacc10.Type,
                    defacc11.Type, defacc12.Type, defacc13.Type, defacc14.Type, defacc15.Type, defacc16.Type, defacc17.Type, defacc18.Type, defacc19.Type
                };
            }
            return new int[19];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemDefense()
        {
            int[] obj = new int[77]
            {
                3999, 4003, 4004, 4038, 1921, 396, 158, 193, 3016, 3998,
                938, 1253, 3997, 1613, 156, 397, 3097, 888, 3781, 5354,
                892, 886, 901, 887, 885, 902, 889, 893, 903, 890,
                891, 904, 1612, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0
            };
            obj[33] = CalamityItemTypes[0];
            obj[34] = CalamityItemTypes[1];
            obj[35] = CalamityItemTypes[2];
            obj[36] = CalamityItemTypes[3];
            obj[37] = CalamityItemTypes[4];
            obj[38] = CalamityItemTypes[5];
            obj[39] = CalamityItemTypes[6];
            obj[40] = CalamityItemTypes[7];
            obj[41] = CalamityItemTypes[8];
            obj[42] = CalamityItemTypes[9];
            obj[43] = CalamityItemTypes[10];
            obj[44] = CalamityItemTypes[11];
            obj[45] = CalamityItemTypes[12];
            obj[46] = CalamityItemTypes[13];
            obj[47] = CalamityItemTypes[14];
            obj[48] = CalamityItemTypes[15];
            obj[49] = CalamityItemTypes[16];
            obj[50] = CalamityItemTypes[17];
            obj[51] = CalamityItemTypes[18];
            obj[52] = CalamityItemTypes[19];
            obj[53] = CalamityItemTypes[20];
            obj[54] = CalamityItemTypes[21];
            obj[55] = FargoItemTypes[0];
            obj[56] = FargoItemTypes[1];
            obj[57] = FargoItemTypes[2];
            obj[58] = ThoriumItemTypes[0];
            obj[59] = ThoriumItemTypes[1];
            obj[60] = ThoriumItemTypes[2];
            obj[61] = ThoriumItemTypes[3];
            obj[62] = ThoriumItemTypes[4];
            obj[63] = ThoriumItemTypes[5];
            obj[64] = ThoriumItemTypes[6];
            obj[65] = ThoriumItemTypes[7];
            obj[66] = ThoriumItemTypes[8];
            obj[67] = ThoriumItemTypes[9];
            obj[68] = ThoriumItemTypes[10];
            obj[69] = ThoriumItemTypes[11];
            obj[70] = ThoriumItemTypes[12];
            obj[71] = ThoriumItemTypes[13];
            obj[72] = ThoriumItemTypes[14];
            obj[73] = ThoriumItemTypes[15];
            obj[74] = ThoriumItemTypes[16];
            obj[75] = ThoriumItemTypes[17];
            obj[76] = ThoriumItemTypes[18];
            Items = obj;
        }
    }
    internal class uGlobalItemExpert : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodyWormTooth", out var BloodyWormTooth);
                CalamityMod.TryFind<ModItem>("RottenBrain", out var RottenBrain);
                CalamityMod.TryFind<ModItem>("AmalgamatedBrain", out var AmalgamatedBrain);
                CalamityMod.TryFind<ModItem>("BloodyWormScarf", out var BloodyWormScarf);
                CalamityMod.TryFind<ModItem>("TheAmalgam", out var TheAmalgam);
                return new int[5] { BloodyWormTooth.Type, RottenBrain.Type, AmalgamatedBrain.Type, BloodyWormScarf.Type, TheAmalgam.Type };
            }
            return new int[5];
        }

        

        static uGlobalItemExpert()
        {
            int[] obj = new int[18]
            {
                3090, 3097, 3224, 3223, 3333, 3245, 5100, 4987, 3336, 3337,
                4989, 1131, 4954, 0, 0, 0, 0, 0
            };
            obj[13] = CalamityItemTypes[0];
            obj[14] = CalamityItemTypes[1];
            obj[15] = CalamityItemTypes[2];
            obj[16] = CalamityItemTypes[3];
            obj[17] = CalamityItemTypes[4];
            Items = obj;
        }
    }
    internal class uGlobalItemFishing : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AlluringBait", out var AlluringBait);
                CalamityMod.TryFind<ModItem>("EnchantedPearl", out var EnchantedPearl);
                CalamityMod.TryFind<ModItem>("SupremeBaitTackleBoxFishingStation", out var SupremeBaitTackleBoxFishingStation);
                return new int[3] { AlluringBait.Type, EnchantedPearl.Type, SupremeBaitTackleBoxFishingStation.Type };
            }
            return new int[3];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemFishing()
        {
            int[] obj = new int[17]
            {
                5064, 3721, 4881, 2375, 2374, 2373, 5139, 5140, 5141, 5142,
                5143, 5144, 5145, 5146, 0, 0, 0
            };
            obj[14] = CalamityItemTypes[0];
            obj[15] = CalamityItemTypes[1];
            obj[16] = CalamityItemTypes[2];
            Items = obj;
        }
    }
    internal class uGlobalItemGear : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("StatisNinjaBelt", out var StatisNinjaBelt);
                CalamityMod.TryFind<ModItem>("StatisVoidSash", out var StatisVoidSash);
                CalamityMod.TryFind<ModItem>("AbyssalDivingGear", out var AbyssalDivingGear);
                CalamityMod.TryFind<ModItem>("AbyssalDivingSuit", out var AbyssalDivingSuit);
                return new int[4] { StatisNinjaBelt.Type, StatisVoidSash.Type, AbyssalDivingGear.Type, AbyssalDivingSuit.Type };
            }
            return new int[4];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemGear()
        {
            int[] obj = new int[17]
            {
                394, 953, 975, 976, 963, 977, 984, 1860, 1861, 2423,
                3994, 3996, 3995, 0, 0, 0, 0
            };
            obj[13] = CalamityItemTypes[0];
            obj[14] = CalamityItemTypes[1];
            obj[15] = CalamityItemTypes[2];
            obj[16] = CalamityItemTypes[3];
            Items = obj;
        }
    }
    internal class uGlobalItemHeal : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] FargoItemTypes = GetFargoTypes();

        public static int[] ThoriumItemTypes = GetThoriumTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodPact", out var BloodPact);
                CalamityMod.TryFind<ModItem>("AmbrosialAmpoule", out var AmbrosialAmpoule);
                CalamityMod.TryFind<ModItem>("CleansingJelly", out var CleansingJelly);
                CalamityMod.TryFind<ModItem>("HoneyDew", out var HoneyDew);
                CalamityMod.TryFind<ModItem>("CrownJewel", out var CrownJewel);
                CalamityMod.TryFind<ModItem>("GladiatorsLocket", out var GladiatorsLocket);
                CalamityMod.TryFind<ModItem>("GrandGelatin", out var GrandGelatin);
                CalamityMod.TryFind<ModItem>("LifeJelly", out var LifeJelly);
                CalamityMod.TryFind<ModItem>("LivingDew", out var LivingDew);
                CalamityMod.TryFind<ModItem>("InfectedJewel", out var InfectedJewel);
                CalamityMod.TryFind<ModItem>("RadiantOoze", out var RadiantOoze);
                CalamityMod.TryFind<ModItem>("TrinketofChi", out var TrinketofChi);
                CalamityMod.TryFind<ModItem>("VitalJelly", out var VitalJelly);
                CalamityMod.TryFind<ModItem>("Radiance", out var Radiance);
                CalamityMod.TryFind<ModItem>("Regenator", out var Regenator);
                CalamityMod.TryFind<ModItem>("ChaliceOfTheBloodGod", out var ChaliceOfTheBloodGod);
                CalamityMod.TryFind<ModItem>("TheAbsorber", out var TheAbsorber);
                CalamityMod.TryFind<ModItem>("BloomStone", out var BloomStone);
                CalamityMod.TryFind<ModItem>("PermafrostsConcoction", out var PermafrostsConcoction);
                CalamityMod.TryFind<ModItem>("DraedonsHeart", out var DraedonsHeart);
                CalamityMod.TryFind<ModItem>("TheCamper", out var TheCamper);
                CalamityMod.TryFind<ModItem>("NebulousCore", out var NebulousCore);
                return new int[22]
                {
                    BloodPact.Type, AmbrosialAmpoule.Type, CleansingJelly.Type, HoneyDew.Type, CrownJewel.Type, GladiatorsLocket.Type, GrandGelatin.Type, LifeJelly.Type, LivingDew.Type, InfectedJewel.Type,
                    RadiantOoze.Type, TrinketofChi.Type, VitalJelly.Type, Radiance.Type, Regenator.Type, ChaliceOfTheBloodGod.Type, TheAbsorber.Type, BloomStone.Type, PermafrostsConcoction.Type, DraedonsHeart.Type,
                    TheCamper.Type, NebulousCore.Type
                };
            }
            return new int[22];
        }

        public static int[] GetFargoTypes()
        {
            return new int[3];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("MonsterCharm", out var MonsterCharm);
                ThoriumMod.TryFind<ModItem>("Phylactery", out var Phylactery);
                ThoriumMod.TryFind<ModItem>("NecromancersHeart", out var NecromancersHeart);
                ThoriumMod.TryFind<ModItem>("PotionChaser", out var PotionChaser);
                ThoriumMod.TryFind<ModItem>("SalamanderEye", out var SalamanderEye);
                ThoriumMod.TryFind<ModItem>("BandofReplenishment", out var BandofReplenishment);
                ThoriumMod.TryFind<ModItem>("VampireGland", out var VampireGland);
                return new int[7] { MonsterCharm.Type, Phylactery.Type, NecromancersHeart.Type, PotionChaser.Type, SalamanderEye.Type, BandofReplenishment.Type, VampireGland.Type };
            }
            return new int[7];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemHeal()
        {
            int[] obj = new int[47]
            {
                3991, 49, 111, 2221, 2219, 2220, 860, 1595, 4000, 4001,
                555, 982, 223, 535, 3337, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0
            };
            obj[15] = CalamityItemTypes[0];
            obj[16] = CalamityItemTypes[1];
            obj[17] = CalamityItemTypes[2];
            obj[18] = CalamityItemTypes[3];
            obj[19] = CalamityItemTypes[4];
            obj[20] = CalamityItemTypes[5];
            obj[21] = CalamityItemTypes[6];
            obj[22] = CalamityItemTypes[7];
            obj[23] = CalamityItemTypes[8];
            obj[24] = CalamityItemTypes[9];
            obj[25] = CalamityItemTypes[10];
            obj[26] = CalamityItemTypes[11];
            obj[27] = CalamityItemTypes[12];
            obj[28] = CalamityItemTypes[13];
            obj[29] = CalamityItemTypes[14];
            obj[30] = CalamityItemTypes[15];
            obj[31] = CalamityItemTypes[16];
            obj[32] = CalamityItemTypes[17];
            obj[33] = CalamityItemTypes[18];
            obj[34] = CalamityItemTypes[19];
            obj[35] = CalamityItemTypes[20];
            obj[36] = CalamityItemTypes[21];
            obj[37] = FargoItemTypes[0];
            obj[38] = FargoItemTypes[1];
            obj[39] = FargoItemTypes[2];
            obj[40] = ThoriumItemTypes[0];
            obj[41] = ThoriumItemTypes[1];
            obj[42] = ThoriumItemTypes[2];
            obj[43] = ThoriumItemTypes[3];
            obj[44] = ThoriumItemTypes[4];
            obj[45] = ThoriumItemTypes[5];
            obj[46] = ThoriumItemTypes[6];
            Items = obj;
        }
    }
    internal class uGlobalItemMagiluminescence : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] myItemTypes = GetMyItemTypes();

        public static int[] Items = new int[5]
        {
            4989,
            5107,
            CalamityItemTypes[0],
            myItemTypes[0],
            myItemTypes[1]
        };

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("AscendantInsignia", out var AscendantInsignia);
                return new int[1] { AscendantInsignia.Type };
            }
            return new int[1];
        }

        public static int[] GetMyItemTypes()
        {
            if (ModLoader.TryGetMod("moreAccessories", out var moreAccessories))
            {
                moreAccessories.TryFind<ModItem>("CosmiliteInsignia", out var CosmiliteInsignia);
                moreAccessories.TryFind<ModItem>("MechMagiluminescence", out var MechMagiluminescence);
                return new int[2] { CosmiliteInsignia.Type, MechMagiluminescence.Type };
            }
            return new int[2];
        }
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }
    }
    internal class uGlobalItemNecklace : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] ThoriumItemTypes = GetThoriumTypes();

        public static int[] WisplanternItemTypes = GetWisplanternTypes();

        public static int[] Items;

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("SandSharkToothNecklace", out var SandSharkToothNecklace);
                CalamityMod.TryFind<ModItem>("ReaperToothNecklace", out var ReaperToothNecklace);
                CalamityMod.TryFind<ModItem>("NecklaceofVexation", out var NecklaceofVexation);
                CalamityMod.TryFind<ModItem>("SpelunkersAmulet", out var SpelunkersAmulet);
                CalamityMod.TryFind<ModItem>("DeificAmulet", out var DeificAmulet);
                CalamityMod.TryFind<ModItem>("LumenousAmulet", out var LumenousAmulet);
                CalamityMod.TryFind<ModItem>("AbyssalAmulet", out var AbyssalAmulet);
                return new int[7] { SandSharkToothNecklace.Type, ReaperToothNecklace.Type, NecklaceofVexation.Type, AbyssalAmulet.Type, LumenousAmulet.Type, SpelunkersAmulet.Type, DeificAmulet.Type };
            }
            return new int[7];
        }

        public static int[] GetThoriumTypes()
        {
            if (ModLoader.TryGetMod("ThoriumMod", out var ThoriumMod))
            {
                ThoriumMod.TryFind<ModItem>("PacifistNecklace", out var PacifistNecklace);
                ThoriumMod.TryFind<ModItem>("ForgottenCrossNecklace", out var ForgottenCrossNecklace);
                ThoriumMod.TryFind<ModItem>("DragonTalonNecklace", out var DragonTalonNecklace);
                ThoriumMod.TryFind<ModItem>("VerdantOrnament", out var VerdantOrnament);
                ThoriumMod.TryFind<ModItem>("SavingGrace", out var SavingGrace);
                ThoriumMod.TryFind<ModItem>("Equalizer", out var Equalizer);
                ThoriumMod.TryFind<ModItem>("SacredHeart", out var SacredHeart);
                ThoriumMod.TryFind<ModItem>("SweetVengeance", out var SweetVengeance);
                return new int[8] { PacifistNecklace.Type, ForgottenCrossNecklace.Type, DragonTalonNecklace.Type, VerdantOrnament.Type, SavingGrace.Type, Equalizer.Type, SacredHeart.Type, SweetVengeance.Type };
            }
            return new int[8];
        }

        public static int[] GetWisplanternTypes()
        {
            if (ModLoader.TryGetMod("Wisplantern", out var WisplanternMod))
            {
                WisplanternMod.TryFind<ModItem>("WispNecklace", out var WispNecklace);
                return new int[1] { WispNecklace.Type };
            }
            return new int[1];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }

        static uGlobalItemNecklace()
        {
            int[] obj = new int[24]
            {
                554, 862, 1158, 1290, 1303, 1578, 3212, 4007, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0
            };
            obj[8] = CalamityItemTypes[0];
            obj[9] = CalamityItemTypes[1];
            obj[10] = CalamityItemTypes[2];
            obj[11] = CalamityItemTypes[3];
            obj[12] = CalamityItemTypes[4];
            obj[13] = CalamityItemTypes[5];
            obj[14] = CalamityItemTypes[6];
            obj[15] = ThoriumItemTypes[0];
            obj[16] = ThoriumItemTypes[1];
            obj[17] = ThoriumItemTypes[2];
            obj[18] = ThoriumItemTypes[3];
            obj[19] = ThoriumItemTypes[4];
            obj[20] = ThoriumItemTypes[5];
            obj[21] = ThoriumItemTypes[6];
            obj[22] = ThoriumItemTypes[7];
            obj[23] = WisplanternItemTypes[0];
            Items = obj;
        }
    }
    internal class uGlobalItemRevengeance : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] Items = new int[4]
        {
            CalamityItemTypes[0],
            CalamityItemTypes[1],
            CalamityItemTypes[2],
            CalamityItemTypes[3]
        };

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("Laudanum", out var Laudanum);
                CalamityMod.TryFind<ModItem>("OccultSkullCrown", out var OccultSkullCrown);
                CalamityMod.TryFind<ModItem>("StressPills", out var StressPills);
                CalamityMod.TryFind<ModItem>("HeartofDarkness", out var HeartofDarkness);
                return new int[4] { Laudanum.Type, OccultSkullCrown.Type, StressPills.Type, HeartofDarkness.Type };
            }
            return new int[4];
        }
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }
    }
    internal class uGlobalItemScarf : GlobalItem
    {
        public static int[] CalamityItemTypes = GetCalamityTypes();

        public static int[] myItemTypes = GetMyItemTypes();

        public static int[] Items = new int[8]
        {
            3809,
            3224,
            CalamityItemTypes[0],
            CalamityItemTypes[1],
            CalamityItemTypes[2],
            CalamityItemTypes[3],
            myItemTypes[0],
            myItemTypes[1]
        };

        public static int[] GetCalamityTypes()
        {
            if (ModLoader.TryGetMod("CalamityMod", out var CalamityMod))
            {
                CalamityMod.TryFind<ModItem>("BloodyWormScarf", out var scarf1c);
                CalamityMod.TryFind<ModItem>("CounterScarf", out var scarf2c);
                CalamityMod.TryFind<ModItem>("EvasionScarf", out var scarf3c);
                CalamityMod.TryFind<ModItem>("Popo", out var scarf4c);
                return new int[4] { scarf1c.Type, scarf2c.Type, scarf3c.Type, scarf4c.Type };
            }
            return new int[4];
        }

        public static int[] GetMyItemTypes()
        {
            if (ModLoader.TryGetMod("moreAccessories", out var moreAccessories))
            {
                moreAccessories.TryFind<ModItem>("MegaScarf", out var scarf1c);
                moreAccessories.TryFind<ModItem>("TheDevourerofWorms", out var scarf2c);
                return new int[2] { scarf1c.Type, scarf2c.Type };
            }
            return new int[2];
        }

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Array.IndexOf(Items, entity.type) != -1;
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (!modded)
            {
                return Configuration.I.AllowEquippingInOtherSlots;
            }
            return true;
        }
    }
}