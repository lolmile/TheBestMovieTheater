// <copyright file="Person.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Holds an instance of a Person.
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// Gets or sets person's first name value.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets person's last name value.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets person's email Address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets person's username for login.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets person's password for login.
        /// </summary>
        public virtual string Password { get; set; }
    }
}
