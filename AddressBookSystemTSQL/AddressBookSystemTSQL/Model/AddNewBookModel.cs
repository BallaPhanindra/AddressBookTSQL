using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemTSQL.Model
{
    internal class AddNewBookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public DateTime DateofBookCreation { get; set; }
    }
}