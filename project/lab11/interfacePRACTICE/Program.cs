using System;

interface IPrintable
{
    void Print();
}
interface ISerializable
{
    void save();
}
class Documents: IPrintable, ISerializable
{
    public void Print()
    {
        Console.WriteLine("Printing the document");
    }

    public void save()
    {
        Console.WriteLine("Saving the document");
            }
}

class Program 
{
    static void Main()
    {
        Documents doc = new Documents();
        doc.Print();
        doc.save();
    }
}