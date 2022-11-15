// See https://aka.ms/new-console-template for more information

var x = new MyRecord("Hola");
var y = new MyRecordStruct("Mundo");

Console.WriteLine($"{x.Name} {y.Name}");

public record class MyRecord(string Name);
public record struct MyRecordStruct(string Name);