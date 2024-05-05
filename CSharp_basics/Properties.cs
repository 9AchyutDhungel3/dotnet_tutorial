

namespace EnumsAndProperties
{
    internal class Person
    {
        //By default properties are private , but you can also use the keyword private.
        public byte age;
        private int grade;
        public string name;
        public string address;
        private DateTime dob;


        // Getter and Setter.
        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 30 && value < 40)
                {
                    age = value;
                }
            }
        }

        // Auto-implemented properties. (No logic implemented.)
        public string Address { get; set; }

        // Read-only
        public string Name { get; }

    }
}