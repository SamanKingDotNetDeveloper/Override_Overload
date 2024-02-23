using System;

namespace Portfolio
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Sam sam = new Sam("Samandar","Baratov");
            Override @override = new Override();
            @override.OnOverride();
            sam.OnOverride();
            Console.ReadKey();
        }
    }
    public class Sam : Override
    {
        public override void OnOverride()
        {
            Console.WriteLine("Override qilindi");
        }
        public string FirstName, LastName;
        public override string ToString()
        {
            return $"FirstName {FirstName}\nLastName {LastName}";
        }
        public Sam(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public static Sam operator +(Sam Sam1, Sam Sam2)
        {
            return new Sam(Sam1.FirstName + Sam2.FirstName, Sam2.LastName + Sam2.LastName);
        }
    }
    public class Override
    {
        public virtual void OnOverride()
        {
            Console.WriteLine("Salom");
        }
    }
}
