using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLItemBuilder
{
    public class ItemRepo
    {
        private List<FinishedItem> FinishedItems { get; set; }

        public ItemRepo()
        {
            FinishedItems = new List<FinishedItem>();
            FillItemsList();
        }

        private void FillItemsList()
        {
            //==========Finished Items===================
            FinishedItem InfinityEdge = new FinishedItem()
            {
                ItemId = 3031,
                ItemName = "Infinity Edge"
            };

            FinishedItem RodOfAges = new FinishedItem()
            {
                ItemId = 3027,
                ItemName = "RodOfAges"
            };

            FinishedItem SorcerersShoes = new FinishedItem()
            {
                ItemId = 3020,
                ItemName = "SorcerersShoes"
            };

            FinishedItem ZhonyasHourglass = new FinishedItem()
            {
                ItemId = 3191,
                ItemName = "ZhonyasHourglass"
            };

            FinishedItem DeathCap = new FinishedItem()
            {
                ItemId = 3089,
                ItemName = "RabadonsDeathcap"
            };

            FinishedItem VoidStaff = new FinishedItem()
            {
                ItemId = 3135,
                ItemName = "VoidStaff"
            };

            FinishedItem Morellonomicon = new FinishedItem()
            {
                ItemId = 3165,
                ItemName = "Morellonomicon"
            };

            FinishedItem AbyssalScepter = new FinishedItem()
            {
                ItemId = 3001,
                ItemName = "AbyssalScepter"
            };

            FinishedItem RavenousHydra = new FinishedItem()
            {
                ItemId = 3074,
                ItemName = "RavenousHydraMeleeOnly"
            };

            FinishedItem MercurysTreads = new FinishedItem()
            {
                ItemId = 3111,
                ItemName = "MercurysTreads"
            };

            FinishedItem TheBlackCleaver = new FinishedItem()
            {
                ItemId = 3071,
                ItemName = "TheBlackCleaver"
            };

            FinishedItem DeadMansPlate = new FinishedItem()
            {
                ItemId = 3742,
                ItemName = "DeadMansPlate"
            };

            FinishedItem SpitirVisage = new FinishedItem()
            {
                ItemId = 3065,
                ItemName = "SpiritVisage"
            };

            FinishedItem Thornmail = new FinishedItem()
            {
                ItemId = 3075,
                ItemName = "Thornmail"
            };

            FinishedItem MawOfMalmortius = new FinishedItem()
            {
                ItemId = 3156,
                ItemName = "MawOfMalmortius"
            };

            FinishedItem StatikkShiv = new FinishedItem()
            {
                ItemId = 3087,
                ItemName = "StatikkShiv"
            };

            FinishedItem TrinityForce = new FinishedItem()
            {
                ItemId = 3078,
                ItemName = "TrinityForce"
            };

            FinishedItem LordDominiksRegards = new FinishedItem()
            {
                ItemId = 3036,
                ItemName = "LordDominiksRegards"
            };

            FinishedItem LichBane = new FinishedItem()
            {
                ItemId = 3100,
                ItemName = "LichBane"
            };

            FinishedItem LudensEcho = new FinishedItem()
            {
                ItemId = 3285,
                ItemName = "LudensEcho"
            };

            FinishedItem IonianBootsOfLucidity = new FinishedItem()
            {
                ItemId = 3158,
                ItemName = "IonianBootsOfLucidity"
            };

            FinishedItem RylaisCrystalScepter = new FinishedItem()
            {
                ItemId = 3116,
                ItemName = "RylaisCrystalScepter"
            };

            FinishedItem BersekersGreaves = new FinishedItem()
            {
                ItemId = 3006,
                ItemName = "BersekersGreaves"
            };

            FinishedItem RunaansHurricane = new FinishedItem()
            {
                ItemId = 3085,
                ItemName = "RunaansHurricane"
            };

            FinishedItem TheBloodThirster = new FinishedItem()
            {
                ItemId = 3072,
                ItemName = "TheBloodThirster"
            };

            FinishedItem BladeOfTheRuinedKing = new FinishedItem()
            {
                ItemId = 3153,
                ItemName = "BladeOfTheRuinedKing"
            };

            FinishedItem LiandrysTorment = new FinishedItem()
            {
                ItemId = 3151,
                ItemName = "LiandrysTorment"
            };

            FinishedItem YoumuusGhostblade = new FinishedItem()
            {
                ItemId = 3142,
                ItemName = "YoumuusGhostblade"
            };

            //===========================================


            //===============Sub Items===================
            SubItem CatalystTheProtector = new SubItem()
            {
                ItemId = 3010,
                ItemName = "CatalystTheProtector"
            };

            SubItem HauntingGuise = new SubItem()
            {
                ItemId = 3136,
                ItemName = "HauntingGuise"
            };


            SubItem BilgewaterCutlass = new SubItem()
            {
                ItemId = 3144,
                ItemName = "BilgewaterCutlass"
            };

            SubItem RecurveBow = new SubItem()
            {
                ItemId = 1043,
                ItemName = "RecurveBow"
            };

            SubItem Sheen = new SubItem()
            {
                ItemId = 3057,
                ItemName = "Sheen"
            };

            SubItem SeekersArmguard = new SubItem()
            {
                ItemId = 3010,
                ItemName = "SeekersArmguard"
            };

            SubItem FiendishCodex = new SubItem()
            {
                ItemId = 3108,
                ItemName = "FiendishCodex"
            };

            SubItem ForbidenIdol = new SubItem()
            {
                ItemId = 3114,
                ItemName = "ForbidenIdol"
            };

            SubItem NegatronCloak = new SubItem()
            {
                ItemId = 1057,
                ItemName = "NegatronCloak"
            };

            SubItem JaurimsFist = new SubItem()
            {
                ItemId = 3052,
                ItemName = "JaurimsFist"
            };

            SubItem Tiamat = new SubItem()
            {
                ItemId = 3077,
                ItemName = "Tiamat"
            };

            SubItem VampericScepter = new SubItem()
            {
                ItemId = 1053,
                ItemName = "VampericScepter"
            };

            SubItem Phage = new SubItem()
            {
                ItemId = 3044,
                ItemName = "Phage"
            };

            SubItem CaulfieldsHammer = new SubItem()
            {
                ItemId = 3133,
                ItemName = "CaulfieldsHammer"
            };

            SubItem ChainVest = new SubItem()
            {
                ItemId = 1031,
                ItemName = "ChainVest"
            };

            SubItem GiantsBelt = new SubItem()
            {
                ItemId = 1011,
                ItemName = "GiantsBelt"
            };

            SubItem Kindlegem = new SubItem()
            {
                ItemId = 3067,
                ItemName = "Kindlegem"
            };

            SubItem SpectresCowl = new SubItem()
            {
                ItemId = 3211,
                ItemName = "SpectresCowl"
            };

            SubItem Hexdrinker = new SubItem()
            {
                ItemId = 3155,
                ItemName = "Hexdrinker"
            };

            SubItem SerratedDirk = new SubItem()
            {
                ItemId = 3134,
                ItemName = "SerratedDirk"
            };

            SubItem Zeal = new SubItem()
            {
                ItemId = 3086,
                ItemName = "Zeal"
            };

            SubItem KircheisShard = new SubItem()
            {
                ItemId = 2015,
                ItemName = "KircheisShard"
            };

            SubItem LastWhisper = new SubItem()
            {
                ItemId = 3035,
                ItemName = "LastWhisper"
            };

            SubItem GiantSlayer = new SubItem()
            {
                ItemId = 3034,
                ItemName = "GiantSlayer"
            };

            SubItem AetherWisp = new SubItem()
            {
                ItemId = 3113,
                ItemName = "AetherWisp"
            };

            

            //===========================================


            //===============Basic Items===================
            BasicItem BFSword = new BasicItem()
            {
                ItemId = 1038,
                ItemName = "BFSword"
            };

            BasicItem Dagger = new BasicItem()
            {
                ItemId = 1042,
                ItemName = "Dagger"
            };

            BasicItem BrawlersGloves = new BasicItem()
            {
                ItemId = 1051,
                ItemName = "BrawlersGloves"
            };

            BasicItem BootsOfSpeed = new BasicItem()
            {
                ItemId = 1001,
                ItemName = "BootsOfSpeed"
            };

            BasicItem CloakOfAgility = new BasicItem()
            {
                ItemId = 1018,
                ItemName = "CloakOfAgility"
            };

            BasicItem Pickaxe = new BasicItem()
            {
                ItemId = 1037,
                ItemName = "Pickaxe"
            };

            BasicItem RubyCrystal = new BasicItem()
            {
                ItemId = 1028,
                ItemName = "RubyCrystal"
            };

            BasicItem SapphireCrystal = new BasicItem()
            {
                ItemId = 1027,
                ItemName = "SapphireCrystal"
            };

            BasicItem BlastingWand = new BasicItem()
            {
                ItemId = 1026,
                ItemName = "BlastingWand"
            };

            BasicItem AmplifyingTome = new BasicItem()
            {
                ItemId = 1052,
                ItemName = "AmplifyingTome"
            };

            BasicItem ClothArmor = new BasicItem()
            {
                ItemId = 1029,
                ItemName = "ClothArmor"
            };

            BasicItem NeedlesslyLargeRod = new BasicItem()
            {
                ItemId = 1058,
                ItemName = "NeedlesslyLargeRod"
            };

            BasicItem FaerieCharm = new BasicItem()
            {
                ItemId = 1004,
                ItemName = "FaerieCharm"
            };

            BasicItem NullMagicMantle = new BasicItem()
            {
                ItemId = 1033,
                ItemName = "NullMagicMantle"
            };

            BasicItem LongSword = new BasicItem()
            {
                ItemId = 1036,
                ItemName = "LongSword"
            };

            BasicItem RejuvenationBead = new BasicItem()
            {
                ItemId = 1006,
                ItemName = "RejuvenationBead"
            };
            //===========================================
            InfinityEdge.SubItems = new List<SubItem>();
            InfinityEdge.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            InfinityEdge.SubItems.First().BasicItems = new List<BasicItem>();
            InfinityEdge.SubItems.First().BasicItems.Add(BFSword);
            InfinityEdge.SubItems.First().BasicItems.Add(Pickaxe);
            InfinityEdge.SubItems.First().BasicItems.Add(CloakOfAgility);


            RodOfAges.SubItems = new List<SubItem>();
            RodOfAges.SubItems.Add(CatalystTheProtector);
            RodOfAges.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            RodOfAges.SubItems.ElementAt(0).BasicItems = new List<BasicItem>(); 
            RodOfAges.SubItems.ElementAt(0).BasicItems.Add(RubyCrystal);
            RodOfAges.SubItems.ElementAt(0).BasicItems.Add(SapphireCrystal);
            RodOfAges.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            RodOfAges.SubItems.ElementAt(1).BasicItems.Add(BlastingWand);


            SorcerersShoes.SubItems = new List<SubItem>();
            SorcerersShoes.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            SorcerersShoes.SubItems.First().BasicItems = new List<BasicItem>();
            SorcerersShoes.SubItems.First().BasicItems.Add(BootsOfSpeed);

            ZhonyasHourglass.SubItems = new List<SubItem>();
            ZhonyasHourglass.SubItems.Add(SeekersArmguard);
            ZhonyasHourglass.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            ZhonyasHourglass.SubItems.First().BasicItems = new List<BasicItem>();
            ZhonyasHourglass.SubItems.First().BasicItems.Add(AmplifyingTome);
            ZhonyasHourglass.SubItems.First().BasicItems.Add(ClothArmor);
            ZhonyasHourglass.SubItems.First().BasicItems.Add(ClothArmor);
            ZhonyasHourglass.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            ZhonyasHourglass.SubItems.ElementAt(1).BasicItems.Add(NeedlesslyLargeRod);


            DeathCap.SubItems = new List<SubItem>();
            DeathCap.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            DeathCap.SubItems.First().BasicItems = new List<BasicItem>();
            DeathCap.SubItems.First().BasicItems.Add(NeedlesslyLargeRod);
            DeathCap.SubItems.First().BasicItems.Add(BlastingWand);
            DeathCap.SubItems.First().BasicItems.Add(AmplifyingTome);


            VoidStaff.SubItems = new List<SubItem>();
            VoidStaff.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            VoidStaff.SubItems.First().BasicItems = new List<BasicItem>();
            VoidStaff.SubItems.First().BasicItems.Add(BlastingWand);
            VoidStaff.SubItems.First().BasicItems.Add(AmplifyingTome);

            Morellonomicon.SubItems = new List<SubItem>();
            Morellonomicon.SubItems.Add(FiendishCodex);
            Morellonomicon.SubItems.Add(ForbidenIdol);
            Morellonomicon.SubItems.First().BasicItems = new List<BasicItem>();
            Morellonomicon.SubItems.First().BasicItems.Add(AmplifyingTome);
            Morellonomicon.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            Morellonomicon.SubItems.ElementAt(1).BasicItems.Add(FaerieCharm);
            Morellonomicon.SubItems.ElementAt(1).BasicItems.Add(FaerieCharm);


            AbyssalScepter.SubItems = new List<SubItem>();
            AbyssalScepter.SubItems.Add(NegatronCloak);
            AbyssalScepter.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            AbyssalScepter.SubItems.First().BasicItems = new List<BasicItem>();
            AbyssalScepter.SubItems.First().BasicItems.Add(NullMagicMantle);
            AbyssalScepter.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            AbyssalScepter.SubItems.ElementAt(1).BasicItems.Add(BlastingWand);


            RavenousHydra.SubItems = new List<SubItem>();
            RavenousHydra.SubItems.Add(Tiamat);
            RavenousHydra.SubItems.Add(VampericScepter);
            RavenousHydra.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            RavenousHydra.SubItems.First().BasicItems = new List<BasicItem>();
            RavenousHydra.SubItems.First().BasicItems.Add(LongSword);
            RavenousHydra.SubItems.First().BasicItems.Add(LongSword);
            RavenousHydra.SubItems.First().BasicItems.Add(RejuvenationBead);
            RavenousHydra.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            RavenousHydra.SubItems.ElementAt(1).BasicItems.Add(LongSword);
            RavenousHydra.SubItems.ElementAt(2).BasicItems = new List<BasicItem>();
            RavenousHydra.SubItems.ElementAt(2).BasicItems.Add(Pickaxe);


            MercurysTreads.SubItems = new List<SubItem>();
            MercurysTreads.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            MercurysTreads.SubItems.First().BasicItems = new List<BasicItem>();
            MercurysTreads.SubItems.First().BasicItems.Add(BootsOfSpeed);
            MercurysTreads.SubItems.First().BasicItems.Add(NullMagicMantle);


            TheBlackCleaver.SubItems = new List<SubItem>();
            TheBlackCleaver.SubItems.Add(Phage);
            TheBlackCleaver.SubItems.Add(CaulfieldsHammer);
            TheBlackCleaver.SubItems.First().BasicItems = new List<BasicItem>();
            TheBlackCleaver.SubItems.First().BasicItems.Add(RubyCrystal);
            TheBlackCleaver.SubItems.First().BasicItems.Add(LongSword);
            TheBlackCleaver.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            TheBlackCleaver.SubItems.ElementAt(1).BasicItems.Add(LongSword);
            TheBlackCleaver.SubItems.ElementAt(1).BasicItems.Add(LongSword);


            DeadMansPlate.SubItems = new List<SubItem>();
            DeadMansPlate.SubItems.Add(ChainVest);
            DeadMansPlate.SubItems.Add(GiantsBelt);
            DeadMansPlate.SubItems.First().BasicItems = new List<BasicItem>();
            DeadMansPlate.SubItems.First().BasicItems.Add(ClothArmor);
            DeadMansPlate.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            DeadMansPlate.SubItems.ElementAt(1).BasicItems.Add(RubyCrystal);


            SpitirVisage.SubItems = new List<SubItem>();
            SpitirVisage.SubItems.Add(Kindlegem);
            SpitirVisage.SubItems.Add(SpectresCowl);
            SpitirVisage.SubItems.First().BasicItems = new List<BasicItem>();
            SpitirVisage.SubItems.First().BasicItems.Add(RubyCrystal);
            SpitirVisage.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            SpitirVisage.SubItems.ElementAt(1).BasicItems.Add(RubyCrystal);
            SpitirVisage.SubItems.ElementAt(1).BasicItems.Add(NullMagicMantle);


            Thornmail.SubItems = new List<SubItem>();
            Thornmail.SubItems.Add(ChainVest);
            Thornmail.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            Thornmail.SubItems.First().BasicItems = new List<BasicItem>();
            Thornmail.SubItems.First().BasicItems.Add(ClothArmor);
            Thornmail.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            Thornmail.SubItems.ElementAt(1).BasicItems.Add(ClothArmor);


            MawOfMalmortius.SubItems = new List<SubItem>();
            MawOfMalmortius.SubItems.Add(Hexdrinker);
            MawOfMalmortius.SubItems.Add(SerratedDirk);
            MawOfMalmortius.SubItems.First().BasicItems = new List<BasicItem>();
            MawOfMalmortius.SubItems.First().BasicItems.Add(LongSword);
            MawOfMalmortius.SubItems.First().BasicItems.Add(NullMagicMantle);
            MawOfMalmortius.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            MawOfMalmortius.SubItems.ElementAt(1).BasicItems.Add(LongSword);
            MawOfMalmortius.SubItems.ElementAt(1).BasicItems.Add(LongSword);


            StatikkShiv.SubItems = new List<SubItem>();
            StatikkShiv.SubItems.Add(Zeal);
            StatikkShiv.SubItems.Add(KircheisShard);
            StatikkShiv.SubItems.First().BasicItems = new List<BasicItem>();
            StatikkShiv.SubItems.First().BasicItems.Add(Dagger);
            StatikkShiv.SubItems.First().BasicItems.Add(BrawlersGloves);
            StatikkShiv.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            StatikkShiv.SubItems.ElementAt(1).BasicItems.Add(Dagger);


            TrinityForce.SubItems = new List<SubItem>();
            TrinityForce.SubItems.Add(Phage);
            TrinityForce.SubItems.Add(Zeal);
            TrinityForce.SubItems.Add(Sheen);
            TrinityForce.SubItems.First().BasicItems = new List<BasicItem>();
            TrinityForce.SubItems.First().BasicItems.Add(LongSword);
            TrinityForce.SubItems.First().BasicItems.Add(RubyCrystal);
            TrinityForce.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            TrinityForce.SubItems.ElementAt(1).BasicItems.Add(Dagger);
            TrinityForce.SubItems.ElementAt(1).BasicItems.Add(BrawlersGloves);
            TrinityForce.SubItems.ElementAt(2).BasicItems = new List<BasicItem>();
            TrinityForce.SubItems.ElementAt(2).BasicItems.Add(SapphireCrystal);


            LordDominiksRegards.SubItems = new List<SubItem>();
            LordDominiksRegards.SubItems.Add(LastWhisper);
            LordDominiksRegards.SubItems.Add(GiantSlayer);
            LordDominiksRegards.SubItems.First().BasicItems = new List<BasicItem>();
            LordDominiksRegards.SubItems.First().BasicItems.Add(Pickaxe);
            LordDominiksRegards.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            LordDominiksRegards.SubItems.ElementAt(1).BasicItems.Add(LongSword);


            LichBane.SubItems = new List<SubItem>();
            LichBane.SubItems.Add(Sheen);
            LichBane.SubItems.Add(AetherWisp);
            LichBane.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            LichBane.SubItems.First().BasicItems = new List<BasicItem>();
            LichBane.SubItems.First().BasicItems.Add(SapphireCrystal);
            LichBane.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            LichBane.SubItems.ElementAt(1).BasicItems.Add(AmplifyingTome);
            LichBane.SubItems.ElementAt(2).BasicItems = new List<BasicItem>();
            LichBane.SubItems.ElementAt(2).BasicItems.Add(BlastingWand);


            LudensEcho.SubItems = new List<SubItem>();
            LudensEcho.SubItems.Add(AetherWisp);
            LudensEcho.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            LudensEcho.SubItems.First().BasicItems = new List<BasicItem>();
            LudensEcho.SubItems.First().BasicItems.Add(AmplifyingTome);
            LudensEcho.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            LudensEcho.SubItems.ElementAt(1).BasicItems.Add(NeedlesslyLargeRod);


            IonianBootsOfLucidity.SubItems = new List<SubItem>();
            IonianBootsOfLucidity.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            IonianBootsOfLucidity.SubItems.First().BasicItems = new List<BasicItem>();
            IonianBootsOfLucidity.SubItems.First().BasicItems.Add(BootsOfSpeed);


            RylaisCrystalScepter.SubItems = new List<SubItem>();
            RylaisCrystalScepter.SubItems.Add(GiantsBelt);
            RylaisCrystalScepter.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            RylaisCrystalScepter.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            RylaisCrystalScepter.SubItems.First().BasicItems = new List<BasicItem>();
            RylaisCrystalScepter.SubItems.First().BasicItems.Add(RubyCrystal);
            RylaisCrystalScepter.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            RylaisCrystalScepter.SubItems.ElementAt(1).BasicItems.Add(NeedlesslyLargeRod);
            RylaisCrystalScepter.SubItems.ElementAt(2).BasicItems = new List<BasicItem>();
            RylaisCrystalScepter.SubItems.ElementAt(2).BasicItems.Add(AmplifyingTome);


            BersekersGreaves.SubItems = new List<SubItem>();
            BersekersGreaves.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            BersekersGreaves.SubItems.First().BasicItems = new List<BasicItem>();
            BersekersGreaves.SubItems.First().BasicItems.Add(BootsOfSpeed);
            BersekersGreaves.SubItems.First().BasicItems.Add(Dagger);


            RunaansHurricane.SubItems = new List<SubItem>();
            RunaansHurricane.SubItems.Add(RecurveBow);
            RunaansHurricane.SubItems.Add(Zeal);
            RunaansHurricane.SubItems.First().BasicItems = new List<BasicItem>();
            RunaansHurricane.SubItems.First().BasicItems.Add(Dagger);
            RunaansHurricane.SubItems.First().BasicItems.Add(Dagger);
            RunaansHurricane.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            RunaansHurricane.SubItems.ElementAt(1).BasicItems.Add(Dagger);
            RunaansHurricane.SubItems.ElementAt(1).BasicItems.Add(BrawlersGloves);


            TheBloodThirster.SubItems = new List<SubItem>();
            TheBloodThirster.SubItems.Add(VampericScepter);
            TheBloodThirster.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            TheBloodThirster.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            TheBloodThirster.SubItems.First().BasicItems = new List<BasicItem>();
            TheBloodThirster.SubItems.First().BasicItems.Add(LongSword);
            TheBloodThirster.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            TheBloodThirster.SubItems.ElementAt(1).BasicItems.Add(BFSword);
            TheBloodThirster.SubItems.ElementAt(2).BasicItems = new List<BasicItem>();
            TheBloodThirster.SubItems.ElementAt(2).BasicItems.Add(LongSword);


            BladeOfTheRuinedKing.SubItems = new List<SubItem>();
            BladeOfTheRuinedKing.SubItems.Add(RecurveBow);
            BladeOfTheRuinedKing.SubItems.Add(BilgewaterCutlass);
            BladeOfTheRuinedKing.SubItems.First().BasicItems = new List<BasicItem>();
            BladeOfTheRuinedKing.SubItems.First().BasicItems.Add(Dagger);
            BladeOfTheRuinedKing.SubItems.First().BasicItems.Add(Dagger);
            BladeOfTheRuinedKing.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            BladeOfTheRuinedKing.SubItems.ElementAt(1).BasicItems.Add(LongSword);


            LiandrysTorment.SubItems = new List<SubItem>();
            LiandrysTorment.SubItems.Add(HauntingGuise);
            LiandrysTorment.SubItems.Add(new SubItem()
            {
                ItemId = 0,
                ItemName = "Helper"
            });
            LiandrysTorment.SubItems.First().BasicItems = new List<BasicItem>();
            LiandrysTorment.SubItems.First().BasicItems.Add(AmplifyingTome);
            LiandrysTorment.SubItems.First().BasicItems.Add(RubyCrystal);
            LiandrysTorment.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            LiandrysTorment.SubItems.ElementAt(1).BasicItems.Add(BlastingWand);


            YoumuusGhostblade.SubItems = new List<SubItem>();
            YoumuusGhostblade.SubItems.Add(CaulfieldsHammer);
            YoumuusGhostblade.SubItems.Add(SerratedDirk);
            YoumuusGhostblade.SubItems.First().BasicItems = new List<BasicItem>();
            YoumuusGhostblade.SubItems.First().BasicItems.Add(LongSword);
            YoumuusGhostblade.SubItems.First().BasicItems.Add(LongSword);
            YoumuusGhostblade.SubItems.ElementAt(1).BasicItems = new List<BasicItem>();
            YoumuusGhostblade.SubItems.ElementAt(1).BasicItems.Add(LongSword);
            YoumuusGhostblade.SubItems.ElementAt(1).BasicItems.Add(LongSword);

            FinishedItems.Add(InfinityEdge);
            FinishedItems.Add(RodOfAges);
            FinishedItems.Add(SorcerersShoes);
            FinishedItems.Add(ZhonyasHourglass);
            FinishedItems.Add(DeathCap);
            FinishedItems.Add(VoidStaff);
            FinishedItems.Add(Morellonomicon);
            FinishedItems.Add(AbyssalScepter);
            FinishedItems.Add(RavenousHydra);
            FinishedItems.Add(MercurysTreads);
            FinishedItems.Add(TheBlackCleaver);
            FinishedItems.Add(DeadMansPlate);
            FinishedItems.Add(SpitirVisage);
            FinishedItems.Add(Thornmail);
            FinishedItems.Add(StatikkShiv);
            FinishedItems.Add(TrinityForce);
            FinishedItems.Add(LordDominiksRegards);
            FinishedItems.Add(LichBane);
            FinishedItems.Add(LudensEcho);
            FinishedItems.Add(IonianBootsOfLucidity);
            FinishedItems.Add(RylaisCrystalScepter);
            FinishedItems.Add(BersekersGreaves);
            FinishedItems.Add(RunaansHurricane);
            FinishedItems.Add(TheBloodThirster);
            FinishedItems.Add(BladeOfTheRuinedKing);
            FinishedItems.Add(LiandrysTorment);
            FinishedItems.Add(MawOfMalmortius);
            FinishedItems.Add(YoumuusGhostblade);
        }

        public List<FinishedItem> GetList()
        {
            return FinishedItems;
        }

        public FinishedItem FindItem(string itemName)
        {
            return FinishedItems.Single(i => i.ItemName == itemName);
        }
    }
}
