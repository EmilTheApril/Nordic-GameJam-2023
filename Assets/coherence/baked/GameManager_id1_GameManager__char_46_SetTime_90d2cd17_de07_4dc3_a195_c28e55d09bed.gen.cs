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

	public struct GameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed : IEntityCommand
	{
		public float time;
		public SerializeEntityID player;

		public MessageTarget Routing => MessageTarget.All;
		public uint GetComponentType() => Definition.InternalGameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed;

		public GameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed
		(
			float datatime,
			SerializeEntityID dataplayer
		)
		{
			time = datatime;
			player = dataplayer;
		}

		public static void Serialize(GameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed commandData, IOutProtocolBitStream bitStream)
		{
			bitStream.WriteFloat(commandData.time, FloatMeta.NoCompression());
			bitStream.WriteEntity(commandData.player);
		}

		public static GameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed Deserialize(IInProtocolBitStream bitStream)
		{
			var datatime = bitStream.ReadFloat(FloatMeta.NoCompression());
			var dataplayer = bitStream.ReadEntity();

			return new GameManager_id1_GameManager__char_46_SetTime_90d2cd17_de07_4dc3_a195_c28e55d09bed
			(
				datatime,
				dataplayer
			){};
		}
	}
}