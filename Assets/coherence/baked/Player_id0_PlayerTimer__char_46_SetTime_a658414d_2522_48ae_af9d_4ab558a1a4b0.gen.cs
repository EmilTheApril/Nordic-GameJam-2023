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

	public struct Player_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0 : IEntityCommand
	{
		public float time;

		public MessageTarget Routing => MessageTarget.AuthorityOnly;
		public uint GetComponentType() => Definition.InternalPlayer_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0;

		public Player_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0
		(
			float datatime
		)
		{
			time = datatime;
		}

		public static void Serialize(Player_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0 commandData, IOutProtocolBitStream bitStream)
		{
			bitStream.WriteFloat(commandData.time, FloatMeta.NoCompression());
		}

		public static Player_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0 Deserialize(IInProtocolBitStream bitStream)
		{
			var datatime = bitStream.ReadFloat(FloatMeta.NoCompression());

			return new Player_id0_PlayerTimer__char_46_SetTime_a658414d_2522_48ae_af9d_4ab558a1a4b0
			(
				datatime
			){};
		}
	}
}
