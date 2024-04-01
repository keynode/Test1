using G01.AzurePlayfabCommon.Models.PlayFabContext;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest")]
namespace G01.GameServices.PlayStreamEvents.Events
{
	
	internal record PlayerEvent : BaseGameEvent
	{
		//TODO: Remove after [G01-38286]
		public PlayerEvent(EventTypes eventType) 
			: base(eventType) { }

		public PlayerEvent(EventTypes eventType, PlayerId playerId)
			: base (eventType, playerId.TitlePlayerId)	{ }
	}
}
