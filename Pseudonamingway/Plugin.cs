using Dalamud.Plugin;

namespace Pseudonamingway;

public sealed class Plugin : IDalamudPlugin
{
	public Plugin(IDalamudPluginInterface dalamud)
	{
		Services.Init(dalamud);
		NamePlates.Init();
	}

	public void Dispose()
	{
		NamePlates.Dispose();
	}
}
