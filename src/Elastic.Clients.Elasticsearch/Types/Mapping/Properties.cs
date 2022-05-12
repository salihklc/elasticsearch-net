// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Linq.Expressions;

namespace Elastic.Clients.Elasticsearch.Mapping;

public partial class Properties
{
	public void Add<T>(Expression<Func<T, object>> name, IProperty property) => BackingDictionary.Add(name, property);

	public bool TryGetProperty<T>(PropertyName propertyName, out T property) where T : PropertyBase
	{
		if (BackingDictionary.TryGetValue(propertyName, out var propertyBase) && propertyBase is T finalProperty)
		{
			property = finalProperty;
			return true;
		}

		property = default;
		return false;
	}
}

public partial class Properties<T> : Properties
{
	public void Add<TValue>(Expression<Func<T, TValue>> name, IProperty property) => BackingDictionary.Add(name, property);
}

public partial class PropertiesDescriptor<T>
		: IsADictionaryDescriptorBase<PropertiesDescriptor<T>, Properties, PropertyName, IProperty>
{
	public PropertiesDescriptor() : base(new Properties<T>()) { }

	public PropertiesDescriptor(Properties properties) : base(properties ?? new Properties<T>()) { }

	//public PropertiesDescriptor<T> Boolean(Func<BooleanPropertyDescriptor<T>, BooleanProperty> selector) => SetProperty(selector);
}

public partial class TypeMappingDescriptor
{
	
}

