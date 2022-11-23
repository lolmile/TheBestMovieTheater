using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestMovieTheater
{
    internal class Person
    {
        /// <summary>
        /// Person's first name value.
        /// </summary>
        public string firstName { get; set; }
        /// <summary>
        /// Person's last name value.
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// Person's email Address.
        /// </summary>
        public string emailAddress { get; set; }
        /// <summary>
        /// Person's username for login.
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// Person's password for login.
        /// </summary>
        public virtual string password { get; set; }
        
    }
}
