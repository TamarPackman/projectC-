using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public record Customer(int _idCard, string? _phone, string? _address, string _customerName)
    {

        //ctor func
        public Customer() : this(0, "", "", "")
        {

        }

        public override string ToString() =>Tools.ToStringProperty(this);


    }
}
