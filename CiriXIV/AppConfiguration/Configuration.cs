using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CiriXIV.AppConfiguration
{
    public class Configuration
    {
        #region Culture infos
        public static string lang { get => Thread.CurrentThread.CurrentCulture.Name.Equals("fr-FR") ? "fr-FR" : "en-US"; }
        #endregion
    }
}
