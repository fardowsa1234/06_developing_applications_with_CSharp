using sess01_introduction; // This connects to the namespace in your screenshots
// Create a new employee object using the constructor from your image
SampleEmployeeXMLDocumentation myEmployee = new SampleEmployeeXMLDocumentation(101, "Arthur", 'M');
// Now, let's actually print something based on that class
Console.WriteLine("--- Employee Records ---");
Console.WriteLine($"Employee ID: {myEmployee.GetID()}");