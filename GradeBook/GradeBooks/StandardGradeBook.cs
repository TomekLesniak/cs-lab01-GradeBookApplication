using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}