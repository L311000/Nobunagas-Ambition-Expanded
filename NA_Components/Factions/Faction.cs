using NA_Components.Characters;
using NA_Components.Graphical;
using NA_Components.Map;

namespace NA_Components.Factions
{
    public class Faction : NA_Base
    {
        public NPCCharacter Ruler { get => GetRuler(); }
        public FactionLordship RulingLordship { get; set; }
        public List<FactionLordship> Lordships { get; set; } = [];
        public Mon FactionEmblem { get => GetRulerEmblem(); }

        public virtual void TriggerSuccession()
        {
            NPCCharacter newRuler = null;
            if (HasRelativeInFaction(Ruler))
            {
                newRuler = GetOldestRelativeInFaction(Ruler);
                RulingLordship.Head = newRuler;
                return;
            }
            else
            {
                newRuler = GetSuccessorNotRelated();
                if (newRuler != null)
                {
                    this.RulingLordship.Head = newRuler;
                    return;
                }
                else
                {
                    //TODO disband faction
                }
            }
            //TODO disband faction
        }

        public virtual bool HasRelativeInFaction(NPCCharacter character)
        {
            foreach (var lordship in Lordships)
            {
                if (lordship.Head.Dynasty == character.Dynasty || lordship.Retainers.Any(x => x.Dynasty == character.Dynasty))
                {
                    return true;
                }
            }
            return false;
        }

        public virtual NPCCharacter GetOldestRelativeInFaction(NPCCharacter character)
        {
            List<NPCCharacter> relatives = new();
            NPCCharacter npc = null;
            foreach (var lordship in Lordships)
            {
                if (lordship.Head.Dynasty == character.Dynasty)
                {
                    relatives.Add(lordship.Head);
                }
                foreach (var retainer in lordship.Retainers)
                {
                    if (retainer.Dynasty == character.Dynasty)
                    {
                        relatives.Add(retainer);
                    }
                }
                if (relatives.Count > 0)
                {
                    npc = (NPCCharacter?)relatives.Where(x => x.Age == relatives.Max(x => x.Age));
                }
            }
            return npc;
        }

        public virtual NPCCharacter GetSuccessorNotRelated()
        {
            if (GetTotalMembersAmount() > 1)
            {
                var members = GetAllRetainers();
                var successor = members.Where(x => x.PowerScore == members.Max(x => x.PowerScore)).FirstOrDefault();
                return successor;
            }
            return null;
        }

        public virtual int GetTotalMembersAmount()
        {
            int total = 0;
            foreach (var lordship in Lordships)
            {
                total += lordship.GetTotalMembers();
            }
            return total;
        }

        public virtual List<NPCCharacter> GetAllRetainers()
        {
            List<NPCCharacter> members = new();
            foreach (var lordship in Lordships)
            {
                members.Add(lordship.Head);
                foreach (var ret in lordship.Retainers)
                {
                    members.Add(ret);
                }
            }
            return members;
        }

        private NPCCharacter GetRuler()
        {
            return RulingLordship.Head;
        }

        private Mon GetRulerEmblem()
        {
            return Ruler.Emblem;
        }
    }
}
