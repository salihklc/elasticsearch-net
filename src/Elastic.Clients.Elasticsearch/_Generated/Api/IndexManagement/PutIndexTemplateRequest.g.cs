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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public sealed class PutIndexTemplateRequestParameters : RequestParameters<PutIndexTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }
	}

	public partial class PutIndexTemplateRequest : PlainRequestBase<PutIndexTemplateRequestParameters>
	{
		public PutIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonInclude]
		[JsonPropertyName("index_patterns")]
		public Elastic.Clients.Elasticsearch.Indices? IndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("composed_of")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOf { get; set; }

		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? Template { get; set; }

		[JsonInclude]
		[JsonPropertyName("data_stream")]
		public Elastic.Clients.Elasticsearch.IndexManagement.DataStream? DataStream { get; set; }

		[JsonInclude]
		[JsonPropertyName("priority")]
		public int? Priority { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Dictionary<string, object>? Meta { get; set; }
	}

	public sealed partial class PutIndexTemplateRequestDescriptor<TDocument> : RequestDescriptorBase<PutIndexTemplateRequestDescriptor<TDocument>, PutIndexTemplateRequestParameters>
	{
		internal PutIndexTemplateRequestDescriptor(Action<PutIndexTemplateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public PutIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal PutIndexTemplateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public PutIndexTemplateRequestDescriptor<TDocument> Create(bool? create = true) => Qs("create", create);
		public PutIndexTemplateRequestDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }

		private IndexTemplateMappingDescriptor<TDocument> TemplateDescriptor { get; set; }

		private Action<IndexTemplateMappingDescriptor<TDocument>> TemplateDescriptorAction { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.DataStream? DataStreamValue { get; set; }

		private DataStreamDescriptor DataStreamDescriptor { get; set; }

		private Action<DataStreamDescriptor> DataStreamDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }

		private int? PriorityValue { get; set; }

		private long? VersionValue { get; set; }

		public PutIndexTemplateRequestDescriptor<TDocument> Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			TemplateValue = template;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> Template(IndexTemplateMappingDescriptor<TDocument> descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptor = descriptor;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> Template(Action<IndexTemplateMappingDescriptor<TDocument>> configure)
		{
			TemplateValue = null;
			TemplateDescriptor = null;
			TemplateDescriptorAction = configure;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> ComposedOf(IEnumerable<Elastic.Clients.Elasticsearch.Name>? composedOf)
		{
			ComposedOfValue = composedOf;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStream? dataStream)
		{
			DataStreamDescriptor = null;
			DataStreamDescriptorAction = null;
			DataStreamValue = dataStream;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> DataStream(DataStreamDescriptor descriptor)
		{
			DataStreamValue = null;
			DataStreamDescriptorAction = null;
			DataStreamDescriptor = descriptor;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> DataStream(Action<DataStreamDescriptor> configure)
		{
			DataStreamValue = null;
			DataStreamDescriptor = null;
			DataStreamDescriptorAction = configure;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
		{
			IndexPatternsValue = indexPatterns;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> Priority(int? priority)
		{
			PriorityValue = priority;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor<TDocument> Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateDescriptor, options);
			}
			else if (TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor<TDocument>(TemplateDescriptorAction), options);
			}
			else if (TemplateValue is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (ComposedOfValue is not null)
			{
				writer.WritePropertyName("composed_of");
				JsonSerializer.Serialize(writer, ComposedOfValue, options);
			}

			if (DataStreamDescriptor is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
			}
			else if (DataStreamDescriptorAction is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, new DataStreamDescriptor(DataStreamDescriptorAction), options);
			}
			else if (DataStreamValue is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamValue, options);
			}

			if (IndexPatternsValue is not null)
			{
				writer.WritePropertyName("index_patterns");
				JsonSerializer.Serialize(writer, IndexPatternsValue, options);
			}

			if (PriorityValue.HasValue)
			{
				writer.WritePropertyName("priority");
				writer.WriteNumberValue(PriorityValue.Value);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class PutIndexTemplateRequestDescriptor : RequestDescriptorBase<PutIndexTemplateRequestDescriptor, PutIndexTemplateRequestParameters>
	{
		internal PutIndexTemplateRequestDescriptor(Action<PutIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);
		public PutIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal PutIndexTemplateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementPutIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public PutIndexTemplateRequestDescriptor Create(bool? create = true) => Qs("create", create);
		public PutIndexTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? TemplateValue { get; set; }

		private IndexTemplateMappingDescriptor TemplateDescriptor { get; set; }

		private Action<IndexTemplateMappingDescriptor> TemplateDescriptorAction { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.DataStream? DataStreamValue { get; set; }

		private DataStreamDescriptor DataStreamDescriptor { get; set; }

		private Action<DataStreamDescriptor> DataStreamDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; set; }

		private int? PriorityValue { get; set; }

		private long? VersionValue { get; set; }

		public PutIndexTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateMapping? template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			TemplateValue = template;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor Template(IndexTemplateMappingDescriptor descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			TemplateDescriptor = descriptor;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor Template(Action<IndexTemplateMappingDescriptor> configure)
		{
			TemplateValue = null;
			TemplateDescriptor = null;
			TemplateDescriptorAction = configure;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public PutIndexTemplateRequestDescriptor ComposedOf(IEnumerable<Elastic.Clients.Elasticsearch.Name>? composedOf)
		{
			ComposedOfValue = composedOf;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStream? dataStream)
		{
			DataStreamDescriptor = null;
			DataStreamDescriptorAction = null;
			DataStreamValue = dataStream;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor DataStream(DataStreamDescriptor descriptor)
		{
			DataStreamValue = null;
			DataStreamDescriptorAction = null;
			DataStreamDescriptor = descriptor;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor DataStream(Action<DataStreamDescriptor> configure)
		{
			DataStreamValue = null;
			DataStreamDescriptor = null;
			DataStreamDescriptorAction = configure;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns)
		{
			IndexPatternsValue = indexPatterns;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor Priority(int? priority)
		{
			PriorityValue = priority;
			return Self;
		}

		public PutIndexTemplateRequestDescriptor Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateDescriptor, options);
			}
			else if (TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new IndexTemplateMappingDescriptor(TemplateDescriptorAction), options);
			}
			else if (TemplateValue is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (ComposedOfValue is not null)
			{
				writer.WritePropertyName("composed_of");
				JsonSerializer.Serialize(writer, ComposedOfValue, options);
			}

			if (DataStreamDescriptor is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
			}
			else if (DataStreamDescriptorAction is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, new DataStreamDescriptor(DataStreamDescriptorAction), options);
			}
			else if (DataStreamValue is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamValue, options);
			}

			if (IndexPatternsValue is not null)
			{
				writer.WritePropertyName("index_patterns");
				JsonSerializer.Serialize(writer, IndexPatternsValue, options);
			}

			if (PriorityValue.HasValue)
			{
				writer.WritePropertyName("priority");
				writer.WriteNumberValue(PriorityValue.Value);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}
}