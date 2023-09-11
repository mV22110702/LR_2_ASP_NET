namespace LR_2
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public double Age { set; get; }
        public string University { set; get; }

        public Person() { 
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
            University = String.Empty;
        }
    }
}
