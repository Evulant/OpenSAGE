﻿using OpenSage.Gui.Apt;
using OpenSage.Gui.Apt.ActionScript;

namespace OpenSage.Mods.Bfme.Gui
{
    [AptCallbacks(SageGame.Bfme)]
    static class Global
    {
        // Not sure what to do here
        public static void SetBackground(string param, ActionContext context, AptWindow window, Game game)
        {

        }

        public static void PlaySound(string param, ActionContext context, AptWindow window, Game game)
        {
            game.Audio.PlayAudioEvent(param);
        }
    }
}
