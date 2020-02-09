using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFWithAjax
{
    
    public class Employee
    {
        private int _id;
        private string _name;
        private float _salary;
        private string _address;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public float Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }

        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
    }
}
