using NA_Components;
using NA_Components.Characters;
using NA_Components.Factions;
using NA_Components.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace NA_Components.Factions
{
    public class FactionLordship : NA_Base
    {
        public required NPCCharacter Head { get => GetHead(); set => ChangeHead(value); }
        public List<NPCCharacter> Retainers { get; set; } = [];
        public List<Location> Bases { get; set; } = [];
        public Faction FactionREF { get; set; }
        public string Name { get; set; }

        public FactionLordship(Faction f, NPCCharacter head)
        {
            FactionREF = f;
            ChangeHead(head);
        }

        public FactionLordship(Faction f, NPCCharacter head, List<NPCCharacter> retainers)
        {
            FactionREF = f;
            ChangeHead(head);
            foreach (NPCCharacter npc in retainers)
            {
                AddRetainer(npc);
            }
        }

        public virtual int GetTotalMembers()
        {
            return 1 + Retainers.Count;
        }

        public virtual void RefreshName()
        {
            Name = $"{Head.Name} {Head.Dynasty.Name}'s House";
        }

        public virtual void ChangeHead(NPCCharacter npc)
        {
            this.Head = npc;
            RefreshName();
        }

        public virtual void AddRetainer(NPCCharacter retainer)
        {
            Retainers.Add(retainer);
            retainer.SwitchLordship(FactionREF, this);
            retainer.ChangeLocation(Head.CurrentLocationREF);
        }

        public virtual void RemoveRetainer(NPCCharacter retainer)
        {
            Retainers.Remove(retainer);
            retainer.SwitchLordship(FactionREF, this.FactionREF.RulingLordship);
            retainer.ChangeLocation(this.FactionREF.Ruler.CurrentLocationREF);
        }

        public virtual void ChangeRetainerLocation(NPCCharacter retainer, Location l)
        {
            retainer.ChangeLocation(l);
        }

        public virtual void ChangeRetainerLocation(List<NPCCharacter> retainers, Location l)
        {
            foreach (NPCCharacter npc in retainers)
            {
                npc.ChangeLocation(l);
            }
        }

        public virtual void CreateArmy(NPCCharacter leader, NPCCharacter adjutant1, NPCCharacter adjutant2)
        {

        }

        public virtual void AssignTask(NPCCharacter retainer, NPCCharacterTask task)
        {
            retainer.LocationTask = task;
        }

        private NPCCharacter GetHead() { return this.Head; }
    }
}
