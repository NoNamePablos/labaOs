
namespace lab4
{
    public enum TypeOfWorksEnum
    {
        Type1,
        Type2,
        Type3
    }

    public class TypeOfWorks : IValidatable
    {
        // Оплата
        public decimal Coast { get; set; } = 10;
        // Описание
        public TypeOfWorksEnum TypeWork { get; set; } = TypeOfWorksEnum.Type1;
 
        public bool IsValid
        {
            get
            {
                if (Coast < 0) return false;
                return true;
            }
        }

        public TypeOfWorks()
        {

        }
        public TypeOfWorks(decimal coast, TypeOfWorksEnum type )
        {
            Coast = coast;
            TypeWork = type;
        }

        public override string ToString()
        {
            return
                $"Описание: {TypeWork}\r\n Оплата за день: {Coast}\r\n";
        }
    }

}


