using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace Mendingway;

internal class Services {
	[PluginService] internal static INamePlateGui NamePlateGui { get; set; } = null!;

	internal static void Init(IDalamudPluginInterface dalamud) => dalamud.Create<Services>();
}
