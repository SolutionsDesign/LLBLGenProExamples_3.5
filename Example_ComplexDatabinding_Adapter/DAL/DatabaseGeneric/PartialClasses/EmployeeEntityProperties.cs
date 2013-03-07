using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DAL.EntityClasses
{
    /// <summary>
    /// Partial class for extending the EmployeeEntity with new properties. 
    /// </summary>
    public partial class EmployeeEntity
    {
        /// <summary>
        /// Gets the full name of the employee in the following format: FirstName LastName
        /// </summary>
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
