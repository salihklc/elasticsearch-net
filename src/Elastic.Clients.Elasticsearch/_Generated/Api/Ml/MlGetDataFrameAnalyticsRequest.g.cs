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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlGetDataFrameAnalyticsRequestParameters : RequestParameters<MlGetDataFrameAnalyticsRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }
	}

	public partial class MlGetDataFrameAnalyticsRequest : PlainRequestBase<MlGetDataFrameAnalyticsRequestParameters>
	{
		public MlGetDataFrameAnalyticsRequest()
		{
		}

		public MlGetDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningGetDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }
	}

	public sealed partial class MlGetDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptorBase<MlGetDataFrameAnalyticsRequestDescriptor<TDocument>, MlGetDataFrameAnalyticsRequestParameters>
	{
		internal MlGetDataFrameAnalyticsRequestDescriptor(Action<MlGetDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlGetDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningGetDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public MlGetDataFrameAnalyticsRequestDescriptor<TDocument> AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
		public MlGetDataFrameAnalyticsRequestDescriptor<TDocument> ExcludeGenerated(bool? excludeGenerated = true) => Qs("exclude_generated", excludeGenerated);
		public MlGetDataFrameAnalyticsRequestDescriptor<TDocument> From(int? from) => Qs("from", from);
		public MlGetDataFrameAnalyticsRequestDescriptor<TDocument> Size(int? size) => Qs("size", size);
		public MlGetDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class MlGetDataFrameAnalyticsRequestDescriptor : RequestDescriptorBase<MlGetDataFrameAnalyticsRequestDescriptor, MlGetDataFrameAnalyticsRequestParameters>
	{
		internal MlGetDataFrameAnalyticsRequestDescriptor(Action<MlGetDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);
		public MlGetDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningGetDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public MlGetDataFrameAnalyticsRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
		public MlGetDataFrameAnalyticsRequestDescriptor ExcludeGenerated(bool? excludeGenerated = true) => Qs("exclude_generated", excludeGenerated);
		public MlGetDataFrameAnalyticsRequestDescriptor From(int? from) => Qs("from", from);
		public MlGetDataFrameAnalyticsRequestDescriptor Size(int? size) => Qs("size", size);
		public MlGetDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}