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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class RuntimeFieldTypes
	{
		[JsonInclude]
		[JsonPropertyName("chars_max")]
		public int CharsMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("chars_total")]
		public int CharsTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public int Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_max")]
		public int DocMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_total")]
		public int DocTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_count")]
		public int IndexCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("lang")]
		public IReadOnlyCollection<string> Lang { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_max")]
		public int LinesMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_total")]
		public int LinesTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("scriptless_count")]
		public int ScriptlessCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("shadowed_count")]
		public int ShadowedCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_max")]
		public int SourceMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_total")]
		public int SourceTotal { get; init; }
	}
}