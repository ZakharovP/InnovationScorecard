using Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Server
{
    public class Table
    {
        public DataTable ParamTable { private set; get; }
        public DataTable ScoreTable { private set; get; }
        /// <summary>
        /// Dictionary countries contains mapping of country name to country object
        /// </summary>
        private Dictionary<string, Country> countries = new Dictionary<string, Country>();
        public Table(DataTable paramTable, DataTable scoreTable)
        {
            ParamTable = paramTable;
            ScoreTable = scoreTable;
        }
    }
}
