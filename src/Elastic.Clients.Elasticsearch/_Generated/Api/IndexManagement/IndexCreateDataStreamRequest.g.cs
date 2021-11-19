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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexCreateDataStreamRequestParameters : RequestParameters<IndexCreateDataStreamRequestParameters>
	{
	}

	public partial class IndexCreateDataStreamRequest : PlainRequestBase<IndexCreateDataStreamRequestParameters>
	{
		public IndexCreateDataStreamRequest(Elastic.Clients.Elasticsearch.DataStreamName name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreateDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
	}

	public sealed partial class IndexCreateDataStreamRequestDescriptor : RequestDescriptorBase<IndexCreateDataStreamRequestDescriptor, IndexCreateDataStreamRequestParameters>
	{
		public IndexCreateDataStreamRequestDescriptor(Elastic.Clients.Elasticsearch.DataStreamName name) : base(r => r.Required("name", name))
		{
		}

		public IndexCreateDataStreamRequestDescriptor()
		{
		}

		internal IndexCreateDataStreamRequestDescriptor(Action<IndexCreateDataStreamRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementCreateDataStream;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}