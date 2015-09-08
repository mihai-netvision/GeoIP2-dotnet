#region

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly:
    SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type",
        Target = "MaxMind.GeoIP2.Model.MaxMind")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member",
        Target = "MaxMind.GeoIP2.Model.NamedEntity.#Locales")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
        Target = "MaxMind.GeoIP2.Model.RepresentedCountry.#Type")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#", Scope = "member",
        Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1058:TypesShouldNotExtendCertainBaseTypes", Scope = "type",
        Target = "MaxMind.GeoIP2.Exceptions.GeoIP2Exception")]

// We are suppressing these as we have to maintain ABI compatability.
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#.ctor(System.String,System.Collections.Generic.List`1<System.String>,MaxMind.Db.FileAccessMode)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.Collections.Generic.List`1<System.String>,System.String,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member", Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.Collections.Generic.List`1<System.String>,System.String,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member", Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.String,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member", Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.Collections.Generic.IList`1<System.String>,System.String,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.Responses.InsightsResponse.#.ctor(MaxMind.GeoIP2.Model.City,MaxMind.GeoIP2.Model.Continent,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.Location,MaxMind.GeoIP2.Model.MaxMind,MaxMind.GeoIP2.Model.Postal,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.RepresentedCountry,System.Collections.Generic.List`1<MaxMind.GeoIP2.Model.Subdivision>,MaxMind.GeoIP2.Model.Traits)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.Responses.CityResponse.#.ctor(MaxMind.GeoIP2.Model.City,MaxMind.GeoIP2.Model.Continent,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.Location,MaxMind.GeoIP2.Model.MaxMind,MaxMind.GeoIP2.Model.Postal,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.RepresentedCountry,System.Collections.Generic.List`1<MaxMind.GeoIP2.Model.Subdivision>,MaxMind.GeoIP2.Model.Traits)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.Responses.AbstractCityResponse.#Subdivisions")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.Responses.AbstractCityResponse.#.ctor(MaxMind.GeoIP2.Model.City,MaxMind.GeoIP2.Model.Continent,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.Location,MaxMind.GeoIP2.Model.MaxMind,MaxMind.GeoIP2.Model.Postal,MaxMind.GeoIP2.Model.Country,MaxMind.GeoIP2.Model.RepresentedCountry,System.Collections.Generic.List`1<MaxMind.GeoIP2.Model.Subdivision>,MaxMind.GeoIP2.Model.Traits)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#.ctor(System.IO.Stream,System.Collections.Generic.List`1<System.String>)")]