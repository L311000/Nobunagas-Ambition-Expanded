using NA_Components.Characters;
using NA_Components.Map;

namespace NA_Components.Factions
{
    public class Faction : NA_Base
    {
        public NPCCharacter Ruler { get => GetRuler();}
        public FactionLordship RulingLordship { get; set; }
        public List<FactionLordship> Lordships { get; set; } = [];
        public Mon FactionEmblem { get; set; }

        public virtual void TriggerSuccession()
        {
        }

        public virtual int GetTotalMembers()
        {
            int total = 0;
            foreach(var lordship in Lordships)
            {
                total += lordship.GetTotalMembers();
            }
            return total;
        }

        private NPCCharacter GetRuler()
        {
            return RulingLordship.Head;
        }
    }
}
