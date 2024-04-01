using G01.AzurePlayfabCommon.Models.PlayFabContext;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]
namespace G01.GameServices.PlayStreamEvents.Events
{
	internal record CharacterEvent(EventTypes eventType, CharacterId CharacterId)
		: BaseGameEvent(eventType)
	{
	}
}
