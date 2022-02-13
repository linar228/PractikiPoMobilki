using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1.SQLITE
{
    [Table("Project")]
    internal class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        [Unique]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PTitle { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
