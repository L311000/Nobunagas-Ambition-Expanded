using NA_Components;
using NA_Components.Factions;
using NA_Components.Map;
using NA_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NA_Components.Graphical;

namespace NA_Components.Characters
{
    public class NPCCharacter : NA_Base
    {
        public NPCCharacterName Name { get; set; }
        public Dynasty Dynasty { get; set; }
        public bool IsMale { get; set; } = true;
        public bool IsStandby { get; set; }
        public bool IsCustom { get; set; }
        public bool IsRonin { get; set; }
        public bool IsMarried { get => Check_IsMarried(); }
        public bool AvailableForLocationTask { get => Check_AvailableForLocationTask(); }

        public DateOnly DateBorn { get; set; }
        public int Age { get => GetAge(); }
        public DateOnly DateDeceased { get; set; }
        public DateOnly DateDeceasedHistorical { get; set; }
        public CharacterDeceasedReasons DeceasedCause { get; set; }

        public NPCCharacter Father { get; set; }
        public NPCCharacter Mother { get; set; }
        public NPCCharacter Spouse { get; set; }
        public List<NPCCharacter> Siblings { get; set; }
        public List<NPCCharacter> Children { get; set; }

        public CharacterSocietyStatus SocietyStatus { get; set; }

        public int LEA_Value { get; set; } = 50;
        public int VAL_Value { get; set; } = 50;
        public int INT_Value { get; set; } = 50;
        public int POL_Value { get; set; } = 50;
        public CharacterPersonalityTypes Personality { get; set; }
        public CharacterPersonalityTenets Tenet { get; set; }
        public CharacterTiers Tier { get; set; }
        public int RequiredLoyalty { get; set; } = 8;
        public int Loyalty { get => CalculateLoyalty(); }

        public NPCCharacterTask LocationTask { get; set; }
        public CharacterTaskTypes CharacterTask { get; set; }

        public Faction FactionREF { get; set; }
        public FactionLordship FactionLordshipREF { get; set; }
        public Location CurrentLocationREF { get; set; }
        public Mon Emblem { get; set; }

        public int PowerScore { get => CalculatePowerScore(); }

        #region Checks and Getters
        private int GetAge()
        {
            if (IsALive())
            {
                return GameSession.CurrentDate.Year - DateBorn.Year;
            }
            else
            {
                return DateDeceased.Year - DateBorn.Year;
            }

        }

        public virtual bool IsBorn()
        {
            if (DateBorn < GameSession.CurrentDate)
            {
                return false;
            }
            return true;
        }

        private bool Check_AvailableForLocationTask()
        {
            if (this.CharacterTask != CharacterTaskTypes.Leading_army && this.CharacterTask != CharacterTaskTypes.Part_Of_Army)
            {
                return true;
            }
            return false;
        }


        private int CalculateLoyalty(bool cheat = false)
        {
            int loyalty = 0;
            if (cheat == true)
            {
                loyalty = 10000;
            }
            return loyalty;
        }

        public virtual bool HasChildren()
        {
            if (Children != null && Children.Count != 0)
            {
                return true;
            }
            return false;
        }

        public virtual bool HasChildrenAlive()
        {
            if (HasChildren())
            {
                foreach (var child in Children)
                {
                    if (child.IsALive())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public virtual List<NPCCharacter> GetChildrenNotAdult()
        {
            if (Children != null)
            {
                var children = Children.Where(x => x.Age < 17).ToList();
                return children;
            }
            return null;
        }

        public virtual bool IsAdult()
        {
            if (this.Age >= 16)
            {
                return true;
            }
            return false;
        }

        public virtual bool IsALive()
        {
            if (GameSession.CurrentDate < DateDeceased && this.IsBorn())
            {
                return true;
            }
            return false;
        }

        private bool Check_IsMarried()
        {
            if (Spouse != null && Spouse.IsALive())
            {
                return true;
            }
            return false;
        }

        private int CalculatePowerScore()
        {
            int score = LEA_Value + VAL_Value + INT_Value + POL_Value;
            return score;
        }

        #endregion

        #region Character Actions

        public virtual void ChangeLocation(Location l)
        {
            this.CurrentLocationREF = l;
        }

        #endregion
    }
}
