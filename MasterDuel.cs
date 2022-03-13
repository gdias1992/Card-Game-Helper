using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using YgomGame.Duel;

namespace YuGiOh_Master_Duel
{
    public class MasterDuel : MelonMod
    {
        public MasterDuel()
        {
            MelonLogger.Msg("MasterDuel.MasterDuel()");
            MelonLogger.Msg("F12: Surrender Enemy");
            MelonLogger.Msg("KeyPad+: Increase Game Speed");
            MelonLogger.Msg("KeyPad-: Decrease Game Speed");
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F12))
            {
                MelonLogger.Msg(">> Engine.DLL_DuelComDoCommand");
                Engine.DLL_DuelComDoCommand(Engine.Rival(), 0, 0, 11);
            }
            else if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {                
                float timeScale = Time.timeScale;
                Time.timeScale++;
                MelonLogger.Msg(">> Time.timeScale: " +  timeScale + " -> " + Time.timeScale);
            }
            else if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                float timeScale = Time.timeScale;
                Time.timeScale--;
                MelonLogger.Msg(">> Time.timeScale: " + timeScale + " -> " + Time.timeScale);

            }
        }
    }
}
