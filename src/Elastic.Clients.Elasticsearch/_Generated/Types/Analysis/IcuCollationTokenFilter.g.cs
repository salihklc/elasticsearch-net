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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class IcuCollationTokenFilter : TokenFilterBase, ITokenFilterDefinition
	{
		[JsonInclude]
		[JsonPropertyName("alternate")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationAlternate Alternate { get; init; }

		[JsonInclude]
		[JsonPropertyName("caseFirst")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationCaseFirst Casefirst { get; init; }

		[JsonInclude]
		[JsonPropertyName("caseLevel")]
		public bool Caselevel { get; init; }

		[JsonInclude]
		[JsonPropertyName("country")]
		public string Country { get; init; }

		[JsonInclude]
		[JsonPropertyName("decomposition")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationDecomposition Decomposition { get; init; }

		[JsonInclude]
		[JsonPropertyName("hiraganaQuaternaryMode")]
		public bool Hiraganaquaternarymode { get; init; }

		[JsonInclude]
		[JsonPropertyName("language")]
		public string Language { get; init; }

		[JsonInclude]
		[JsonPropertyName("numeric")]
		public bool Numeric { get; init; }

		[JsonInclude]
		[JsonPropertyName("strength")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationStrength Strength { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_collation";
		[JsonInclude]
		[JsonPropertyName("variableTop")]
		public string? Variabletop { get; init; }

		[JsonInclude]
		[JsonPropertyName("variant")]
		public string Variant { get; init; }
	}
}