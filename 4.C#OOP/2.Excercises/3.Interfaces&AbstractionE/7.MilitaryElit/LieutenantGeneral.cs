using System.Collections.Generic;

namespace _7.MilitaryElit
{
    public class LieutenantGeneral: ISoldier, IPrivate, ILieutenantGeneral
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public List<Private> Privates { get; set; }
    }
}