namespace Sharky.TypeData
{
    public class UpgradeDataService
    {
        public Dictionary<Upgrades, TrainingTypeData> UpgradeData()
        {
            var upgradeData = ProtossUpgradeData();
            TerranUpgradeData().ToList().ForEach(x => upgradeData.Add(x.Key, x.Value));
            ZergUpgradeData().ToList().ForEach(x => upgradeData.Add(x.Key, x.Value));
            return upgradeData;
        }

        public Dictionary<Upgrades, TrainingTypeData> ProtossUpgradeData()
        {
            return new Dictionary<Upgrades, TrainingTypeData>
            {             
                { Upgrades.PROTOSSGROUNDWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_PROTOSSGROUNDWEAPONSLEVEL1, Time = 122 } },
                { Upgrades.PROTOSSGROUNDWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PROTOSSGROUNDWEAPONSLEVEL2, Time = 145 } },
                { Upgrades.PROTOSSGROUNDWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_PROTOSSGROUNDWEAPONSLEVEL3, Time = 168 } },
                { Upgrades.PROTOSSGROUNDARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_PROTOSSGROUNDARMORLEVEL1, Time = 122 } },
                { Upgrades.PROTOSSGROUNDARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PROTOSSGROUNDARMORLEVEL2, Time = 145 } },
                { Upgrades.PROTOSSGROUNDARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_PROTOSSGROUNDARMORLEVEL3, Time = 168 } },
                { Upgrades.PROTOSSSHIELDSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PROTOSSSHIELDSLEVEL1, Time = 122 } },
                { Upgrades.PROTOSSSHIELDSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 225, Gas = 225, Ability = Abilities.RESEARCH_PROTOSSSHIELDSLEVEL2, Time = 145 } },
                { Upgrades.PROTOSSSHIELDSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FORGE }, Minerals = 300, Gas = 300, Ability = Abilities.RESEARCH_PROTOSSSHIELDSLEVEL3, Time = 168 } },

                { Upgrades.WARPGATERESEARCH, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 50, Gas = 50, Ability = Abilities.RESEARCH_WARPGATE, Time = 100 } },
                { Upgrades.PROTOSSAIRWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_PROTOSSAIRWEAPONSLEVEL1, Time = 129 } },
                { Upgrades.PROTOSSAIRWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_PROTOSSAIRWEAPONSLEVEL2, Time = 154 } },
                { Upgrades.PROTOSSAIRWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_PROTOSSAIRWEAPONSLEVEL3, Time = 179 } },
                { Upgrades.PROTOSSAIRARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PROTOSSAIRARMORLEVEL1, Time = 129 } },
                { Upgrades.PROTOSSAIRARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 225, Gas = 225, Ability = Abilities.RESEARCH_PROTOSSAIRARMORLEVEL2, Time = 154 } },
                { Upgrades.PROTOSSAIRARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_CYBERNETICSCORE }, Minerals = 300, Gas = 300, Ability = Abilities.RESEARCH_PROTOSSAIRARMORLEVEL3, Time = 179 } },

                { Upgrades.GRAVITICDRIVE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSBAY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_GRAVITICDRIVE, Time = 57 } },
                { Upgrades.EXTENDEDTHERMALLANCE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSBAY }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_EXTENDEDTHERMALLANCE, Time = 100 } },
                { Upgrades.OBSERVERGRAVITICBOOSTER, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_ROBOTICSBAY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_GRAVITICBOOSTER, Time = 57 } },

                { Upgrades.PSISTORMTECH, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_TEMPLARARCHIVE }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_PSISTORM, Time = 79 } },

                { Upgrades.DARKTEMPLARBLINKUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_DARKSHRINE }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_SHADOWSTRIKE, Time = 100 } },

                { Upgrades.BLINKTECH, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_TWILIGHTCOUNCIL }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_BLINK, Time = 121 } },
                { Upgrades.CHARGE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_TWILIGHTCOUNCIL }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_CHARGE, Time = 100 } },
                { Upgrades.ADEPTPIERCINGATTACK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_TWILIGHTCOUNCIL }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_ADEPTRESONATINGGLAIVES, Time = 100 } },

                { Upgrades.TECTONICDESTABILIZERS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FLEETBEACON }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_TECTONICDESTABILIZERS, Time = 100 } },
                { Upgrades.PHOENIXRANGEUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FLEETBEACON }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PHOENIXANIONPULSECRYSTALS, Time = 64 } },
                { Upgrades.VOIDRAYSPEEDUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FLEETBEACON }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_VOIDRAYSPEEDUPGRADE, Time = 57 } },
                { Upgrades.CARRIERLAUNCHSPEEDUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.PROTOSS_FLEETBEACON }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_INTERCEPTORGRAVITONCATAPULT, Time = 57 } }
            };
        }

        public Dictionary<Upgrades, TrainingTypeData> TerranUpgradeData()
        {
            return new Dictionary<Upgrades, TrainingTypeData>
            {
                { Upgrades.TERRANINFANTRYWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TERRANINFANTRYWEAPONSLEVEL1, Time = 114 } },
                { Upgrades.TERRANINFANTRYWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_TERRANINFANTRYWEAPONSLEVEL2, Time = 136 } },
                { Upgrades.TERRANINFANTRYWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_TERRANINFANTRYWEAPONSLEVEL3, Time = 157 } },
                { Upgrades.TERRANINFANTRYARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TERRANINFANTRYARMORLEVEL1, Time = 114 } },
                { Upgrades.TERRANINFANTRYARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_TERRANINFANTRYARMORLEVEL2, Time = 136 } },
                { Upgrades.TERRANINFANTRYARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_TERRANINFANTRYARMORLEVEL3, Time = 157 } },
                { Upgrades.HISECAUTOTRACKING, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_HISECAUTOTRACKING, Time = 57 } },
                { Upgrades.TERRANBUILDINGARMOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ENGINEERINGBAY }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_TERRANSTRUCTUREARMORUPGRADE, Time = 140 } },

                { Upgrades.PERSONALCLOAKING, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_GHOSTACADEMY }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PERSONALCLOAKING, Time = 86 } },
                { Upgrades.ENHANCEDSHOCKWAVES, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_GHOSTACADEMY }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ENHANCEDSHOCKWAVES, Time = 79 } },

                { Upgrades.TERRANVEHICLEWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TERRANVEHICLEWEAPONSLEVEL1, Time = 114 } },
                { Upgrades.TERRANVEHICLEWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_TERRANVEHICLEWEAPONSLEVEL2, Time = 136 } },
                { Upgrades.TERRANVEHICLEWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_TERRANVEHICLEWEAPONSLEVEL3, Time = 157 } },
                { Upgrades.TERRANSHIPWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TERRANSHIPWEAPONSLEVEL1, Time = 114 } },
                { Upgrades.TERRANSHIPWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_TERRANSHIPWEAPONSLEVEL2, Time = 136 } },
                { Upgrades.TERRANSHIPWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_TERRANSHIPWEAPONSLEVEL3, Time = 157 } },
                { Upgrades.TERRANVEHICLEANDSHIPARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TERRANVEHICLEANDSHIPPLATINGLEVEL1, Time = 114 } },
                { Upgrades.TERRANVEHICLEANDSHIPARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_TERRANVEHICLEANDSHIPPLATINGLEVEL2, Time = 136 } },
                { Upgrades.TERRANVEHICLEANDSHIPARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_ARMORY }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_TERRANVEHICLEANDSHIPPLATINGLEVEL3, Time = 157 } },

                { Upgrades.BATTLECRUISERENABLESPECIALIZATIONS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FUSIONCORE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_BATTLECRUISERWEAPONREFIT, Time = 100 } },
                { Upgrades.LIBERATORAGRANGEUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FUSIONCORE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_BALLISTICRANGE, Time = 79} },
                { Upgrades.MEDIVACINCREASESPEEDBOOST, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FUSIONCORE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_RAPIDREIGNITIONSYSTEM, Time = 57 } },

                { Upgrades.SHIELDWALL, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKSTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_COMBATSHIELD, Time = 79 } },
                { Upgrades.STIMPACK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKSTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_STIMPACK, Time = 100 } },
                { Upgrades.PUNISHERGRENADES, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_BARRACKSTECHLAB }, Minerals = 50, Gas = 50, Ability = Abilities.RESEARCH_CONCUSSIVESHELLS, Time = 43 } },

                { Upgrades.HIGHCAPACITYBARRELS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORYTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_INFERNALPREIGNITER, Time = 79 } },
                { Upgrades.CYCLONELOCKONDAMAGE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORYTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_CYCLONELOCKONDAMAGE, Time = 100 } },
                { Upgrades.DRILLCLAWS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORYTECHLAB }, Minerals = 75, Gas = 75, Ability = Abilities.RESEARCH_DRILLINGCLAWS, Time = 79 } },
                { Upgrades.SMARTSERVOS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_FACTORYTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_SMARTSERVOS, Time = 79 } },

                { Upgrades.RAVENCORVIDREACTOR, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORTTECHLAB }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_RAVENCORVIDREACTOR, Time = 79 } },
                { Upgrades.BANSHEECLOAK, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORTTECHLAB }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_BANSHEECLOAKINGFIELD, Time = 110 } },
                { Upgrades.BANSHEESPEED, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.TERRAN_STARPORTTECHLAB }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_BANSHEEHYPERFLIGHTROTORS, Time = 100} },
            };
        }

        public Dictionary<Upgrades, TrainingTypeData> ZergUpgradeData()
        {
            return new Dictionary<Upgrades, TrainingTypeData>
            {
                { Upgrades.BURROW, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HATCHERY, UnitTypes.ZERG_LAIR, UnitTypes.ZERG_HIVE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_BURROW, Time = 71 } },
                { Upgrades.OVERLORDSPEED, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HATCHERY, UnitTypes.ZERG_LAIR, UnitTypes.ZERG_HIVE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_PNEUMATIZEDCARAPACE, Time = 43 } },

                { Upgrades.ZERGLINGMOVEMENTSPEED, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPAWNINGPOOL }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_ZERGLINGMETABOLICBOOST, Time = 71 } },
                { Upgrades.ZERGLINGATTACKSPEED, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPAWNINGPOOL }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_ZERGLINGADRENALGLANDS, Time = 93 } },

                { Upgrades.ZERGMELEEWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_ZERGMELEEWEAPONSLEVEL1, Time = 114 } },
                { Upgrades.ZERGMELEEWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ZERGMELEEWEAPONSLEVEL2, Time = 136 } },
                { Upgrades.ZERGMELEEWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_ZERGMELEEWEAPONSLEVEL3, Time = 157 } },
                { Upgrades.ZERGMISSILEWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_ZERGMISSILEWEAPONSLEVEL1, Time = 114 } },
                { Upgrades.ZERGMISSILEWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ZERGMISSILEWEAPONSLEVEL2, Time = 136 } },
                { Upgrades.ZERGMISSILEWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 200, Gas = 200, Ability = Abilities.RESEARCH_ZERGMISSILEWEAPONSLEVEL3, Time = 157 } },
                { Upgrades.ZERGGROUNDARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ZERGGROUNDARMORLEVEL1, Time = 114 } },
                { Upgrades.ZERGGROUNDARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 225, Gas = 225, Ability = Abilities.RESEARCH_ZERGGROUNDARMORLEVEL2, Time = 136 } },
                { Upgrades.ZERGGROUNDARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_EVOLUTIONCHAMBER }, Minerals = 300, Gas = 300, Ability = Abilities.RESEARCH_ZERGGROUNDARMORLEVEL3, Time = 157 } },

                { Upgrades.GLIALRECONSTITUTION, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ROACHWARREN }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_GLIALREGENERATION, Time = 79 } },
                { Upgrades.TUNNELINGCLAWS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ROACHWARREN }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_TUNNELINGCLAWS, Time = 79 } },

                { Upgrades.CENTRIFICALHOOKS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_BANELINGNEST }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_CENTRIFUGALHOOKS, Time = 71 } },

                { Upgrades.INFESTORENERGYUPGRADE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_INFESTATIONPIT }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_PATHOGENGLANDS, Time = 57 } },
                { Upgrades.NEURALPARASITE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_INFESTATIONPIT }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_NEURALPARASITE, Time = 79 } },

                { Upgrades.EVOLVEGROOVEDSPINES, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HYDRALISKDEN }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_GROOVEDSPINES, Time = 50 } },
                { Upgrades.EVOLVEMUSCULARAUGMENTS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_HYDRALISKDEN }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_MUSCULARAUGMENTS, Time = 64 } },

                { Upgrades.ZERGFLYERARMORSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ZERGFLYERARMORLEVEL1, Time = 114 } },
                { Upgrades.ZERGFLYERARMORSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 225, Gas = 225, Ability = Abilities.RESEARCH_ZERGFLYERARMORLEVEL2, Time = 136 } },
                { Upgrades.ZERGFLYERARMORSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 300, Gas = 300, Ability = Abilities.RESEARCH_ZERGFLYERARMORLEVEL3, Time = 157 } },
                { Upgrades.ZERGFLYERWEAPONSLEVEL1, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 100, Gas = 100, Ability = Abilities.RESEARCH_ZERGFLYERATTACKLEVEL1, Time = 114 } },
                { Upgrades.ZERGFLYERWEAPONSLEVEL2, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 175, Gas = 175, Ability = Abilities.RESEARCH_ZERGFLYERATTACKLEVEL2, Time = 136 } },
                { Upgrades.ZERGFLYERWEAPONSLEVEL3, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_SPIRE, UnitTypes.ZERG_GREATERSPIRE }, Minerals = 250, Gas = 250, Ability = Abilities.RESEARCH_ZERGFLYERATTACKLEVEL3, Time = 157 } },

                { Upgrades.LURKERSPEED, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LURKERDENMP }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ADAPTIVETALONS, Time = 57 } },
                { Upgrades.LURKERRANGE, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_LURKERDENMP }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_LURKERRANGE, Time = 57 } },

                { Upgrades.CHITINOUSPLATING, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ULTRALISKCAVERN }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_CHITINOUSPLATING, Time = 79 } },
                { Upgrades.ANABOLICSYNTHESIS, new TrainingTypeData { ProducingUnits = new HashSet<UnitTypes> { UnitTypes.ZERG_ULTRALISKCAVERN }, Minerals = 150, Gas = 150, Ability = Abilities.RESEARCH_ANABOLICSYNTHESIS, Time = 43 } }
            };
        }
    }
}
