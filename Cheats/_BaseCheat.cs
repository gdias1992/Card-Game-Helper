using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MelonLoader;

namespace Card_Game_Helper.BaseClasses
{
    abstract class _BaseCheat : iBaseCheat
    {
        protected int sleep = 1000;
        protected Boolean loop = true;
        protected Boolean enabled = false;
        protected Thread thread;

        protected _BaseCheat()
        {
            MelonLogger.Msg("_BaseCheat._BaseCheat()");
            this.thread = new Thread(new ThreadStart(run));            
        }

        protected _BaseCheat(int sleep)
        {
            MelonLogger.Msg("_BaseCheat._BaseCheat()");
            MelonLogger.Msg("_BaseCheat._BaseCheat.sleep: " + sleep);

            this.sleep = sleep;
            this.thread = new Thread(new ThreadStart(run));
        }

        public Boolean scriptToggle()
        {            
            this.enabled = !this.enabled;
            MelonLogger.Msg("_BaseCheat.scriptToggle: " + this.enabled);
            return this.enabled;
        }

        public void scriptEnable()
        {            
            this.enabled = true;
            MelonLogger.Msg("_BaseCheat.scriptEnable: " + this.enabled);
        }

        public void scriptDisable()
        {
            this.enabled = false;
            MelonLogger.Msg("_BaseCheat.scriptDisable: " + this.enabled);
        }

        public void loopStart()
        {
            if(this.thread.ThreadState == ThreadState.Unstarted)
            {
                this.loop = true;                
            }
            MelonLogger.Msg("_BaseCheat.loopStart: " + this.loop);
            if (this.loop)
            {
                this.thread.Start();
            }
        }

        public void loopEnd()
        {
            this.scriptDisable();
            this.loop = false;
            MelonLogger.Msg("_BaseCheat.loopEnd: " + this.loop);
        }

        public abstract void run();
    }

    interface iBaseCheat
    {
        void run();
    }
}
