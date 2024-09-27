// See https://aka.ms/new-console-template for more information

using AdvanceConsept;
using AdvanceConsept.CutomException;


//Generic Examples
//new GenericExamples();


//Custom Exception
var processor = new OrderProcessor();

try
{
    processor.ProcessOrder(-5); // This will throw the custom exception
}
catch (CustomErrorException ex)
{
    // Output the error details
    Console.WriteLine(ex);
}