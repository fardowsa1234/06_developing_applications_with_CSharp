using System;
using System.Collections.Generic;
using System.Text;

namespace sess01_introduction
{
    public class SampleEmployeeXMLDocumentation
    {
        // Private Fields
        private uint _empID;
        private string _empName;
        private char _gender;
        /// <summary>
        /// Initialises a new instance with default values.
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; // this._empName = "";
            this._gender = 'M'; // Defaults to Male
        }
        /// <summary>
        /// Initialises a new instance with specified values.
        /// </summary>
        public SampleEmployeeXMLDocumentation(uint id, string name, char gender)
        {
            this._empID = id;
            this._empName = name;
            this._gender = gender;
        }
        // ID Getter and Setter
        public uint GetID() { return this._empID; }
        public void SetID(uint id) { this._empID = id; }
        // Name Getter and Setter
        public string GetName() { return this._empName; }
        public void SetName(string name) { this._empName = name; }
        // Gender Getter and Setter
        public char GetGender() { return this._gender; }
        public void SetGender(char gender) { this._gender = gender; }
    }

    class Program
    {
        static void Main()
        {
            // 1. Using the default constructor
            var emp1 = new SampleEmployeeXMLDocumentation();
            Console.WriteLine($"Default Employee ID: {emp1.GetID()}");
            // 2. Using the parameterized constructor
            var emp2 = new SampleEmployeeXMLDocumentation(101, "Alice", 'F');
            Console.WriteLine($"New Employee ID: {emp2.GetID()}");
            // 3. Using the SetID method
            emp1.SetID(500);
            Console.WriteLine($"Updated Default Employee ID: {emp1.GetID()}");
        }
    }
}
