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
namespace Elastic.Clients.Elasticsearch
{
	public sealed class UpdateRequestParameters : RequestParameters<UpdateRequestParameters>
	{
		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

		[JsonIgnore]
		public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }
	}

	public partial class UpdateRequest<TDocument, TPartialDocument> : PlainRequestBase<UpdateRequestParameters>
	{
		public UpdateRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceUpdate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public TDocument Document { get; set; }

		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSeqNo { get => Q<long?>("if_seq_no"); set => Q("if_seq_no", value); }

		[JsonIgnore]
		public string? Lang { get => Q<string?>("lang"); set => Q("lang", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public bool? RequireAlias { get => Q<bool?>("require_alias"); set => Q("require_alias", value); }

		[JsonIgnore]
		public int? RetryOnConflict { get => Q<int?>("retry_on_conflict"); set => Q("retry_on_conflict", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonInclude]
		[JsonPropertyName("detect_noop")]
		public bool? DetectNoop { get; set; }

		[JsonInclude]
		[JsonPropertyName("doc")]
		[SourceConverter]
		public TPartialDocument? Doc { get; set; }

		[JsonInclude]
		[JsonPropertyName("doc_as_upsert")]
		public bool? DocAsUpsert { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("scripted_upsert")]
		public bool? ScriptedUpsert { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("upsert")]
		public TDocument? Upsert { get; set; }
	}

	public sealed partial class UpdateRequestDescriptor<TDocument, TPartialDocument> : RequestDescriptorBase<UpdateRequestDescriptor<TDocument, TPartialDocument>, UpdateRequestParameters>
	{
		internal UpdateRequestDescriptor(Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configure) => configure.Invoke(this);
		internal UpdateRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		public UpdateRequestDescriptor(TDocument document) : this(typeof(TDocument), Elasticsearch.Id.From(document)) => DocumentValue = document;
		public UpdateRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id) => DocumentValue = document;
		public UpdateRequestDescriptor(TDocument document, IndexName index) : this(index, Elasticsearch.Id.From(document)) => DocumentValue = document;
		public UpdateRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id) => DocumentValue = document;
		public UpdateRequestDescriptor(Id id) : this(typeof(TDocument), id)
		{
		}

		internal UpdateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceUpdate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> IfSeqNo(long? ifSeqNo) => Qs("if_seq_no", ifSeqNo);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> Lang(string? lang) => Qs("lang", lang);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> RequireAlias(bool? requireAlias = true) => Qs("require_alias", requireAlias);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> RetryOnConflict(int? retryOnConflict) => Qs("retry_on_conflict", retryOnConflict);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public UpdateRequestDescriptor<TDocument, TPartialDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; set; }

		private bool? DetectNoopValue { get; set; }

		private TPartialDocument? DocValue { get; set; }

		private bool? DocAsUpsertValue { get; set; }

		private bool? ScriptedUpsertValue { get; set; }

		private TDocument? UpsertValue { get; set; }

		private TDocument DocumentValue { get; set; }

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Source(Elastic.Clients.Elasticsearch.SourceConfig? source)
		{
			SourceValue = source;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> DetectNoop(bool? detectNoop = true)
		{
			DetectNoopValue = detectNoop;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Doc(TPartialDocument? doc)
		{
			DocValue = doc;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> DocAsUpsert(bool? docAsUpsert = true)
		{
			DocAsUpsertValue = docAsUpsert;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> ScriptedUpsert(bool? scriptedUpsert = true)
		{
			ScriptedUpsertValue = scriptedUpsert;
			return Self;
		}

		public UpdateRequestDescriptor<TDocument, TPartialDocument> Upsert(TDocument? upsert)
		{
			UpsertValue = upsert;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (DetectNoopValue.HasValue)
			{
				writer.WritePropertyName("detect_noop");
				writer.WriteBooleanValue(DetectNoopValue.Value);
			}

			if (DocValue is not null)
			{
				writer.WritePropertyName("doc");
				SourceSerialisation.Serialize(DocValue, writer, settings);
			}

			if (DocAsUpsertValue.HasValue)
			{
				writer.WritePropertyName("doc_as_upsert");
				writer.WriteBooleanValue(DocAsUpsertValue.Value);
			}

			if (ScriptedUpsertValue.HasValue)
			{
				writer.WritePropertyName("scripted_upsert");
				writer.WriteBooleanValue(ScriptedUpsertValue.Value);
			}

			if (UpsertValue is not null)
			{
				writer.WritePropertyName("upsert");
				JsonSerializer.Serialize(writer, UpsertValue, options);
			}

			writer.WriteEndObject();
		}
	}
}