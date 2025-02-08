using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    class empicomparer : IComparer<employee>
    {
        public int Compare(employee? x, employee? y)
        {
            return x?.name.Length.CompareTo(y?.name.Length) ??-1 ;
        }
    }
    class employeeequalitycomar : IEqualityComparer<employee>
    {
        public bool Equals(employee? x, employee? y)
        {
            return x?.id.Equals(y.id) ??(( y?.id is null) ? true : false); 
        }

        public int GetHashCode([DisallowNull] employee obj)
        {
            return obj.id.GetHashCode();
        }
    }


    internal class employee : IComparable<employee>,IEquatable<employee>
    {

        public int id { get; set; }
        public string name { get; set; }
        public decimal salary { get; set; }

        public employee(int id ,string name,decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }

        public int CompareTo(employee? other)
        {
            if (other is null) return 1;
                return this.id.CompareTo(other.id);
        }



        public override string ToString()
        {
            return $"id:{id},name:{name},salary:{salary}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, salary);
        }
        //public override bool Equals(object? obj)
        //{
        //    if (obj is null || obj.GetType() != typeof(employee)) return false;
        //    employee? emp = (employee)obj;
        //    return this.id.Equals(emp.id) && this.name.Equals(emp.name) && this.salary.Equals(emp.salary);
        //}

        public bool Equals(employee? emp)//iequatable
        {
            return this.id.Equals(emp?.id) && this.name.Equals(emp.name) && this.salary.Equals(emp.salary);
        }
    }
}
