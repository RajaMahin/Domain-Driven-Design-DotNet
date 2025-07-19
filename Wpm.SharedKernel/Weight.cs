namespace Wpm.SharedKernel
{
    /* DIFF B/W CLASS AND RECORD
        Class ->  
         A class in C# can have both mutable and immutable properties. 
         By default, classes allow properties to be modified after the object is created unless 
         you explicitly make them read-only or use other techniques to make them immutable.
     
        Record -> 
        A record is designed to be immutable by default. When you define a record, its properties are initialized during construction and cannot be modified afterward. 
        If you want to make a property mutable, you must explicitly use a set accessor, which is uncommon for records.
     */

    /* VALEU OBJECT RATHER THEN PRIMITIVE DATA TYPE */
    public record Weight
    {
        public decimal Value { get; init; }

        public Weight(decimal value)
        {

            if (value < 0)
            {
                throw new ArgumentException("Weight value is invalid");
            }

            Value = value;
        }
    }
}
