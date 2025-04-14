using NA_Components.Characters;
using NA_Components.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Factions
{
    public class FactionArmy
    {
        public NPCCharacter Leader { get; set; }
        public NPCCharacter Adjutant1 { get; set; }
        public NPCCharacter Adjutant2 { get; set; }

        public Location CurrentLocationREF { get; set; }
        public Location CurrentTargetREF { get; set; }
        public Location FinalTargetREF { get; set; }
        public DateOnly LatestSupplyRefresh { get; set; }
        public DateOnly EstimatedArrival { get; set; }

        public int Soldiers { get; set; }
        public int SuppliesDays { get; set; } = 30;

        public ArmyTroopTypes ArmyTroop1 { get; set; }
        public ArmyTroopTypes ArmyTroop2 { get; set; }
        public ArmyTroopTypes ArmyTroop3 { get; set; }
        public ArmyTroopTypes ArmyTroop4 { get; set; }
    }
}
