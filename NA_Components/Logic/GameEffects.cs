using NA_Components.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_Components.Logic
{
    public static class GameEffects
    {
        #region Global
        public static bool Kill_Character_1(NPCCharacter c)
        {
            if (c.IsALive())
            {
                c.DateDeceased = GameSession.CurrentDate;
                if (c.IsRonin == false)
                {
                    if (c.SocietyStatus > CharacterSocietyStatus.Retainer)
                    {
                        var location = c.CurrentLocationREF;
                        if (c == location.Base.Lord)
                        {
                            location.Base.Lord = null;
                        }
                        else if (c == location.Base.Chamberlein)
                        {
                            location.Base.Chamberlein = null;
                        }
                        c.CurrentLocationREF = null;
                    }
                }
                return true;
            }
            return false;
        }
    }

    #endregion
}
