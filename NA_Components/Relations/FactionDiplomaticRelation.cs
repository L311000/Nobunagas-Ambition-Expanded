using NA_Components;
using NA_Components.Factions;
using NA_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Relations
{
    public class FactionDiplomaticRelation : NA_Base
    {
        public Faction Faction1 { get; set; }
        public Faction Faction2 { get; set; }
        public FactionDiplomaticRelationStatus Status { get; set; }
        public int DurationMonths { get; set; }
        public DateOnly StartDate { get; set; }
        public bool IsTimeLimited { get; set; }
        public bool Remove { get; set; }
        public bool IsMarriageAlliance { get; set; }
        public Localisation Caption { get; set; }

        public FactionDiplomaticRelation(Faction f1, Faction f2)
        {
            Faction1 = f1;
            Faction2 = f2;
        }

        public virtual void IsValid(DateOnly currentDate)
        {
            if (IsTimeLimited)
            {
                if (currentDate > StartDate.AddMonths(DurationMonths))
                {
                    Remove = true;
                }
                Remove = false;
            }
        }

        public virtual void InitAlliance_1Year(DateOnly currentDate)
        {
            DurationMonths = 12;
            IsTimeLimited = true;
            Status = FactionDiplomaticRelationStatus.Alliance;
            StartDate = currentDate;
        }
        public virtual void InitAlliance_2Year(DateOnly currentDate)
        {
            DurationMonths = 24;
            IsTimeLimited = true;
            Status = FactionDiplomaticRelationStatus.Alliance;
            StartDate = currentDate;
        }
        public virtual void InitAlliance_Marriage(DateOnly currentDate)
        {
            DurationMonths = 0;
            IsMarriageAlliance = true;
            IsTimeLimited = false;
            Status = FactionDiplomaticRelationStatus.MarriageAlliance;
            StartDate = currentDate;
        }

    }
}
