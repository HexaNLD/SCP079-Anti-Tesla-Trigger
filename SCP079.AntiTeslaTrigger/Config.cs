using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SCP079.AntiTeslaTrigger
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        [DefaultValue(true)]
        public bool IsEnabled { get; set; } = true;
        [Description("Whether to show debug messages.")]
        [DefaultValue(false)]
        public bool Debug { get; set; } = false;
    }
}