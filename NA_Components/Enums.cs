using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components
{
    public enum Game_Languages
    {
        None, English, German
    }

    public enum FamilySocietyStatus
    {
        None, Low_Nobility, Nobility, Royalty, Imperial, Lowborn
    }

    public enum HoldingStatus
    {
        None, Castle, Palace, Temple, Camp, Port, Tribe
    }

    public enum CharacterSocietyStatus
    {
        Retainer, Lord, Daimyo, Shogun, Emperor
    }

    public enum FactionStatus
    {
        Clan, Shogunate, Imperial
    }

    public enum FactionDiplomaticRelationStatus
    {
        Neutral, Truce, War, Alliance, MarriageAlliance, IsVassal, IsOverlord, Wary, Dismissive, Refused, Amicable, Interest, Scorn
    }

    public enum CharacterPersonalityTypes
    {
        Conservative, Neutral, Progressive
    }
    public enum CharacterPersonalityTenets
    {
        Fame, Mastery, Clan, Ambition, Profit, Justice
    }

    public enum CharacterLocationTaskTypes
    {
        None, Adding_Facility, Removing_Facility, Replacing_Facility, Adding_Sector, Improving_Sector,
        Flooding_Sector, Appeasing_Tribe, Building_Castle, Building_Camp, Improving_Road,
        Stimulating_Concept,Transferring_To_Base
    }

    public enum CharacterTaskTypes
    {
        None, Leading_army, Part_Of_Army, Improving_Relations, Improving_Imperial_Relations
    }

    public enum CharacterTiers
    {
        C, B, A, S
    }

    public enum CharacterDeceasedReasons
    {
        Age, Slain, Assassinated, Poisoned, Unknown
    }

    public enum ArmyTroopTypes
    {
        Infantry, Bow, Cavalry, Muskets
    }
}
