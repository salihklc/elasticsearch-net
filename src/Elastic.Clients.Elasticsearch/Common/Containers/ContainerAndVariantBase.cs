// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;

namespace Elastic.Clients.Elasticsearch;

public abstract class ContainerAndVariantBase<TVariantContainer> : ContainerVariantBase<TVariantContainer>, IContainer where TVariantContainer : IContainer
{
	internal ContainerVariantBase Variant { get; }

	public ContainerAndVariantBase(ContainerVariantBase variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
}
