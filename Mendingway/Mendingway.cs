using Dalamud.Plugin;

namespace Mendingway;

public sealed class Mendingway : IDalamudPlugin {
	public Mendingway(IDalamudPluginInterface dalamud) {
		Services.Init(dalamud);
		NamePlates.Init();
	}

	public void Dispose() {
		NamePlates.Dispose();
	}
}
