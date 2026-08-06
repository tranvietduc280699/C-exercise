using System;

// Lớp cơ sở chứa các thuộc tính chung
namespace DongVat
{
    public class DongVatBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public DongVatBase() { }

        public DongVatBase(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID} | Tên: {Name} | Cân nặng: {Weight} kg");
        }
    }
}

// Namespace DongVat.AnCo
namespace DongVat.AnCo
{
    public class Bo : DongVatBase
    {
        public Bo(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class Trau : DongVatBase
    {
        public Trau(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class De : DongVatBase
    {
        public De(int id, string name, double weight) : base(id, name, weight) { }
    }
}

// Namespace DongVat.AnThit
namespace DongVat.AnThit
{
    public class CaSau : DongVatBase
    {
        public CaSau(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class Ho : DongVatBase
    {
        public Ho(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class SuTu : DongVatBase
    {
        public SuTu(int id, string name, double weight) : base(id, name, weight) { }
    }
}

// Namespace DongVat.AnTap
namespace DongVat.AnTap
{
    public class Lợn : DongVatBase 
    {
        public Lợn(int id, string name, double weight) : base(id, name, weight) { }
    }
}