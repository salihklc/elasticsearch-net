// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class ClosePointInTimeRequestParameters : RequestParameters<ClosePointInTimeRequestParameters>
	{
	}

	public partial class ClosePointInTimeRequest : PlainRequestBase<ClosePointInTimeRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClosePointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; set; }
	}

	public sealed partial class ClosePointInTimeRequestDescriptor : RequestDescriptorBase<ClosePointInTimeRequestDescriptor, ClosePointInTimeRequestParameters>
	{
		public ClosePointInTimeRequestDescriptor()
		{
		}

		internal ClosePointInTimeRequestDescriptor(Action<ClosePointInTimeRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClosePointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		internal Elastic.Clients.Elasticsearch.Id IdValue { get; private set; }

		public ClosePointInTimeRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id) => Assign(id, (a, v) => a.IdValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
			writer.WriteEndObject();
		}
	}
}