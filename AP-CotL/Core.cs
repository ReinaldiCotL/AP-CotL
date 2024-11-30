using Lamb.UI;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(AP_CotL.Core), "AP-CotL", "1.0.0", "ReinaldiCotL", null)]
[assembly: MelonGame("Massive Monster", "Cult Of The Lamb")]

namespace AP_CotL
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("AP-CotL Initialized.");
            Randomizer.Init();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
        }
    }
}