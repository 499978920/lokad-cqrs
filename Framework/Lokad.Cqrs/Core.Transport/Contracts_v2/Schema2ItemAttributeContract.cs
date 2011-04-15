﻿using ProtoBuf;

namespace Lokad.Cqrs.Core.Transport.Contracts_v2
{
	[ProtoContract]
	public sealed class Schema2ItemAttributeContract
	{
		[ProtoMember(1)]
		public Schema2ItemAttributeTypeContract Type { get; set; }
		[ProtoMember(2)]
		public string CustomName { get; set; }
		[ProtoMember(3)]
		public string StringValue { get; set; }
		[ProtoMember(4)]
		public long NumberValue { get; set; }
	}
}