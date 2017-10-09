using System;

namespace CrudTest.Models
{
    public class Customer
    {
        #region Properties

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Cpf { get; set; }

        public virtual DateTime Birth { get; set; }

        public virtual string Gender { get; set; }

        #endregion Properties

        #region Constructor

        public Customer()
        {

        }

        #endregion Constructor
    }
}