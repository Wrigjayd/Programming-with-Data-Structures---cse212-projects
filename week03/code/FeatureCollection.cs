using System.Reflection.Metadata;
using System.Text.Json.Serialization;
public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features{get; set;} = new();

}
public class Feature
{
    //inside each feature is a properties dicionary and an object
    public Property Properties {get; set;} = new();

}
public class Property
{
    //individual data metrics needded to be logged
    public double? Mag {get; set;}
    public string Place {get; set;} = string.Empty;
}   