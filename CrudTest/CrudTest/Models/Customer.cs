using System;

namespace CrudTest.Models
{
    public class Customer
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public DateTime Birth { get; set; }

        public string Gender { get; set; }

        #endregion Properties

        #region Constructor

        public Customer()
        {

        }

        #endregion Constructor
    }
}