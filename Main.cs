using MelonLoader;
using UnityEngine;
using YgomGame.Duel;

namespace Card_Game_Helper
{
    public class Main : MelonMod
    {
        public Main()
        {
            MelonLogger.Msg("Main.Main()");
            MelonLogger.Msg("F12: Surrender Enemy");
            MelonLogger.Msg("KeyPad+: Increase Game Speed");
            MelonLogger.Msg("KeyPad-: Decrease Game Speed");
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F12))
            {
                MelonLogger.Msg(">> Surrender Enemy");
                Engine.DLL_DuelComDoCommand(Engine.Rival(), 0, 0, 11);
            }
            else if (Input.GetKeyDown(KeyCode.KeypadPlus))
            {                
                float timeScale = Time.timeScale;
                Time.timeScale++;
                MelonLogger.Msg(">> Increase Game Speed: " +  timeScale + " -> " + Time.timeScale);
            }
            else if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                float timeScale = Time.timeScale;
                Time.timeScale--;
                MelonLogger.Msg(">> Decrease Game Speed: " + timeScale + " -> " + Time.timeScale);

            }
        }
    }
}
