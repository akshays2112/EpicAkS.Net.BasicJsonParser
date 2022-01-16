using System;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.EpicAkSTestingIfAllTypesWork;

EpicAkSJsonHelpers.NamespaceScoped = "EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.";
EpicAkSJsonHelpers.NoWhitespace = true;

X1 x1 = new();
x1.X1_Prop1 = "X1_Prop1_Value";
x1.X1_Prop2 = null;
x1.X1_Prop3 = new();
x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
x1.X1_Prop3.A2_Prop2 = null;
x1.X1_Prop4 = null;
Console.WriteLine(EpicAkSJsonHelpers.Serialize(x1));

Console.WriteLine("\n\n");

J3 j3 = new();
j3.J3_Prop1 = "J3_Prop1_Value";
j3.J3_Prop2 = "J3_Prop2_Value";
j3.J3_Prop3 = "J3_Prop3_Value";
j3.J3_Prop4 = new();
j3.J3_Prop4.J4_Prop1 = "J4_Prop1_Value";
Console.WriteLine(EpicAkSJsonHelpers.Serialize(j3));

Console.WriteLine("\n\n");

string jsonStr = "{ \"j3_prop2_nullable_string\" : \"J3_Prop2_Value\", \"J3_Prop3\" : \"J3_Prop3_Value\", \"j3_prop4_j4\" : { \"j4_prop1\" : \"J4_Prop1_Value\" } }";
J3? j3_2 = new();
j3_2.J3_Prop4 = new();
j3_2 = EpicAkSJsonHelpers.Deserialize<J3>(j3, jsonStr);
Console.WriteLine(j3_2?.J3_Prop4?.J4_Prop1 ?? "Property not found!!");
Console.ReadLine();
