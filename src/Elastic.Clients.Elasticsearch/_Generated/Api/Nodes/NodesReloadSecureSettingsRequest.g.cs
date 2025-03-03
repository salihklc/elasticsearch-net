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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public sealed class NodesReloadSecureSettingsRequestParameters : RequestParameters<NodesReloadSecureSettingsRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class NodesReloadSecureSettingsRequest : PlainRequestBase<NodesReloadSecureSettingsRequestParameters>
	{
		public NodesReloadSecureSettingsRequest()
		{
		}

		public NodesReloadSecureSettingsRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("secure_settings_password")]
		public string? SecureSettingsPassword { get; set; }
	}

	public sealed partial class NodesReloadSecureSettingsRequestDescriptor : RequestDescriptorBase<NodesReloadSecureSettingsRequestDescriptor, NodesReloadSecureSettingsRequestParameters>
	{
		internal NodesReloadSecureSettingsRequestDescriptor(Action<NodesReloadSecureSettingsRequestDescriptor> configure) => configure.Invoke(this);
		public NodesReloadSecureSettingsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public NodesReloadSecureSettingsRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public NodesReloadSecureSettingsRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? node_id)
		{
			RouteValues.Optional("node_id", node_id);
			return Self;
		}

		private string? SecureSettingsPasswordValue { get; set; }

		public NodesReloadSecureSettingsRequestDescriptor SecureSettingsPassword(string? secureSettingsPassword)
		{
			SecureSettingsPasswordValue = secureSettingsPassword;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (SecureSettingsPasswordValue is not null)
			{
				writer.WritePropertyName("secure_settings_password");
				JsonSerializer.Serialize(writer, SecureSettingsPasswordValue, options);
			}

			writer.WriteEndObject();
		}
	}
}