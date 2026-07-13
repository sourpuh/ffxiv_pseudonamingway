using System.Collections.Generic;

using Dalamud.Game.Gui.NamePlate;

namespace Mendingway;

internal static class NamePlates {
	private readonly static Dictionary<uint, (string name, string title)> NpcMap = new() {
		{ 1037791, ("Vendingway", "《Junkmonger》") },
		{ 1037792, ("Mendingway", "《Mender》") },
		{ 1045243, ("Vendingway", "《Junkmonger》") },
		{ 1045258, ("Mendingway", "《Mender》") },
		{ 1045256, ("Supplyingway", "《Material Supplier》") }
	};

	private static void OnNamePlateUpdate(INamePlateUpdateContext context, IReadOnlyList<INamePlateUpdateHandler> handlers) {
		foreach (var handler in handlers) {
			if (handler.GameObject != null && NpcMap.TryGetValue(handler.GameObject.BaseId, out var values)) {
				handler.Name = values.name;
				handler.Title = values.title;
				handler.DisplayTitle = true;
			}
		}
	}

	internal static void Init() {
		Services.NamePlateGui.OnNamePlateUpdate += OnNamePlateUpdate;
		Services.NamePlateGui.RequestRedraw();
	}

	internal static void Dispose() {
		Services.NamePlateGui.OnNamePlateUpdate -= OnNamePlateUpdate;
		Services.NamePlateGui.RequestRedraw();
	}
}
