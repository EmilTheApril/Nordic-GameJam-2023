// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.Brook;
	using UnityEngine;
	using Coherence.Entity;

	public struct Player_id0_PlayerMovement__char_46_TagPerson_65889472_042b_489a_a11a_229914edd0d0 : IEntityCommand
	{

		public MessageTarget Routing => MessageTarget.All;
		public uint GetComponentType() => Definition.InternalPlayer_id0_PlayerMovement__char_46_TagPerson_65889472_042b_489a_a11a_229914edd0d0;

		public static void Serialize(Player_id0_PlayerMovement__char_46_TagPerson_65889472_042b_489a_a11a_229914edd0d0 commandData, IOutProtocolBitStream bitStream)
		{
		}

		public static Player_id0_PlayerMovement__char_46_TagPerson_65889472_042b_489a_a11a_229914edd0d0 Deserialize(IInProtocolBitStream bitStream)
		{

			return new Player_id0_PlayerMovement__char_46_TagPerson_65889472_042b_489a_a11a_229914edd0d0
			(
			){};
		}
	}
}
