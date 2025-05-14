using NA_Components.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Characters
{
    public class NPCCharacterTask : NA_Base
    {
        public CharacterLocationTaskTypes TaskType { get; set; }
        public Localisations.Localisation TaskName { get; set; }
        public Localisations.Localisation TaskDescription { get; set; }
        public NPCCharacter Assigned { get; set; }
        public Location Location { get; set; }
        public int Progress { get; set; } = 0;
        public int DurationDays { get; set; }
        public int DailyProgress { get; set; }

        public virtual void CheckTask()
        {
            if (Progress >= 100)
            {
                Assigned.LocationTask = null;
                this.Assigned = null;
                ApplyCompleteEffect();
            }
        }

        public virtual void ApplyCompleteEffect()
        {

        }

        public virtual void AddProgress(int amount)
        {
            Progress += amount;
            CheckTask();
        }

        public virtual void AddDailyProgress()
        {
            Progress += DailyProgress;
            CheckTask();
        }
    }
}
